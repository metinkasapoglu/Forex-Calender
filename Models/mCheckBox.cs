using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Models.ForexCalender
{
    public class mCheckBox : CheckBox
    {
        Color toggleColor = Color.WhiteSmoke;
        Color checkedBackColor = SystemColors.HotTrack;
        Color uncheckedBackColor = Color.Gray;

        [Category("Apperance")]
        public Color CheckedBackColor
        {
            get
            {
                return checkedBackColor;
            }

            set
            {
                checkedBackColor = value;
                this.Invalidate();
            }
        }

        [Category("Apperance")]
        public Color UncheckedBackColor
        {
            get
            {
                return uncheckedBackColor;
            }

            set
            {
                uncheckedBackColor = value;
                this.Invalidate();
            }
        }

        GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.AutoSize = false;
            this.Size = new Size(38, 18);
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(checkedBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(toggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(uncheckedBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(toggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
