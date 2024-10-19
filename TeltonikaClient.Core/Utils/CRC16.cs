namespace TeltonikaClient.Core.Utils {
  public static class CRC16 {
    private static readonly ushort[] Table;

    static CRC16() {
      Table = new ushort[256];
      for(int i = 0; i < 256; i++) {
        ushort value = (ushort)i;
        for(int j = 0; j < 8; j++) {
          if((value & 1) != 0) {
            value = (ushort)((value >> 1) ^ 0xA001);
          } else {
            value >>= 1;
          }
        }
        Table[i] = value;
      }
    }

    public static ushort Calculate(byte[] buffer) {
      ushort crc = 0;

      foreach(byte b in buffer) {
        crc = (ushort)((crc >> 8) ^ Table[(crc ^ b) & 0xFF]);
      }

      return crc;
    }
  }

}
