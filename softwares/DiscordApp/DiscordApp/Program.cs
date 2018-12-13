using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordApp {
  static class Program {
    public static readonly string Directory = Environment.GetEnvironmentVariable("LocalAppData") + "/Discord+/";

    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      new Window.WindowManager();
    }
  }
}
