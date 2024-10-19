using TeltonikaClient.Core.Utils;

namespace TeltonikaClient.Core.Entities {
  public class TeltonikaRecord {
    private static readonly double _gpsPrecision = 10_000_000;

    private int _longitude;
    public double Longitude {
      get => _longitude / _gpsPrecision;
      set => _longitude = (int)(value * _gpsPrecision);
    }

    private int _latitude;
    public double Latitude {
      get => _latitude / _gpsPrecision;
      set => _latitude = (int)(value * _gpsPrecision);
    }

    private long _timestamp;

    public DateTime Timestamp {
      get => DateTimeOffset.FromUnixTimeMilliseconds(_timestamp).LocalDateTime;
      set => _timestamp = new DateTimeOffset(value).ToUnixTimeMilliseconds();
    }
    public byte Priority { init; get; }
    public ushort Altitude { init; get; }
    public ushort Angle { init; get; }
    public byte Satellites { init; get; }
    public ushort Speed { init; get; }
    public byte EventId { init; get; }

    public IoElements IoElements = new();

    public bool Ignition {
      get => IoElements.GetBoolean(239);
      set => IoElements.Set(239, value);
    }
    public bool Movement {
      get => IoElements.GetBoolean(240, Speed);
      set => IoElements.Set(240, value);
    }
    public bool Tow {
      get => IoElements.GetBoolean(246, (!Ignition && Movement));
      set => IoElements.Set(246, value);
    }
    public bool Idle {
      get => IoElements.GetBoolean(251, (Ignition && !Movement));
      set => IoElements.Set(251, value);
    }
    public uint Odometer {
      get => (uint)(IoElements.Get(16) ?? 0);
      set => IoElements.Set(16, value);
    }
    public double ExternalVoltage {
      get => IoElements.Get(66) ?? 0.0;
      set => IoElements.Set(66, value, 2);
    }
    public byte Battary {
      get => (byte)(IoElements.Get(113) ?? 0);
      set => IoElements.Set(113, value);
    }
    public static TeltonikaRecord From(BufferReader reader) {
      var timestamp = reader.ReadInt64();
      var priority = reader.ReadUInt8();
      var longitude = reader.ReadInt32();
      var latitude = reader.ReadInt32();
      var altitude = reader.ReadUInt16();
      var angle = reader.ReadUInt16();
      var satellites = reader.ReadUInt8();
      var speed = reader.ReadUInt16();

      var eventId = reader.ReadUInt8();
      reader.Skip(1);

      var ioElements = IoElements.From(reader);

      return new TeltonikaRecord {
        _timestamp = timestamp,
        Priority = priority,
        _longitude = longitude,
        _latitude = latitude,
        Altitude = altitude,
        Angle = angle,
        Satellites = satellites,
        Speed = speed,
        EventId = eventId,
        IoElements = ioElements
      };
    }
    public byte[] ToArray() {
      var writer = new BufferWriter(45);

      writer.Write(_timestamp);
      writer.Write(Priority);
      writer.Write(_longitude);
      writer.Write(_latitude);
      writer.Write(Altitude);
      writer.Write(Angle);
      writer.Write(Satellites);
      writer.Write(Speed);
      writer.Write(EventId);
      writer.Write(IoElements.ToArray());
      return writer.ToArray();
    }
  }
}

