using TeltonikaClient.Core.Utils;

namespace TeltonikaClient.Core.Entities {
  internal static class IoContext {
    public struct IoContextObject {
      public bool Signed { get; set; }
      public double Multiplier { get; set; }
    }
    private static readonly IoContextObject DefaultContext = new() { Signed = false, Multiplier = 1 };
    private static readonly Dictionary<int, IoContextObject> Context = new()
{
        // Permanent I/O elements
        { 181, new IoContextObject { Signed = false, Multiplier = 0.1 } }, // GNSS PDOP
        { 182, new IoContextObject { Signed = false, Multiplier = 0.1 } }, // GNSS HDOP
        { 66, new IoContextObject { Signed = false, Multiplier = 0.001 } }, // External Voltage
        { 67, new IoContextObject { Signed = false, Multiplier = 0.001 } }, // Battery Voltage
        { 68, new IoContextObject { Signed = false, Multiplier = 0.001 } }, // Battery Current
        { 9, new IoContextObject { Signed = false, Multiplier = 0.001 } }, // Analog Input 1
        { 6, new IoContextObject { Signed = false, Multiplier = 0.001 } }, // Analog Input 2
        { 12, new IoContextObject { Signed = false, Multiplier = 0.001 } }, // Fuel Used GPS
        { 13, new IoContextObject { Signed = false, Multiplier = 0.01 } },  // Fuel Rate GPS
        { 17, new IoContextObject { Signed = true, Multiplier = 1 } },      // Axis X
        { 18, new IoContextObject { Signed = true, Multiplier = 1 } },      // Axis Y
        { 19, new IoContextObject { Signed = true, Multiplier = 1 } },      // Axis Z
        { 72, new IoContextObject { Signed = true, Multiplier = 0.1 } },    // Dallas Temperature 1
        { 73, new IoContextObject { Signed = true, Multiplier = 0.1 } },    // Dallas Temperature 2
        { 74, new IoContextObject { Signed = true, Multiplier = 0.1 } },    // Dallas Temperature 3
        { 75, new IoContextObject { Signed = true, Multiplier = 0.1 } },    // Dallas Temperature 4
        { 10800, new IoContextObject { Signed = true, Multiplier = 0.01 } }, // EYE Temperature 1
        { 10801, new IoContextObject { Signed = true, Multiplier = 0.01 } }, // EYE Temperature 2
        { 10802, new IoContextObject { Signed = true, Multiplier = 0.01 } }, // EYE Temperature 3
        { 10803, new IoContextObject { Signed = true, Multiplier = 0.01 } }, // EYE Temperature 4
        { 10816, new IoContextObject { Signed = true, Multiplier = 1 } },    // EYE Pitch 1
        { 10817, new IoContextObject { Signed = true, Multiplier = 1 } },    // EYE Pitch 2
        { 10818, new IoContextObject { Signed = true, Multiplier = 1 } },    // EYE Pitch 3
        { 10819, new IoContextObject { Signed = true, Multiplier = 1 } },    // EYE Pitch 4
        { 10832, new IoContextObject { Signed = true, Multiplier = 1 } },    // EYE Roll 1
        { 10833, new IoContextObject { Signed = true, Multiplier = 1 } },    // EYE Roll 2
        { 10834, new IoContextObject { Signed = true, Multiplier = 1 } },    // EYE Roll 3
        { 10835, new IoContextObject { Signed = true, Multiplier = 1 } },    // EYE Roll 4
        { 622, new IoContextObject { Signed = false, Multiplier = 0.1 } },   // Frequency DIN1
        { 623, new IoContextObject { Signed = false, Multiplier = 0.1 } },   // Frequency DIN2
        // OBD elements
        { 32, new IoContextObject { Signed = true, Multiplier = 1 } },       // Coolant Temperature
        { 33, new IoContextObject { Signed = true, Multiplier = 1 } },       // Short Fuel Trim
        { 38, new IoContextObject { Signed = true, Multiplier = 1 } },       // Timing Advance
        { 39, new IoContextObject { Signed = true, Multiplier = 1 } },       // Intake Air Temperature
        { 40, new IoContextObject { Signed = false, Multiplier = 0.01 } },   // MAF
        { 44, new IoContextObject { Signed = false, Multiplier = 0.1 } },    // Relative Fuel Rail Pressure
        { 45, new IoContextObject { Signed = false, Multiplier = 10 } },     // Direct Fuel Rail Pressure
        { 47, new IoContextObject { Signed = true, Multiplier = 1 } },       // EGR Error
        { 51, new IoContextObject { Signed = false, Multiplier = 0.001 } },  // Control Module Voltage
        { 53, new IoContextObject { Signed = true, Multiplier = 1 } },       // Ambient Air Temperature
        { 56, new IoContextObject { Signed = false, Multiplier = 0.1 } },    // Absolute Fuel Rail Pressure
        { 59, new IoContextObject { Signed = true, Multiplier = 0.01 } },    // Fuel injection timing
        { 541, new IoContextObject { Signed = false, Multiplier = 0.01 } },  // Commanded Equivalence R
        { 544, new IoContextObject { Signed = true, Multiplier = 1 } },      // Hybrid System Current
        { 60, new IoContextObject { Signed = false, Multiplier = 0.01 } },   // Fuel Rate
        // OBD OEM elements
        { 390, new IoContextObject { Signed = false, Multiplier = 0.1 } },   // OBD OEM Fuel Level
        { 1152, new IoContextObject { Signed = true, Multiplier = 1 } },     // OEM Battery Temperature
        // BLE Sensors I/O elements
        { 25, new IoContextObject { Signed = true, Multiplier = 0.01 } },    // BLE Temperature #1
        { 26, new IoContextObject { Signed = true, Multiplier = 0.01 } },    // BLE Temperature #2
        { 27, new IoContextObject { Signed = true, Multiplier = 0.01 } },    // BLE Temperature #3
        { 28, new IoContextObject { Signed = true, Multiplier = 0.01 } },    // BLE Temperature #4
        { 86, new IoContextObject { Signed = false, Multiplier = 0.1 } },     // BLE Humidity #1
        { 104, new IoContextObject { Signed = false, Multiplier = 0.1 } },    // BLE Humidity #2
        { 106, new IoContextObject { Signed = false, Multiplier = 0.1 } },    // BLE Humidity #3
        { 108, new IoContextObject { Signed = false, Multiplier = 0.1 } },    // BLE Humidity #4
        // CAN adapters elements
        { 83, new IoContextObject { Signed = false, Multiplier = 0.1 } },     // Fuel Consumed
        { 84, new IoContextObject { Signed = false, Multiplier = 0.1 } },     // Fuel Level
        { 107, new IoContextObject { Signed = false, Multiplier = 0.1 } },    // Fuel Consumed (counted)
        { 110, new IoContextObject { Signed = false, Multiplier = 0.1 } },    // Fuel Rate
        { 112, new IoContextObject { Signed = false, Multiplier = 0.1 } },    // AdBlue Level
        { 115, new IoContextObject { Signed = true, Multiplier = 0.1 } },     // Engine Temperature
        { 151, new IoContextObject { Signed = true, Multiplier = 0.1 } },     // Battery Temperature
        { 161, new IoContextObject { Signed = true, Multiplier = 1 } },       // Slope of Arm
        { 162, new IoContextObject { Signed = true, Multiplier = 1 } },       // Rotation of Arm
        { 450, new IoContextObject { Signed = false, Multiplier = 10 } },     // CNG Level Kg
    };
    public static bool Signed(int id) => GetContext(id).Signed;
    public static double Multiplier(int id) => GetContext(id).Multiplier;
    public static IoContextObject GetContext(int id) {
      if(Context.TryGetValue(id, out var contextObject)) {
        return contextObject;
      } else {
        return DefaultContext;
      }
    }
    public static double Transform(int id, byte[] value) {
      var reader = new BufferReader(value);
      var x = (double)reader.ReadInt(value.Length, Signed(id));
      return x * Multiplier(id);
    }
    public static byte[] InverseTransform(int id, double value, int size) {
      var val = value / Multiplier(id);
      var writer = new BufferWriter();
      if(Signed(id)) {
        if(size == 1) return writer.Write((sbyte)val).ToArray();
        else if(size == 2) return writer.Write((short)val).ToArray();
        else if(size == 4) return writer.Write((int)val).ToArray();
        else return writer.Write((long)val).ToArray();
      } else {
        if(size == 1) return writer.Write((byte)val).ToArray();
        else if(size == 2) return writer.Write((ushort)val).ToArray();
        else if(size == 4) return writer.Write((uint)val).ToArray();
        else return writer.Write((ulong)val).ToArray();
      }
    }
  }
}
