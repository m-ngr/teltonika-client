using System.Buffers.Binary;
using System.Numerics;
using System.Text;

namespace TeltonikaClient.Core.Utils {
  public class BufferReader : IDisposable {
    private readonly MemoryStream _stream;
    private readonly bool _bigEndian;
    public BufferReader(byte[] buffer, bool bigEndian = true) {
      _stream = new MemoryStream(buffer);
      _bigEndian = bigEndian;
    }
    public BufferReader(MemoryStream stream, bool bigEndian = true) {
      _stream = stream;
      _bigEndian = bigEndian;
    }
    public void Dispose() {
      _stream?.Dispose();
      GC.SuppressFinalize(this);
    }

    #region Base Read Methods
    public byte[] ReadBytes(int count) {
      EnsureAvailable(count);
      Span<byte> buffer = stackalloc byte[count];
      _stream.Read(buffer);
      return buffer.ToArray();
    }
    public byte ReadUInt8() {
      EnsureAvailable(1);
      return (byte)_stream.ReadByte();
    }
    public ushort ReadUInt16() {
      if(_bigEndian) {
        return BinaryPrimitives.ReadUInt16BigEndian(ReadBytes(2));
      } else {
        return BinaryPrimitives.ReadUInt16LittleEndian(ReadBytes(2));
      }
    }
    public uint ReadUInt32() {
      if(_bigEndian) {
        return BinaryPrimitives.ReadUInt32BigEndian(ReadBytes(4));
      } else {
        return BinaryPrimitives.ReadUInt32LittleEndian(ReadBytes(4));
      }
    }
    public ulong ReadUInt64() {
      if(_bigEndian) {
        return BinaryPrimitives.ReadUInt64BigEndian(ReadBytes(8));
      } else {
        return BinaryPrimitives.ReadUInt64LittleEndian(ReadBytes(8));
      }
    }
    public sbyte ReadInt8() {
      return (sbyte)ReadUInt8();
    }
    public short ReadInt16() {
      if(_bigEndian) {
        return BinaryPrimitives.ReadInt16BigEndian(ReadBytes(2));
      } else {
        return BinaryPrimitives.ReadInt16LittleEndian(ReadBytes(2));
      }
    }
    public int ReadInt32() {
      if(_bigEndian) {
        return BinaryPrimitives.ReadInt32BigEndian(ReadBytes(4));
      } else {
        return BinaryPrimitives.ReadInt32LittleEndian(ReadBytes(4));
      }
    }
    public long ReadInt64() {
      if(_bigEndian) {
        return BinaryPrimitives.ReadInt64BigEndian(ReadBytes(8));
      } else {
        return BinaryPrimitives.ReadInt64LittleEndian(ReadBytes(8));
      }
    }
    public float ReadFloat32() {
      if(_bigEndian) {
        return BinaryPrimitives.ReadSingleBigEndian(ReadBytes(4));
      } else {
        return BinaryPrimitives.ReadSingleLittleEndian(ReadBytes(4));
      }
    }
    public double ReadFloat64() {
      if(_bigEndian) {
        return BinaryPrimitives.ReadDoubleBigEndian(ReadBytes(8));
      } else {
        return BinaryPrimitives.ReadDoubleLittleEndian(ReadBytes(8));
      }
    }
    public bool ReadBoolean() {
      return ReadUInt8() != 0;
    }
    public string ReadString(int length, Encoding? encoding = null) {
      encoding ??= Encoding.ASCII;
      return encoding.GetString(ReadBytes(length));
    }
    #endregion
    public BigInteger ReadInt(int size, bool signed) {
      return size switch {
        1 => signed ? (BigInteger)ReadInt8() : (BigInteger)ReadUInt8(),
        2 => signed ? (BigInteger)ReadInt16() : (BigInteger)ReadUInt16(),
        4 => signed ? (BigInteger)ReadInt32() : (BigInteger)ReadUInt32(),
        8 => signed ? (BigInteger)ReadInt64() : (BigInteger)ReadUInt64(),
        _ => throw new ArgumentException("Unsupported size."),
      };
    }

    public long Length => _stream.Length;
    public long Available => Length - _stream.Position;
    public bool IsEmpty => Available == 0;
    public bool CanRead(int count = 1) => Available >= count;
    public void Seek(long position, SeekOrigin loc = SeekOrigin.Begin) {
      _stream.Seek(position, loc);
    }
    public void Skip(long count) {
      Seek(count, SeekOrigin.Current);
    }

    private void EnsureAvailable(int count) {
      if(!CanRead(count))
        throw new InvalidOperationException(
          $"BufferReader: Insufficient data available. Required: {count} bytes, but only {Available} bytes remain."
        );

    }
  }

}
