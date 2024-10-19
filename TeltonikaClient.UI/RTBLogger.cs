namespace TeltonikaClient.UI {
  internal class RTBLogger {
    public Color InfoColor = Color.RoyalBlue;
    public Color WarnColor = Color.Orange;
    public Color ErrorColor = Color.OrangeRed;
    public Color SuccessColor = Color.LimeGreen;
    public Color ForeColor = Color.White;
    public Color BackColor = Color.Black;

    private readonly RichTextBox _rtb;

    public RTBLogger(RichTextBox rtb) {
      _rtb = rtb;
      _rtb.ForeColor = ForeColor;
      _rtb.BackColor = BackColor;
    }

    public static string CurrentTime => DateTime.Now.ToString("hh:mm:ss");

    public RTBLogger Info(string text, bool withTime = true) {
      if(withTime) LogTime(InfoColor);
      FormUtils.AppendLine(_rtb, text, InfoColor, BackColor);
      return this;
    }

    public RTBLogger Warn(string text, bool withTime = true) {
      if(withTime) LogTime(WarnColor);
      FormUtils.AppendLine(_rtb, text, WarnColor, BackColor);
      return this;
    }

    public RTBLogger Error(string text, bool withTime = true) {
      if(withTime) LogTime(ErrorColor);
      FormUtils.AppendLine(_rtb, text, ErrorColor, BackColor);
      return this;
    }

    public RTBLogger Success(string text, bool withTime = true) {
      if(withTime) LogTime(SuccessColor);
      FormUtils.AppendLine(_rtb, text, SuccessColor, BackColor);
      return this;
    }

    public RTBLogger Log(string text, bool withTime = true) {
      if(withTime) LogTime(ForeColor);
      FormUtils.AppendLine(_rtb, text, ForeColor, BackColor);
      return this;
    }

    private RTBLogger LogTime(Color color) {
      FormUtils.AppendText(_rtb, $"{CurrentTime} ", BackColor, color);
      FormUtils.AppendText(_rtb, " ", color, BackColor);
      return this;
    }
  }
}
