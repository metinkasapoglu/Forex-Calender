using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ForexCalender;

namespace Repository.ForexCalender
{
    public class FormSettings
    {
        #region Fields

        MainForm mainForm;
        PaintEventArgs p;
        bool mouseDown;
        Point lastLocation;

        #endregion

        #region Form Settings

        public FormSettings(MainForm f)
        {
            mainForm = f;
            mainForm.Resize += Form_Resize;
            mainForm.KeyDown += Form_KeyDown;
            mainForm.Move += Form_Move;
            mainForm.Paint += Form_Paint;

            NotifyIcon n = new NotifyIcon();
            n.Icon = mainForm.Icon;
            n.Text = mainForm.Text;
            n.Visible = true;
            n.Click += NotifyIcon_Click;

            foreach (Control c in mainForm.Controls)
            {
                if (c.Name == "titleBar")
                {
                    c.MouseDown += TitleBar_MouseDown;
                    c.MouseMove += TitleBar_MouseMove;
                    c.MouseUp += TitleBar_MouseUp;
                }
            }
        }
        void Form_Paint(object sender, PaintEventArgs e)
        {
            p = e;
            GraphicsPath path = new GraphicsPath();
            int radius = 10;
            Rectangle rect = new Rectangle(0, 0, mainForm.Width, mainForm.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            mainForm.Region = new Region(path);
        }

        #endregion

        #region NotifyIcon

        void NotifyIcon_Click(object sender, EventArgs e)
        {
            mainForm.WindowState = mainForm.WindowState == FormWindowState.Normal ? FormWindowState.Minimized : FormWindowState.Normal;
            mainForm.ShowInTaskbar = mainForm.WindowState == FormWindowState.Normal ? true : false;
            mainForm.Visible = mainForm.WindowState == FormWindowState.Normal ? true : false;
            mainForm.Activate();
            Form_Paint(mainForm, p);
        }

        void Form_Resize(object sender, EventArgs e)
        {
            if (mainForm.WindowState == FormWindowState.Minimized)
            {
                mainForm.ShowInTaskbar = false;
                mainForm.Visible = false;
            }
        }

        void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mainForm.WindowState = mainForm.WindowState == FormWindowState.Normal ? FormWindowState.Minimized : FormWindowState.Normal;
            }
        }

        void Form_Move(object sender, EventArgs e)
        {
            if (mainForm.WindowState == FormWindowState.Normal)
            {
                int MagnetThreshold = 25;
                if (Math.Abs(mainForm.Top - Screen.FromControl(mainForm).WorkingArea.Top) < MagnetThreshold)
                {
                    mainForm.Location = new Point(mainForm.Location.X, Screen.FromControl(mainForm).WorkingArea.Top);
                }
                if (Math.Abs(mainForm.Left - Screen.FromControl(mainForm).WorkingArea.Left) < MagnetThreshold && Math.Abs(mainForm.Top - Screen.FromControl(mainForm).WorkingArea.Top) < MagnetThreshold)
                {
                    mainForm.Location = new Point(Screen.FromControl(mainForm).WorkingArea.Left, Screen.FromControl(mainForm).WorkingArea.Top);
                }
                if (Math.Abs(mainForm.Left - Screen.FromControl(mainForm).WorkingArea.Left) < MagnetThreshold)
                {
                    mainForm.Location = new Point(Screen.FromControl(mainForm).WorkingArea.Left, mainForm.Location.Y);
                }
                if (Math.Abs(mainForm.Right - Screen.FromControl(mainForm).WorkingArea.Right) < MagnetThreshold && Math.Abs(mainForm.Top - Screen.FromControl(mainForm).WorkingArea.Top) < MagnetThreshold)
                {
                    mainForm.Location = new Point(Screen.FromControl(mainForm).WorkingArea.Right - mainForm.Width, Screen.FromControl(mainForm).WorkingArea.Top);
                }
                if (Math.Abs(mainForm.Right - Screen.FromControl(mainForm).WorkingArea.Right) < MagnetThreshold)
                {
                    mainForm.Location = new Point(Screen.FromControl(mainForm).WorkingArea.Right - mainForm.Width, mainForm.Location.Y);
                }
            }
        }

        #endregion

        #region Drag & Move

        void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (mainForm != null)
                {
                    mainForm.Location = new Point(
                        (mainForm.Location.X - lastLocation.X) + e.X, (mainForm.Location.Y - lastLocation.Y) + e.Y);
                    mainForm.Update();
                }
            }
        }

        void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion
    }
}
