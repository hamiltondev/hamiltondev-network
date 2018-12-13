using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DiscordApp.Window {
  class WindowManager {
    public WindowManager() => this.InitializeTask().GetAwaiter().GetResult();

    private Form Form;

    private async Task InitializeTask() {
      this.Form = new Form() {
        FormBorderStyle = FormBorderStyle.None,

        BackColor = ColorTranslator.FromHtml("#25272B"),
        Icon = new Icon(Program.Directory + "DiscordApp.ico"),

        Text = "Discord",

        Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - (Screen.PrimaryScreen.WorkingArea.Width / 3), Screen.PrimaryScreen.WorkingArea.Height - (Screen.PrimaryScreen.WorkingArea.Height / 4))
      };

      await Toolbar.ToolbarManager.Create(this.Form);

      await Processor.ProcessorManager.Create(this.Form);

      Application.Run(this.Form);

      await Task.Delay(-1);
    }
  }
}
