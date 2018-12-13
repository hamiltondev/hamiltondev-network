using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DiscordApp.Window.Toolbar {
  class ToolbarManager {
    private static Point cursorStarPosition;

    public static async Task Create(Form form) {
      Panel panel = new Panel() {
        Dock = DockStyle.Left,
        BackColor = ColorTranslator.FromHtml("#202225"),
        Size = new Size(3, 0)
      };

      form.Controls.Add(panel);

      panel = new Panel() {
        Dock = DockStyle.Right,
        BackColor = ColorTranslator.FromHtml("#202225"),
        Size = new Size(4, 0),
        Cursor = Cursors.SizeWE
      };

      panel.MouseDown += ((object sender, MouseEventArgs e) => {
        cursorStarPosition = new Point(e.X, e.Y);
      });

      panel.MouseMove += ((object sender, MouseEventArgs e) => {
        if (e.Button == MouseButtons.Left) {
          Point cursorLocation = new Point(e.X, e.Y);

          cursorLocation.Offset(cursorStarPosition.X, cursorStarPosition.Y);

          if ((form.Width + cursorLocation.X) > 600)
            form.Width = (form.Width + cursorLocation.X);
        }
      });

      form.Controls.Add(panel);

      panel = new Panel() {
        Dock = DockStyle.Top,
        BackColor = ColorTranslator.FromHtml("#202225"),
        Size = new Size(0, 25)
      };

      panel.MouseDown += ((object sender, MouseEventArgs e) => {
        cursorStarPosition = new Point(-e.X, -e.Y);
      });

      panel.MouseMove += ((object sender, MouseEventArgs e) => {
        if (e.Button == MouseButtons.Left) {
          Point offsetPosition = Control.MousePosition;

          offsetPosition.Offset(cursorStarPosition.X, cursorStarPosition.Y);

          form.Location = offsetPosition;
        }
      });

      PictureBox logo = new PictureBox() {
        Image = Properties.Resources.ToolbarLogo,
        Location = new Point(10, 1),
        Size = new Size(74, 25),
        SizeMode = PictureBoxSizeMode.Zoom
      };

      panel.Controls.Add(logo);

      Panel buttonsPanel = new Panel() {
        Dock = DockStyle.Right,
        Size = new Size(96, 25)
      };

      panel.Controls.Add(buttonsPanel);

      PictureBox buttonMinimize = new PictureBox() {
        Image = Properties.Resources.ToolbarMinimize,
        Location = new Point(0, 0),
        Size = new Size(30, 25),
        Cursor = Cursors.Hand
      };

      buttonMinimize.MouseEnter += ((object sender, EventArgs e) => {
        buttonMinimize.Image = Properties.Resources.ToolbarMinimizeActive;
      });

      buttonMinimize.MouseLeave += ((object sender, EventArgs e) => {
        buttonMinimize.Image = Properties.Resources.ToolbarMinimize;
      });

      buttonMinimize.MouseClick += ((object sender, MouseEventArgs e) => {
        form.WindowState = FormWindowState.Minimized;
      });

      buttonsPanel.Controls.Add(buttonMinimize);

      PictureBox buttonMaximize = new PictureBox() {
        Image = Properties.Resources.ToolbarMaximize,
        Location = new Point(30, 0),
        Size = new Size(31, 25),
        Cursor = Cursors.Hand
      };

      buttonMaximize.MouseEnter += ((object sender, EventArgs e) => {
        buttonMaximize.Image = Properties.Resources.ToolbarMaximizeActive;
      });

      buttonMaximize.MouseLeave += ((object sender, EventArgs e) => {
        buttonMaximize.Image = Properties.Resources.ToolbarMaximize;
      });

      buttonMaximize.MouseClick += ((object sender, MouseEventArgs e) => {
        if (form.WindowState == FormWindowState.Maximized)
          form.WindowState = FormWindowState.Normal;
        else
          form.WindowState = FormWindowState.Maximized;
      });

      buttonsPanel.Controls.Add(buttonMaximize);

      PictureBox buttonClose = new PictureBox() {
        Image = Properties.Resources.ToolbarClose,
        Location = new Point(61, 0),
        Size = new Size(31, 25),
        Cursor = Cursors.Hand
      };

      buttonClose.MouseEnter += ((object sender, EventArgs e) => {
        buttonClose.Image = Properties.Resources.ToolbarCloseActive;
      });

      buttonClose.MouseLeave += ((object sender, EventArgs e) => {
        buttonClose.Image = Properties.Resources.ToolbarClose;
      });

      buttonClose.MouseClick += ((object sender, MouseEventArgs e) => {
        Environment.Exit(1);
      });

      buttonsPanel.Controls.Add(buttonClose);

      form.Controls.Add(panel);

      panel = new Panel() {
        Dock = DockStyle.Bottom,
        BackColor = ColorTranslator.FromHtml("#202225"),
        Size = new Size(0, 4),
        Cursor = Cursors.SizeNS
      };

      panel.MouseDown += ((object sender, MouseEventArgs e) => {
        cursorStarPosition = new Point(e.X, e.Y);
      });

      panel.MouseMove += ((object sender, MouseEventArgs e) => {
        if (e.Button == MouseButtons.Left) {
          Point cursorLocation = new Point(e.X, e.Y);

          cursorLocation.Offset(cursorStarPosition.X, cursorStarPosition.Y);

          if ((form.Height + cursorLocation.Y) > 400)
            form.Height = (form.Height + cursorLocation.Y);
        }
      });

      form.Controls.Add(panel);

      Panel resizeNWSE = new Panel() {
        Dock = DockStyle.Right,
        BackColor = ColorTranslator.FromHtml("#202225"),
        Size = new Size(4, 4),
        Cursor = Cursors.SizeNWSE
      };

      resizeNWSE.MouseDown += ((object sender, MouseEventArgs e) => {
        cursorStarPosition = new Point(e.X, e.Y);
      });

      resizeNWSE.MouseMove += ((object sender, MouseEventArgs e) => {
        if (e.Button == MouseButtons.Left) {
          Point cursorLocation = new Point(e.X, e.Y);

          cursorLocation.Offset(cursorStarPosition.X, cursorStarPosition.Y);

          if ((form.Width + cursorLocation.X) > 600)
            form.Width = (form.Width + cursorLocation.X);

          if ((form.Height + cursorLocation.Y) > 400)
            form.Height = (form.Height + cursorLocation.Y);
        }
      });

      panel.Controls.Add(resizeNWSE);

      await Task.Delay(0);
    }
  }
}
