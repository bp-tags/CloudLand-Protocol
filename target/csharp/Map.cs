// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Map.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Org.Dragonet.Cloudland.Net.Protocol {

  /// <summary>Holder for reflection information generated from Map.proto</summary>
  public static partial class MapReflection {

    #region Descriptor
    /// <summary>File descriptor for Map.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CglNYXAucHJvdG8SI29yZy5kcmFnb25ldC5jbG91ZGxhbmQubmV0LnByb3Rv",
            "Y29sIlcKElNlcnZlckNodW5rTWVzc2FnZRIJCgF4GAEgASgREgkKAXoYAiAB",
            "KBESCQoBeRgDIAEoERINCgVjaHVuaxgEIAEoDBIRCgljaHVua0RhdGEYBSAB",
            "KAwiVQoYU2VydmVyVXBkYXRlQmxvY2tNZXNzYWdlEgkKAXgYASABKBESCQoB",
            "eRgCIAEoERIJCgF6GAMgASgREgoKAmlkGAQgASgNEgwKBGRhdGEYBSABKAwi",
            "OwoYQ2xpZW50UmVtb3ZlQmxvY2tNZXNzYWdlEgkKAXgYASABKBESCQoBeRgC",
            "IAEoERIJCgF6GAMgASgRIm8KHVNlcnZlclVwZGF0ZUJsb2NrQmF0Y2hNZXNz",
            "YWdlEk4KB3JlY29yZHMYASADKAsyPS5vcmcuZHJhZ29uZXQuY2xvdWRsYW5k",
            "Lm5ldC5wcm90b2NvbC5TZXJ2ZXJVcGRhdGVCbG9ja01lc3NhZ2ViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerChunkMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerChunkMessage.Parser, new[]{ "X", "Z", "Y", "Chunk", "ChunkData" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateBlockMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateBlockMessage.Parser, new[]{ "X", "Y", "Z", "Id", "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ClientRemoveBlockMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ClientRemoveBlockMessage.Parser, new[]{ "X", "Y", "Z" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateBlockBatchMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateBlockBatchMessage.Parser, new[]{ "Records" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ServerChunkMessage : pb::IMessage<ServerChunkMessage> {
    private static readonly pb::MessageParser<ServerChunkMessage> _parser = new pb::MessageParser<ServerChunkMessage>(() => new ServerChunkMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerChunkMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.MapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerChunkMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerChunkMessage(ServerChunkMessage other) : this() {
      x_ = other.x_;
      z_ = other.z_;
      y_ = other.y_;
      chunk_ = other.chunk_;
      chunkData_ = other.chunkData_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerChunkMessage Clone() {
      return new ServerChunkMessage(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private int x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 2;
    private int z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 3;
    private int y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "chunk" field.</summary>
    public const int ChunkFieldNumber = 4;
    private pb::ByteString chunk_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Chunk {
      get { return chunk_; }
      set {
        chunk_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "chunkData" field.</summary>
    public const int ChunkDataFieldNumber = 5;
    private pb::ByteString chunkData_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ChunkData {
      get { return chunkData_; }
      set {
        chunkData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerChunkMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerChunkMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Z != other.Z) return false;
      if (Y != other.Y) return false;
      if (Chunk != other.Chunk) return false;
      if (ChunkData != other.ChunkData) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0) hash ^= X.GetHashCode();
      if (Z != 0) hash ^= Z.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      if (Chunk.Length != 0) hash ^= Chunk.GetHashCode();
      if (ChunkData.Length != 0) hash ^= ChunkData.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(X);
      }
      if (Z != 0) {
        output.WriteRawTag(16);
        output.WriteSInt32(Z);
      }
      if (Y != 0) {
        output.WriteRawTag(24);
        output.WriteSInt32(Y);
      }
      if (Chunk.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Chunk);
      }
      if (ChunkData.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(ChunkData);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(X);
      }
      if (Z != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Z);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Y);
      }
      if (Chunk.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Chunk);
      }
      if (ChunkData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ChunkData);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerChunkMessage other) {
      if (other == null) {
        return;
      }
      if (other.X != 0) {
        X = other.X;
      }
      if (other.Z != 0) {
        Z = other.Z;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
      if (other.Chunk.Length != 0) {
        Chunk = other.Chunk;
      }
      if (other.ChunkData.Length != 0) {
        ChunkData = other.ChunkData;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            X = input.ReadSInt32();
            break;
          }
          case 16: {
            Z = input.ReadSInt32();
            break;
          }
          case 24: {
            Y = input.ReadSInt32();
            break;
          }
          case 34: {
            Chunk = input.ReadBytes();
            break;
          }
          case 42: {
            ChunkData = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServerUpdateBlockMessage : pb::IMessage<ServerUpdateBlockMessage> {
    private static readonly pb::MessageParser<ServerUpdateBlockMessage> _parser = new pb::MessageParser<ServerUpdateBlockMessage>(() => new ServerUpdateBlockMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerUpdateBlockMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.MapReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerUpdateBlockMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerUpdateBlockMessage(ServerUpdateBlockMessage other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      id_ = other.id_;
      data_ = other.data_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerUpdateBlockMessage Clone() {
      return new ServerUpdateBlockMessage(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private int x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private int y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private int z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 4;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 5;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerUpdateBlockMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerUpdateBlockMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      if (Id != other.Id) return false;
      if (Data != other.Data) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0) hash ^= X.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      if (Z != 0) hash ^= Z.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(X);
      }
      if (Y != 0) {
        output.WriteRawTag(16);
        output.WriteSInt32(Y);
      }
      if (Z != 0) {
        output.WriteRawTag(24);
        output.WriteSInt32(Z);
      }
      if (Id != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Id);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Data);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(X);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Y);
      }
      if (Z != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Z);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerUpdateBlockMessage other) {
      if (other == null) {
        return;
      }
      if (other.X != 0) {
        X = other.X;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
      if (other.Z != 0) {
        Z = other.Z;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            X = input.ReadSInt32();
            break;
          }
          case 16: {
            Y = input.ReadSInt32();
            break;
          }
          case 24: {
            Z = input.ReadSInt32();
            break;
          }
          case 32: {
            Id = input.ReadUInt32();
            break;
          }
          case 42: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ClientRemoveBlockMessage : pb::IMessage<ClientRemoveBlockMessage> {
    private static readonly pb::MessageParser<ClientRemoveBlockMessage> _parser = new pb::MessageParser<ClientRemoveBlockMessage>(() => new ClientRemoveBlockMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientRemoveBlockMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.MapReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientRemoveBlockMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientRemoveBlockMessage(ClientRemoveBlockMessage other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientRemoveBlockMessage Clone() {
      return new ClientRemoveBlockMessage(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private int x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private int y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private int z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientRemoveBlockMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientRemoveBlockMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0) hash ^= X.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      if (Z != 0) hash ^= Z.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(X);
      }
      if (Y != 0) {
        output.WriteRawTag(16);
        output.WriteSInt32(Y);
      }
      if (Z != 0) {
        output.WriteRawTag(24);
        output.WriteSInt32(Z);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(X);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Y);
      }
      if (Z != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Z);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientRemoveBlockMessage other) {
      if (other == null) {
        return;
      }
      if (other.X != 0) {
        X = other.X;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
      if (other.Z != 0) {
        Z = other.Z;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            X = input.ReadSInt32();
            break;
          }
          case 16: {
            Y = input.ReadSInt32();
            break;
          }
          case 24: {
            Z = input.ReadSInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServerUpdateBlockBatchMessage : pb::IMessage<ServerUpdateBlockBatchMessage> {
    private static readonly pb::MessageParser<ServerUpdateBlockBatchMessage> _parser = new pb::MessageParser<ServerUpdateBlockBatchMessage>(() => new ServerUpdateBlockBatchMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerUpdateBlockBatchMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.MapReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerUpdateBlockBatchMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerUpdateBlockBatchMessage(ServerUpdateBlockBatchMessage other) : this() {
      records_ = other.records_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerUpdateBlockBatchMessage Clone() {
      return new ServerUpdateBlockBatchMessage(this);
    }

    /// <summary>Field number for the "records" field.</summary>
    public const int RecordsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateBlockMessage> _repeated_records_codec
        = pb::FieldCodec.ForMessage(10, global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateBlockMessage.Parser);
    private readonly pbc::RepeatedField<global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateBlockMessage> records_ = new pbc::RepeatedField<global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateBlockMessage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateBlockMessage> Records {
      get { return records_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerUpdateBlockBatchMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerUpdateBlockBatchMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!records_.Equals(other.records_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= records_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      records_.WriteTo(output, _repeated_records_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += records_.CalculateSize(_repeated_records_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerUpdateBlockBatchMessage other) {
      if (other == null) {
        return;
      }
      records_.Add(other.records_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            records_.AddEntriesFrom(input, _repeated_records_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
