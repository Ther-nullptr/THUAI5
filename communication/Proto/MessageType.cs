// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Communication.Proto {

  /// <summary>Holder for reflection information generated from MessageType.proto</summary>
  public static partial class MessageTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNZXNzYWdlVHlwZS5wcm90bxIIUHJvdG9idWYqxAEKC01lc3NhZ2VUeXBl",
            "Eg0KCUFkZFBsYXllchAAEggKBE1vdmUQARIKCgZBdHRhY2sQAhIICgRQaWNr",
            "EAMSBwoDVXNlEAQSCQoFVGhyb3cQBRIICgRTZW5kEAYSEQoNSW52YWxpZFBs",
            "YXllchAHEg8KC1ZhbGlkUGxheWVyEAgSDQoJU3RhcnRHYW1lEAkSCgoGR2Ft",
            "aW5nEAoSCwoHRW5kR2FtZRALEg0KCVVzZVNraWxsMRAMEg0KCVVzZVNraWxs",
            "MhANQhaqAhNDb21tdW5pY2F0aW9uLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Communication.Proto.MessageType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MessageType {
    [pbr::OriginalName("AddPlayer")] AddPlayer = 0,
    [pbr::OriginalName("Move")] Move = 1,
    /// <summary>
    ///注：编者设想“除携带被动技能‘命中’的人物外，其余人物均不以子弹攻击”
    /// </summary>
    [pbr::OriginalName("Attack")] Attack = 2,
    [pbr::OriginalName("Pick")] Pick = 3,
    [pbr::OriginalName("Use")] Use = 4,
    [pbr::OriginalName("Throw")] Throw = 5,
    [pbr::OriginalName("Send")] Send = 6,
    [pbr::OriginalName("InvalidPlayer")] InvalidPlayer = 7,
    [pbr::OriginalName("ValidPlayer")] ValidPlayer = 8,
    [pbr::OriginalName("StartGame")] StartGame = 9,
    [pbr::OriginalName("Gaming")] Gaming = 10,
    [pbr::OriginalName("EndGame")] EndGame = 11,
    /// <summary>
    ///新增信息类型：使用主动技能1
    /// </summary>
    [pbr::OriginalName("UseSkill1")] UseSkill1 = 12,
    /// <summary>
    ///使用主动技能2
    /// </summary>
    [pbr::OriginalName("UseSkill2")] UseSkill2 = 13,
  }

  #endregion

}

#endregion Designer generated code