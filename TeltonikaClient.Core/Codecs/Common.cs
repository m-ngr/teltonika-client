namespace TeltonikaClient.Core.Codecs {
  public enum CodecId : byte {
    CODEC8 = 0x08,
    CODEC8_EXTENDED = 0x8e,
    CODEC16 = 0x10,
    CODEC12 = 0x0c,
    CODEC13 = 0x0d,
    CODEC14 = 0x0e,
    CODEC15 = 0x0f,
  }

  public enum CodecTextType : byte {
    Command = 0x05,
    Response = 0x06
  }
}
