using System.Diagnostics;

namespace TeltonikaClient.UI {
  internal static class FormUtils {
    public static void SetEqualColumnWidths(ListView list, int minWidth = 100) {
      // Get the total width of the ListView
      int totalWidth = list.ClientSize.Width;

      // Subtract the width for vertical scrollbar if it appears
      if(list.Items.Count > list.ClientSize.Height / list.Font.Height) {
        totalWidth -= SystemInformation.VerticalScrollBarWidth;
      }

      // Set each column's width to the calculated equal width
      int equalWidth = totalWidth / list.Columns.Count;
      foreach(ColumnHeader column in list.Columns) {
        column.Width = Math.Max(equalWidth, minWidth);
      }
    }
    public static void AppendLine(RichTextBox rb, string text, Color fColor, Color bgColor) {
      AppendText(rb, text + "\n", fColor, bgColor);
    }
    public static void AppendText(RichTextBox rb, string text, Color fcolor, Color bgColor) {
      int start = rb.SelectionStart;
      int length = rb.SelectionLength;

      rb.SelectionStart = rb.TextLength;
      rb.SelectionLength = 0;

      rb.SelectionColor = fcolor;
      rb.SelectionBackColor = bgColor;
      rb.AppendText(text);

      rb.SelectionStart = start;
      rb.SelectionLength = length;

      rb.SelectionColor = rb.ForeColor;
      rb.SelectionBackColor = rb.BackColor;
    }

    public static int SetRandomInt(NumericUpDown component) {
      int max = (int)component.Maximum - (int)component.Minimum;
      int value = Random.Shared.Next(max + 1) + (int)component.Minimum;
      component.Value = value;
      return value;
    }

    public static decimal SetRandomDecimal(NumericUpDown component) {
      double min = (double)component.Minimum;
      double max = (double)component.Maximum;
      double range = max - min;
      var value = (decimal)(Random.Shared.NextDouble() * range + min);
      component.Value = value;
      return value;
    }

    public static bool SetRandomBool(CheckBox component) {
      component.Checked = Random.Shared.Next(2) == 1;
      return component.Checked;
    }

    public static void OpenBrowser(string url) {
      try {
        Process.Start(new ProcessStartInfo {
          FileName = url,
          UseShellExecute = true
        });
      } catch(Exception ex) {
        Console.WriteLine($"Error opening browser: {ex.Message}");
      }
    }
  }
}
