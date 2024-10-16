using System.Buffers.Binary;
using System.Text;

namespace TeltonikaClient.Core.Utils {
  public class BufferWriter : IDisposable {
    private readonly MemoryStream _stream;
    private readonly bool _bigEndian = true;
    public long Length => _stream.Length;
    public BufferWriter(int capacity = 12, bool bigEndian = true) {
      _stream = new MemoryStream(capacity);
      _bigEndian = bigEndian;
    }
    public void Dispose() {
      _stream?.Dispose();
      GC.SuppressFinalize(this);
    }

    #region Base Write Methods
    public BufferWriter WriteUInt8(byte value) {
      _stream.WriteByte(value);
      return this;
    }
    public BufferWriter WriteUInt16(ushort value) {
      Span<byte> buffer = stackalloc byte[2];
      if(_bigEndian) {
        BinaryPrimitives.WriteUInt16BigEndian(buffer, value);
      } else {
        BinaryPrimitives.WriteUInt16LittleEndian(buffer, value);
      }
      _stream.Write(buffer);
      return this;
    }
    public BufferWriter WriteUInt32(uint value) {
      Span<byte> buffer = stackalloc byte[4];
      if(_bigEndian) {
        BinaryPrimitives.WriteUInt32BigEndian(buffer, value);
      } else {
        BinaryPrimitives.WriteUInt32LittleEndian(buffer, value);
      }
      _stream.Write(buffer);
      return this;
    }
    public BufferWriter WriteUInt64(ulong value) {
      Span<byte> buffer = stackalloc byte[8];
      if(_bigEndian) {
        BinaryPrimitives.WriteUInt64BigEndian(buffer, value);
      } else {
        BinaryPrimitives.WriteUInt64LittleEndian(buffer, value);
      }
      _stream.Write(buffer);
      return this;
    }

    public BufferWriter WriteInt8(sbyte value) {
      _stream.WriteByte((byte)value);
      return this;
    }
    public BufferWriter WriteInt16(short value) {
      Span<byte> buffer = stackalloc byte[2];
      if(_bigEndian) {
        BinaryPrimitives.WriteInt16BigEndian(buffer, value);
      } else {
        BinaryPrimitives.WriteInt16LittleEndian(buffer, value);
      }
      _stream.Write(buffer);
      return this;
    }
    public BufferWriter WriteInt32(int value) {
      Span<byte> buffer = stackalloc byte[4];
      if(_bigEndian) {
        BinaryPrimitives.WriteInt32BigEndian(buffer, value);
      } else {
        BinaryPrimitives.WriteInt32LittleEndian(buffer, value);
      }
      _stream.Write(buffer);
      return this;
    }
    public BufferWriter WriteInt64(long value) {
      Span<byte> buffer = stackalloc byte[8];
      if(_bigEndian) {
        BinaryPrimitives.WriteInt64BigEndian(buffer, value);
      } else {
        BinaryPrimitives.WriteInt64LittleEndian(buffer, value);
      }
      _stream.Write(buffer);
      return this;
    }

    public BufferWriter WriteFloat32(float value) {
      Span<byte> buffer = stackalloc byte[4];
      if(_bigEndian) {
        BinaryPrimitives.WriteSingleBigEndian(buffer, value);
      } else {
        BinaryPrimitives.WriteSingleLittleEndian(buffer, value);
      }
      _stream.Write(buffer);
      return this;
    }
    public BufferWriter WriteFloat64(double value) {
      Span<byte> buffer = stackalloc byte[8];
      if(_bigEndian) {
        BinaryPrimitives.WriteDoubleBigEndian(buffer, value);
      } else {
        BinaryPrimitives.WriteDoubleLittleEndian(buffer, value);
      }
      _stream.Write(buffer);
      return this;
    }

    public BufferWriter WriteBoolean(bool value) {
      if(value) return WriteUInt8(0x01);
      return WriteUInt8(0x00);
    }

    public BufferWriter WriteBytes(byte[] buffer) {
      _stream.Write(buffer, 0, buffer.Length);
      return this;
    }
    public BufferWriter WriteBytes(ReadOnlySpan<byte> buffer) {
      _stream.Write(buffer);
      return this;
    }

    public BufferWriter WriteString(string value, Encoding? encoding = null) {
      encoding ??= Encoding.ASCII;
      byte[] bytes = encoding.GetBytes(value);
      _stream.Write(bytes, 0, bytes.Length);
      return this;
    }
    #endregion

    #region Unified Write Methods
    public BufferWriter Write(byte value) => WriteUInt8(value);
    public BufferWriter Write(sbyte value) => WriteInt8(value);
    public BufferWriter Write(ushort value) => WriteUInt16(value);
    public BufferWriter Write(short value) => WriteInt16(value);
    public BufferWriter Write(uint value) => WriteUInt32(value);
    public BufferWriter Write(int value) => WriteInt32(value);
    public BufferWriter Write(ulong value) => WriteUInt64(value);
    public BufferWriter Write(long value) => WriteInt64(value);
    public BufferWriter Write(float value) => WriteFloat32(value);
    public BufferWriter Write(double value) => WriteFloat64(value);
    public BufferWriter Write(bool value) => WriteBoolean(value);
    public BufferWriter Write(byte[] buffer) => WriteBytes(buffer);
    public BufferWriter Write(ReadOnlySpan<byte> buffer) => WriteBytes(buffer);
    public BufferWriter Write(string value, Encoding? encoding = null) => WriteString(value, encoding);

    #endregion

    public byte[] ToArray() => _stream.ToArray();
    public override string ToString() => ToString("");
    public string ToString(string byteSpacer = "") {
      return BitConverter.ToString(_stream.ToArray()).Replace("-", byteSpacer);
    }
    public BufferWriter Clear() {
      _stream.SetLength(0);
      return this;
    }

  }
}