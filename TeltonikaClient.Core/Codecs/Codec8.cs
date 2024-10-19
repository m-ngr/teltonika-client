using TeltonikaClient.Core.Entities;
using TeltonikaClient.Core.Utils;

namespace TeltonikaClient.Core.Codecs {
  public static class Codec8 {
    public static bool CanDecode(byte[] buffer) {
      if(buffer.Length < 45) return false;
      if((CodecId)buffer[0] != CodecId.CODEC8) return false;
      return true;
    }
    public static List<TeltonikaRecord> Decode(byte[] buffer) {
      if(!CanDecode(buffer)) {
        throw new ArgumentException("Codec8: Invalid codec ID or insufficient buffer length.");
      }
      var reader = new BufferReader(buffer[2..^1]);
      var records = new List<TeltonikaRecord>();

      while(!reader.IsEmpty) {
        records.Add(TeltonikaRecord.From(reader));
      }
      return records;
    }
    public static byte[] Encode(List<TeltonikaRecord> records) {
      var writer = new BufferWriter(45);
      writer.WriteUInt8((byte)CodecId.CODEC8);
      writer.WriteUInt8((byte)records.Count);
      foreach(var record in records) {
        writer.Write(record.ToArray());
      }
      writer.WriteUInt8((byte)records.Count);
      return writer.ToArray();
    }

  }
}
