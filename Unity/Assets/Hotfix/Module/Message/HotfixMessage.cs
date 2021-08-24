// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: HotfixMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace ETHotfix {

  #region Messages
  public partial class C2R_Register : pb::IMessage {
    private static readonly pb::MessageParser<C2R_Register> _parser = new pb::MessageParser<C2R_Register>(() => (C2R_Register)MessagePool.Instance.Fetch(typeof(C2R_Register)));
    public static pb::MessageParser<C2R_Register> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private string account_ = "";
    /// <summary>
    /// 帐号
    /// </summary>
    public string Account {
      get { return account_; }
      set {
        account_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string password_ = "";
    /// <summary>
    /// 密码
    /// </summary>
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Account.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Account);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Account.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Account);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      account_ = "";
      password_ = "";
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Account = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class R2C_Register : pb::IMessage {
    private static readonly pb::MessageParser<R2C_Register> _parser = new pb::MessageParser<R2C_Register>(() => (R2C_Register)MessagePool.Instance.Fetch(typeof(R2C_Register)));
    public static pb::MessageParser<R2C_Register> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string address_ = "";
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      address_ = "";
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Address = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class C2R_Login : pb::IMessage {
    private static readonly pb::MessageParser<C2R_Login> _parser = new pb::MessageParser<C2R_Login>(() => (C2R_Login)MessagePool.Instance.Fetch(typeof(C2R_Login)));
    public static pb::MessageParser<C2R_Login> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private string account_ = "";
    /// <summary>
    /// 帐号
    /// </summary>
    public string Account {
      get { return account_; }
      set {
        account_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string password_ = "";
    /// <summary>
    /// 密码
    /// </summary>
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Account.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Account);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Account.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Account);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      account_ = "";
      password_ = "";
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Account = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class R2C_Login : pb::IMessage {
    private static readonly pb::MessageParser<R2C_Login> _parser = new pb::MessageParser<R2C_Login>(() => (R2C_Login)MessagePool.Instance.Fetch(typeof(R2C_Login)));
    public static pb::MessageParser<R2C_Login> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string address_ = "";
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private long key_;
    public long Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (Key != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Key);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (Key != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Key);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      address_ = "";
      key_ = 0;
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Address = input.ReadString();
            break;
          }
          case 16: {
            Key = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class C2G_LoginGate : pb::IMessage {
    private static readonly pb::MessageParser<C2G_LoginGate> _parser = new pb::MessageParser<C2G_LoginGate>(() => (C2G_LoginGate)MessagePool.Instance.Fetch(typeof(C2G_LoginGate)));
    public static pb::MessageParser<C2G_LoginGate> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long key_;
    /// <summary>
    /// 帐号
    /// </summary>
    public long Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Key != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Key);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Key != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Key);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      key_ = 0;
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Key = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class G2C_LoginGate : pb::IMessage {
    private static readonly pb::MessageParser<G2C_LoginGate> _parser = new pb::MessageParser<G2C_LoginGate>(() => (G2C_LoginGate)MessagePool.Instance.Fetch(typeof(G2C_LoginGate)));
    public static pb::MessageParser<G2C_LoginGate> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private long playerId_;
    public long PlayerId {
      get { return playerId_; }
      set {
        playerId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(PlayerId);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (PlayerId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PlayerId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      playerId_ = 0;
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            PlayerId = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class G2C_TestHotfixMessage : pb::IMessage {
    private static readonly pb::MessageParser<G2C_TestHotfixMessage> _parser = new pb::MessageParser<G2C_TestHotfixMessage>(() => (G2C_TestHotfixMessage)MessagePool.Instance.Fetch(typeof(G2C_TestHotfixMessage)));
    public static pb::MessageParser<G2C_TestHotfixMessage> Parser { get { return _parser; } }

    private string info_ = "";
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Info.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Info);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Info.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      info_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Info = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class C2M_TestActorRequest : pb::IMessage {
    private static readonly pb::MessageParser<C2M_TestActorRequest> _parser = new pb::MessageParser<C2M_TestActorRequest>(() => (C2M_TestActorRequest)MessagePool.Instance.Fetch(typeof(C2M_TestActorRequest)));
    public static pb::MessageParser<C2M_TestActorRequest> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long actorId_;
    public long ActorId {
      get { return actorId_; }
      set {
        actorId_ = value;
      }
    }

    private string info_ = "";
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Info.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Info);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (ActorId != 0L) {
        output.WriteRawTag(216, 5);
        output.WriteInt64(ActorId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (ActorId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ActorId);
      }
      if (Info.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      info_ = "";
      rpcId_ = 0;
      actorId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Info = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            ActorId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public partial class M2C_TestActorResponse : pb::IMessage {
    private static readonly pb::MessageParser<M2C_TestActorResponse> _parser = new pb::MessageParser<M2C_TestActorResponse>(() => (M2C_TestActorResponse)MessagePool.Instance.Fetch(typeof(M2C_TestActorResponse)));
    public static pb::MessageParser<M2C_TestActorResponse> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string info_ = "";
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Info.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Info);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Info.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      info_ = "";
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Info = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class PlayerInfo : pb::IMessage {
    private static readonly pb::MessageParser<PlayerInfo> _parser = new pb::MessageParser<PlayerInfo>(() => (PlayerInfo)MessagePool.Instance.Fetch(typeof(PlayerInfo)));
    public static pb::MessageParser<PlayerInfo> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class C2G_PlayerInfo : pb::IMessage {
    private static readonly pb::MessageParser<C2G_PlayerInfo> _parser = new pb::MessageParser<C2G_PlayerInfo>(() => (C2G_PlayerInfo)MessagePool.Instance.Fetch(typeof(C2G_PlayerInfo)));
    public static pb::MessageParser<C2G_PlayerInfo> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class G2C_PlayerInfo : pb::IMessage {
    private static readonly pb::MessageParser<G2C_PlayerInfo> _parser = new pb::MessageParser<G2C_PlayerInfo>(() => (G2C_PlayerInfo)MessagePool.Instance.Fetch(typeof(G2C_PlayerInfo)));
    public static pb::MessageParser<G2C_PlayerInfo> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private global::ETHotfix.PlayerInfo playerInfo_;
    public global::ETHotfix.PlayerInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::ETHotfix.PlayerInfo> _repeated_playerInfos_codec
        = pb::FieldCodec.ForMessage(18, global::ETHotfix.PlayerInfo.Parser);
    private pbc::RepeatedField<global::ETHotfix.PlayerInfo> playerInfos_ = new pbc::RepeatedField<global::ETHotfix.PlayerInfo>();
    public pbc::RepeatedField<global::ETHotfix.PlayerInfo> PlayerInfos {
      get { return playerInfos_; }
      set { playerInfos_ = value; }
    }

    private static readonly pb::FieldCodec<string> _repeated_testRepeatedString_codec
        = pb::FieldCodec.ForString(26);
    private pbc::RepeatedField<string> testRepeatedString_ = new pbc::RepeatedField<string>();
    public pbc::RepeatedField<string> TestRepeatedString {
      get { return testRepeatedString_; }
      set { testRepeatedString_ = value; }
    }

    private static readonly pb::FieldCodec<int> _repeated_testRepeatedInt32_codec
        = pb::FieldCodec.ForInt32(34);
    private pbc::RepeatedField<int> testRepeatedInt32_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> TestRepeatedInt32 {
      get { return testRepeatedInt32_; }
      set { testRepeatedInt32_ = value; }
    }

    private static readonly pb::FieldCodec<long> _repeated_testRepeatedInt64_codec
        = pb::FieldCodec.ForInt64(42);
    private pbc::RepeatedField<long> testRepeatedInt64_ = new pbc::RepeatedField<long>();
    public pbc::RepeatedField<long> TestRepeatedInt64 {
      get { return testRepeatedInt64_; }
      set { testRepeatedInt64_ = value; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (playerInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PlayerInfo);
      }
      playerInfos_.WriteTo(output, _repeated_playerInfos_codec);
      testRepeatedString_.WriteTo(output, _repeated_testRepeatedString_codec);
      testRepeatedInt32_.WriteTo(output, _repeated_testRepeatedInt32_codec);
      testRepeatedInt64_.WriteTo(output, _repeated_testRepeatedInt64_codec);
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      size += playerInfos_.CalculateSize(_repeated_playerInfos_codec);
      size += testRepeatedString_.CalculateSize(_repeated_testRepeatedString_codec);
      size += testRepeatedInt32_.CalculateSize(_repeated_testRepeatedInt32_codec);
      size += testRepeatedInt64_.CalculateSize(_repeated_testRepeatedInt64_codec);
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      if (playerInfo_ != null) MessagePool.Instance.Recycle(playerInfo_); playerInfo_ = null;
      for (int i = 0; i < playerInfos_.Count; i++) { MessagePool.Instance.Recycle(playerInfos_[i]); }
      playerInfos_.Clear();
      testRepeatedString_.Clear();
      testRepeatedInt32_.Clear();
      testRepeatedInt64_.Clear();
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (playerInfo_ == null) {
              playerInfo_ = new global::ETHotfix.PlayerInfo();
            }
            input.ReadMessage(playerInfo_);
            break;
          }
          case 18: {
            playerInfos_.AddEntriesFrom(input, _repeated_playerInfos_codec);
            break;
          }
          case 26: {
            testRepeatedString_.AddEntriesFrom(input, _repeated_testRepeatedString_codec);
            break;
          }
          case 34:
          case 32: {
            testRepeatedInt32_.AddEntriesFrom(input, _repeated_testRepeatedInt32_codec);
            break;
          }
          case 42:
          case 40: {
            testRepeatedInt64_.AddEntriesFrom(input, _repeated_testRepeatedInt64_codec);
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
