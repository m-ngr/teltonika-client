using System.Text.Json;

namespace TeltonikaClient.UI {
  public class CommandResponse(string command, string response) {
    public string Command { get; set; } = command;
    public string Response { get; set; } = response;
  }

  internal class ResponseSource {
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };
    private readonly string _filePath;
    public BindingSource BindingSource { get; private set; }

    public ResponseSource(string filePath) {
      _filePath = filePath;
      BindingSource = new BindingSource {
        DataSource = new List<CommandResponse>()
      };
    }

    public void Save() {
      var list = BindingSource.List as List<CommandResponse>;
      if(list != null) {
        string json = JsonSerializer.Serialize(list, JsonOptions);
        File.WriteAllText(_filePath, json);
      }
    }

    public void Load() {
      if(File.Exists(_filePath)) {
        string json = File.ReadAllText(_filePath);
        var list = JsonSerializer.Deserialize<List<CommandResponse>>(json);
        BindingSource.DataSource = list;
      }
    }

    public string Get(string command) {
      foreach(CommandResponse item in BindingSource) {
        if(item.Command == command) return item.Response;
      }
      return $"{command}:Response";
    }

    public void Set(string command, string response) {
      BindingSource.Add(new CommandResponse(command, response));
    }
  }
}
