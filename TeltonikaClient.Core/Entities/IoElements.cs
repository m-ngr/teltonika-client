using TeltonikaClient.Core.Utils;

namespace TeltonikaClient.Core.Entities {
  public class IoElements {
    public static IoElements From(BufferReader reader) {
      Dictionary<int, byte[]> elements = [];
      int[] byteSizes = [1, 2, 4, 8];

      foreach(var size in byteSizes) {
        var count = reader.ReadUInt8();

        for(var i = 0; i < count; ++i) {
          var id = reader.ReadUInt8();
          elements.Add(id, reader.ReadBytes(size));
        }
      }

      return new IoElements() { _elements = elements };
    }

    private Dictionary<int, byte[]> _elements = [];

    public double? Get(int id, double? defaultValue = null) {
      if(_elements.TryGetValue(id, out var value)) {
        return IoContext.Transform(id, value);
      } else {
        return defaultValue;
      }
    }
    public bool GetBoolean(int id, dynamic? defaultValue = null) {
      return Convert.ToBoolean(Get(id) ?? defaultValue);
    }

    public void Set(int id, byte[] value) => _elements.Add(id, value);
    public void Set(int id, bool value) => Set(id, [Convert.ToByte(value)]);
    public void Set(int id, byte value) => Set(id, [value]);
    public void Set(int id, ushort value) => Set(id, new BufferWriter().Write(value).ToArray());
    public void Set(int id, uint value) => Set(id, new BufferWriter().Write(value).ToArray());
    public void Set(int id, ulong value) => Set(id, new BufferWriter().Write(value).ToArray());
    public void Set(int id, sbyte value) => Set(id, (byte)value);
    public void Set(int id, short value) => Set(id, (ushort)value);
    public void Set(int id, int value) => Set(id, (uint)value);
    public void Set(int id, long value) => Set(id, (ulong)value);
    public void Set(int id, double value, int size) {
      var buffer = IoContext.InverseTransform(id, value, size);
      Set(id, buffer);
    }

    public bool Has(int id) => _elements.ContainsKey(id);
    public void Clear() => _elements.Clear();
    public bool Remove(int id) => _elements.Remove(id);

    public byte[] ToArray() {
      var writer = new BufferWriter(45);
      writer.Write((byte)_elements.Count);
      WriteIO(writer, 1);
      WriteIO(writer, 2);
      WriteIO(writer, 4);
      WriteIO(writer, 8);
      return writer.ToArray();
    }
    private void WriteIO(BufferWriter writer, int size) {
      var items = _elements.Where(kv => kv.Value.Length == size).ToList();
      writer.Write((byte)items.Count);
      foreach(var item in items) {
        writer.Write((byte)item.Key);
        writer.Write(item.Value);
      }
    }
  }
}
