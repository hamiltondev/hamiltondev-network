using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace DiscordApp.Window.Processor {
  class ProcessorManager {
    public static async Task Create(Form form) {
      ChromiumWebBrowser browser = new ChromiumWebBrowser("") {

      };

      await Task.Delay(0);
    }
  }
}
