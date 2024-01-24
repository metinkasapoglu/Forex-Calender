using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Models.ForexCalender
{
    public class mButton : Button
    {
        #region Props

        [Category("Appearance")]
        public int _BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        #endregion

        #region Fields

        private int borderRadius = 8;
        private bool isClicked;

        #endregion
        
        #region Methods

        public mButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(100, 23);
            this.BackColor = SystemColors.HotTrack;
            this.ForeColor = SystemColors.Control;
            this.Resize += new EventHandler(Button_Resize);
            this.Paint += ButtonNew_Paint;
        }

        private void ButtonNew_Paint(object sender, PaintEventArgs e)
        {
            if (!isClicked)
            {
                using (Pen pen = new Pen(BackColor, 1))
                {
                    int radius = borderRadius;
                    e.Graphics.DrawLine(pen, 1, 0, 1, this.ClientRectangle.Height);
                    e.Graphics.DrawLine(pen, 0, this.ClientRectangle.Height - 1, this.ClientRectangle.Width, this.ClientRectangle.Height - 1);
                    e.Graphics.DrawLine(pen, this.ClientRectangle.Width - 1, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height);
                }
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        #endregion

        #region Overrides

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -this.FlatAppearance.BorderSize, -this.FlatAppearance.BorderSize);
            int smoothSize = 2;
            if (this.FlatAppearance.BorderSize > 0)
                smoothSize = this.FlatAppearance.BorderSize;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - this.FlatAppearance.BorderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(this.FlatAppearance.BorderColor, this.FlatAppearance.BorderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (this.FlatAppearance.BorderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
                if (this.FlatAppearance.BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(this.FlatAppearance.BorderColor, this.FlatAppearance.BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            isClicked = true;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            isClicked = false;
            base.OnMouseUp(mevent);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.AutoSize = true;
        }

        protected override void OnParentFontChanged(EventArgs e)
        {
            base.OnParentFontChanged(e);
            this.AutoSize = true;
        }

        #endregion
    }
}
