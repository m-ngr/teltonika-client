using TeltonikaClient.Core.Utils;

namespace TeltonikaClient.Core.Codecs {

  public static class Codec12 {
    public static bool CanDecode(byte[] buffer) {
      if(buffer.Length < 8) return false;
      if((CodecId)buffer[0] != CodecId.CODEC12) return false;
      return true;
    }

    public static (string output, CodecTextType type) Decode(byte[] buffer) {
      if(!CanDecode(buffer)) {
        throw new ArgumentException("Codec12: Invalid codec ID or insufficient buffer length.");
      }
      var reader = new BufferReader(buffer);
      reader.Skip(2); // Skip CodecId (1 byte) and Quantity (1 byte)

      CodecTextType outputType = (CodecTextType)reader.ReadUInt8();
      string output = reader.ReadString((int)reader.ReadUInt32());

      return (output, outputType);
    }

    public static byte[] Encode(string input, CodecTextType type) {
      var writer = new BufferWriter(input.Length + 8);

      writer.WriteUInt8((byte)CodecId.CODEC12);
      writer.WriteUInt8(0x01);  // Quantity 1
      writer.WriteUInt8((byte)type);
      writer.WriteUInt32((uint)input.Length);
      writer.WriteString(input);
      writer.WriteUInt8(0x01);  // Quantity 2

      return writer.ToArray();
    }
  }
}
