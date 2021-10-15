﻿using GameClass.Skill;
using Preparation.Utility;

namespace GameClass.GameObj
{
    public partial class Character
    {
        public object SkillLock => gameObjLock;
        private delegate bool CharacterActiveSkill(Character player); //返回值：是否成功释放了技能
        private delegate void CharacterPassiveSkill(Character player);
        CharacterActiveSkill commonSkill;
        public bool UseCommonSkill()
        {
            return commonSkill(this);
        }
        private int timeUntilCommonSkillAvailable = 0; //还剩多少时间可以使用普通技能
        public int TimeUntilCommonSkillAvailable
        {
            get => timeUntilCommonSkillAvailable;
            set
            {
                lock (SkillLock)
                    TimeUntilCommonSkillAvailable = value < 0 ? 0 : value;
            }
        }
        CharacterPassiveSkill passiveSkill;
        public void UsePassiveSkill()
        {
            passiveSkill(this);
            return;
        }
        public Character(XYPosition initPos, int initRadius, PlaceType initPlace, PassiveSkillType passiveSkill, ActiveSkillType commonSkill) : base(initPos, initRadius, initPlace)
        {
            this.CanMove = true;
            this.Type = GameObjType.Character;
            PassiveSkill pSkill;
            CommonSkill cSkill;
            switch (passiveSkill)
            {
                case PassiveSkillType.RecoverAfterBattle:
                    pSkill = new RecoverAfterBattle();
                    break;
                case PassiveSkillType.SpeedUpWhenLeavingGrass:
                    pSkill = new SpeedUpWhenLeavingGrass();
                    break;
                case PassiveSkillType.Vampire:
                    pSkill = new Vampire();
                    break;
                default:
                    pSkill = new NoPassiveSkill();
                    break;
            }
            switch (commonSkill)
            {
                case ActiveSkillType.BecomeAssassin:
                    cSkill = new BecomeAssassin();
                    break;
                case ActiveSkillType.BecomeVampire:
                    cSkill = new BecomeVampire();
                    break;
                case ActiveSkillType.NuclearWeapon:
                    cSkill = new NuclearWeapon();
                    break;
                case ActiveSkillType.SuperFast:
                    cSkill = new SuperFast();
                    break;
                default:
                    cSkill = new NoCommonSkill();
                    break;
            }
            this.attackRange = cSkill.AttackRange;
            this.hp = cSkill.MaxHp;
            this.moveSpeed = cSkill.MoveSpeed;
            this.commonSkill = cSkill.SkillEffect;
            this.cd = cSkill.CD;
            this.maxBulletNum = cSkill.MaxBulletNum;
            this.bulletOfPlayer = pSkill.InitBullet;
            this.passiveSkill = pSkill.SkillEffect;
            this.bulletOfPlayer.Parent = this;

            //UsePassiveSkill();  //创建player时开始被动技能，这一过程也可以放到gamestart时进行
            //这可以放在AddPlayer中做
        }
    }   
}