using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace automated_click
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MainTimer.Enabled = true;
            Start.Visible = false;

            if (Start.Text == "Restart")
            {
                SweepBar.Location = new Point(0, 0);
                MainTimer.Enabled = true;
            }
        }

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (SweepBar.Bounds.X >= SteadyBar.Bounds.X)
            {
                MainTimer.Enabled = false;
                mouse_event(0x02 | 0x04, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);

                Start.Visible = true;
                Start.Text = "Restart";
            }
            else
                SweepBar.Location = new Point(SweepBar.Location.X + 1, 0);
        }
    }
}
