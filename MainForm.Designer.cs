using System.Windows.Forms;

namespace ForexCalender
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelInfo = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnCheck = new Models.ForexCalender.mButton();
            this.checkALL = new Models.ForexCalender.mCheckBox();
            this.checkLOW = new Models.ForexCalender.mCheckBox();
            this.checkNON = new Models.ForexCalender.mCheckBox();
            this.checkMEDIUM = new Models.ForexCalender.mCheckBox();
            this.checkAUD = new Models.ForexCalender.mCheckBox();
            this.checkUSD = new Models.ForexCalender.mCheckBox();
            this.checkCAD = new Models.ForexCalender.mCheckBox();
            this.checkHIGH = new Models.ForexCalender.mCheckBox();
            this.checkCHF = new Models.ForexCalender.mCheckBox();
            this.checkNZD = new Models.ForexCalender.mCheckBox();
            this.checkCNY = new Models.ForexCalender.mCheckBox();
            this.checkJPY = new Models.ForexCalender.mCheckBox();
            this.checkEUR = new Models.ForexCalender.mCheckBox();
            this.checkGBP = new Models.ForexCalender.mCheckBox();
            this.btnWeek = new Models.ForexCalender.mButton();
            this.btnToday = new Models.ForexCalender.mButton();
            this.btn7 = new Models.ForexCalender.mButton();
            this.btn6 = new Models.ForexCalender.mButton();
            this.btn5 = new Models.ForexCalender.mButton();
            this.btn4 = new Models.ForexCalender.mButton();
            this.btn3 = new Models.ForexCalender.mButton();
            this.btn2 = new Models.ForexCalender.mButton();
            this.btn1 = new Models.ForexCalender.mButton();
            this.pnlFilter.SuspendLayout();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(23, 126);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(516, 300);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pair";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Title";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Impact";
            this.columnHeader5.Width = 55;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Forecast";
            this.columnHeader6.Width = 55;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Previous";
            this.columnHeader7.Width = 55;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfo.Location = new System.Drawing.Point(174, 94);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(376, 23);
            this.labelInfo.TabIndex = 51;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10000;
            this.Timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(24, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(513, 24);
            this.label15.TabIndex = 11;
            this.label15.Text = "      DATE         TIME    PAIR                           TITLE                  " +
    "         IMPACT      FORE         PREV";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "AUD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(40, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "CAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(40, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "CHF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(40, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "CNY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(40, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "EUR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(40, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "GBP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(40, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "JPY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Location = new System.Drawing.Point(40, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "NZD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Location = new System.Drawing.Point(40, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "USD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Location = new System.Drawing.Point(40, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "ALL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(40, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "High Impact";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(40, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Medium Impact";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.LimeGreen;
            this.label13.Location = new System.Drawing.Point(40, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Low Impact";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label14.Location = new System.Drawing.Point(40, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Non-Economic";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label14);
            this.pnlFilter.Controls.Add(this.btnCheck);
            this.pnlFilter.Controls.Add(this.checkALL);
            this.pnlFilter.Controls.Add(this.checkLOW);
            this.pnlFilter.Controls.Add(this.checkNON);
            this.pnlFilter.Controls.Add(this.checkMEDIUM);
            this.pnlFilter.Controls.Add(this.label10);
            this.pnlFilter.Controls.Add(this.checkAUD);
            this.pnlFilter.Controls.Add(this.checkUSD);
            this.pnlFilter.Controls.Add(this.checkCAD);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.checkHIGH);
            this.pnlFilter.Controls.Add(this.checkCHF);
            this.pnlFilter.Controls.Add(this.label13);
            this.pnlFilter.Controls.Add(this.checkNZD);
            this.pnlFilter.Controls.Add(this.checkCNY);
            this.pnlFilter.Controls.Add(this.checkJPY);
            this.pnlFilter.Controls.Add(this.checkEUR);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.checkGBP);
            this.pnlFilter.Controls.Add(this.label8);
            this.pnlFilter.Controls.Add(this.label9);
            this.pnlFilter.Controls.Add(this.label5);
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.label11);
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.label7);
            this.pnlFilter.Controls.Add(this.label12);
            this.pnlFilter.Location = new System.Drawing.Point(545, 126);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(122, 300);
            this.pnlFilter.TabIndex = 10;
            this.pnlFilter.Visible = false;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.titleBar.Controls.Add(this.btnMin);
            this.titleBar.Controls.Add(this.label16);
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.Controls.Add(this.btnFilter);
            this.titleBar.Controls.Add(this.btnExit);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(562, 32);
            this.titleBar.TabIndex = 54;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = global::ForexCalender.Properties.Resources.Min;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMin.Location = new System.Drawing.Point(466, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 32);
            this.btnMin.TabIndex = 58;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.ButtonOthersClicked);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(32, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 20);
            this.label16.TabIndex = 57;
            this.label16.Text = "Forex Calender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ForexCalender.Properties.Resources.TitleBarIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.Location = new System.Drawing.Point(498, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(32, 32);
            this.btnFilter.TabIndex = 56;
            this.btnFilter.Text = ">";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.ButtonOthersClicked);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::ForexCalender.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(530, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 55;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ButtonOthersClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Gray;
            this.btnCheck.BorderRadius = 8;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCheck.Location = new System.Drawing.Point(81, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(38, 24);
            this.btnCheck.TabIndex = 52;
            this.btnCheck.Text = "Non";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.ButtonOthersClicked);
            // 
            // checkALL
            // 
            this.checkALL.Checked = true;
            this.checkALL.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkALL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkALL.Location = new System.Drawing.Point(3, 190);
            this.checkALL.Name = "checkALL";
            this.checkALL.Size = new System.Drawing.Size(38, 18);
            this.checkALL.TabIndex = 53;
            this.checkALL.Text = "mSlideBox1";
            this.checkALL.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkALL.UseVisualStyleBackColor = true;
            this.checkALL.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkLOW
            // 
            this.checkLOW.Checked = true;
            this.checkLOW.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkLOW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLOW.Location = new System.Drawing.Point(3, 254);
            this.checkLOW.Name = "checkLOW";
            this.checkLOW.Size = new System.Drawing.Size(38, 18);
            this.checkLOW.TabIndex = 53;
            this.checkLOW.Text = "mSlideBox1";
            this.checkLOW.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkLOW.UseVisualStyleBackColor = true;
            this.checkLOW.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkNON
            // 
            this.checkNON.Checked = true;
            this.checkNON.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkNON.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNON.Location = new System.Drawing.Point(3, 274);
            this.checkNON.Name = "checkNON";
            this.checkNON.Size = new System.Drawing.Size(38, 18);
            this.checkNON.TabIndex = 53;
            this.checkNON.Text = "mSlideBox1";
            this.checkNON.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkNON.UseVisualStyleBackColor = true;
            this.checkNON.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkMEDIUM
            // 
            this.checkMEDIUM.Checked = true;
            this.checkMEDIUM.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkMEDIUM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMEDIUM.Location = new System.Drawing.Point(3, 234);
            this.checkMEDIUM.Name = "checkMEDIUM";
            this.checkMEDIUM.Size = new System.Drawing.Size(38, 18);
            this.checkMEDIUM.TabIndex = 53;
            this.checkMEDIUM.Text = "mSlideBox1";
            this.checkMEDIUM.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkMEDIUM.UseVisualStyleBackColor = true;
            this.checkMEDIUM.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkAUD
            // 
            this.checkAUD.Checked = true;
            this.checkAUD.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkAUD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAUD.Location = new System.Drawing.Point(3, 10);
            this.checkAUD.Name = "checkAUD";
            this.checkAUD.Size = new System.Drawing.Size(38, 18);
            this.checkAUD.TabIndex = 53;
            this.checkAUD.Text = "mSlideBox1";
            this.checkAUD.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkAUD.UseVisualStyleBackColor = true;
            this.checkAUD.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkUSD
            // 
            this.checkUSD.Checked = true;
            this.checkUSD.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkUSD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUSD.Location = new System.Drawing.Point(3, 170);
            this.checkUSD.Name = "checkUSD";
            this.checkUSD.Size = new System.Drawing.Size(38, 18);
            this.checkUSD.TabIndex = 53;
            this.checkUSD.Text = "mSlideBox1";
            this.checkUSD.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkUSD.UseVisualStyleBackColor = true;
            this.checkUSD.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkCAD
            // 
            this.checkCAD.Checked = true;
            this.checkCAD.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkCAD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCAD.Location = new System.Drawing.Point(3, 30);
            this.checkCAD.Name = "checkCAD";
            this.checkCAD.Size = new System.Drawing.Size(38, 18);
            this.checkCAD.TabIndex = 53;
            this.checkCAD.Text = "mSlideBox1";
            this.checkCAD.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkCAD.UseVisualStyleBackColor = true;
            this.checkCAD.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkHIGH
            // 
            this.checkHIGH.Checked = true;
            this.checkHIGH.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkHIGH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHIGH.Location = new System.Drawing.Point(3, 214);
            this.checkHIGH.Name = "checkHIGH";
            this.checkHIGH.Size = new System.Drawing.Size(38, 18);
            this.checkHIGH.TabIndex = 53;
            this.checkHIGH.Text = "mSlideBox1";
            this.checkHIGH.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkHIGH.UseVisualStyleBackColor = true;
            this.checkHIGH.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkCHF
            // 
            this.checkCHF.Checked = true;
            this.checkCHF.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkCHF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCHF.Location = new System.Drawing.Point(3, 50);
            this.checkCHF.Name = "checkCHF";
            this.checkCHF.Size = new System.Drawing.Size(38, 18);
            this.checkCHF.TabIndex = 53;
            this.checkCHF.Text = "mSlideBox1";
            this.checkCHF.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkCHF.UseVisualStyleBackColor = true;
            this.checkCHF.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkNZD
            // 
            this.checkNZD.Checked = true;
            this.checkNZD.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkNZD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNZD.Location = new System.Drawing.Point(3, 150);
            this.checkNZD.Name = "checkNZD";
            this.checkNZD.Size = new System.Drawing.Size(38, 18);
            this.checkNZD.TabIndex = 53;
            this.checkNZD.Text = "mSlideBox1";
            this.checkNZD.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkNZD.UseVisualStyleBackColor = true;
            this.checkNZD.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkCNY
            // 
            this.checkCNY.Checked = true;
            this.checkCNY.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkCNY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCNY.Location = new System.Drawing.Point(3, 70);
            this.checkCNY.Name = "checkCNY";
            this.checkCNY.Size = new System.Drawing.Size(38, 18);
            this.checkCNY.TabIndex = 53;
            this.checkCNY.Text = "mSlideBox1";
            this.checkCNY.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkCNY.UseVisualStyleBackColor = true;
            this.checkCNY.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkJPY
            // 
            this.checkJPY.Checked = true;
            this.checkJPY.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkJPY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkJPY.Location = new System.Drawing.Point(3, 130);
            this.checkJPY.Name = "checkJPY";
            this.checkJPY.Size = new System.Drawing.Size(38, 18);
            this.checkJPY.TabIndex = 53;
            this.checkJPY.Text = "mSlideBox1";
            this.checkJPY.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkJPY.UseVisualStyleBackColor = true;
            this.checkJPY.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkEUR
            // 
            this.checkEUR.Checked = true;
            this.checkEUR.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkEUR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEUR.Location = new System.Drawing.Point(3, 90);
            this.checkEUR.Name = "checkEUR";
            this.checkEUR.Size = new System.Drawing.Size(38, 18);
            this.checkEUR.TabIndex = 53;
            this.checkEUR.Text = "mSlideBox1";
            this.checkEUR.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkEUR.UseVisualStyleBackColor = true;
            this.checkEUR.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkGBP
            // 
            this.checkGBP.Checked = true;
            this.checkGBP.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkGBP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGBP.Location = new System.Drawing.Point(3, 110);
            this.checkGBP.Name = "checkGBP";
            this.checkGBP.Size = new System.Drawing.Size(38, 18);
            this.checkGBP.TabIndex = 53;
            this.checkGBP.Text = "mSlideBox1";
            this.checkGBP.UncheckedBackColor = System.Drawing.Color.Gray;
            this.checkGBP.UseVisualStyleBackColor = true;
            this.checkGBP.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnWeek.BorderRadius = 8;
            this.btnWeek.FlatAppearance.BorderSize = 0;
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWeek.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnWeek.Location = new System.Drawing.Point(96, 93);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(72, 23);
            this.btnWeek.TabIndex = 8;
            this.btnWeek.Text = "All Week";
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Click += new System.EventHandler(this.ButtonDaysClicked);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnToday.BorderRadius = 8;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToday.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnToday.Location = new System.Drawing.Point(22, 93);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(72, 23);
            this.btnToday.TabIndex = 7;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.ButtonDaysClicked);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn7.BorderRadius = 8;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn7.Location = new System.Drawing.Point(466, 43);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 48);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "SUN";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.ButtonDaysClicked);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn6.BorderRadius = 8;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn6.Location = new System.Drawing.Point(392, 43);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 48);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "SAT";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.ButtonDaysClicked);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn5.BorderRadius = 8;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn5.Location = new System.Drawing.Point(318, 43);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 48);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "FRI";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.ButtonDaysClicked);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn4.BorderRadius = 8;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn4.Location = new System.Drawing.Point(244, 43);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 48);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "THU";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.ButtonDaysClicked);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn3.BorderRadius = 8;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn3.Location = new System.Drawing.Point(170, 43);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 48);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "WED";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.ButtonDaysClicked);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn2.BorderRadius = 8;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn2.Location = new System.Drawing.Point(96, 43);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 48);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "TUE";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.ButtonDaysClicked);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn1.BorderRadius = 8;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn1.Location = new System.Drawing.Point(22, 43);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 48);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "MON";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.ButtonDaysClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listView);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(562, 43);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forex Calender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public ColumnHeader columnHeader1;
        public ColumnHeader columnHeader2;
        public ColumnHeader columnHeader3;
        public ColumnHeader columnHeader4;
        public ColumnHeader columnHeader5;
        public ColumnHeader columnHeader6;
        public ColumnHeader columnHeader7;
        public Label labelInfo;
        public Timer Timer;
        public ListView listView;
        public Models.ForexCalender.mButton btnToday;
        public Models.ForexCalender.mButton btnWeek;
        public Models.ForexCalender.mButton btnCheck;
        public Models.ForexCalender.mCheckBox checkAUD;
        public Models.ForexCalender.mCheckBox checkCAD;
        public Models.ForexCalender.mCheckBox checkCHF;
        public Models.ForexCalender.mCheckBox checkCNY;
        public Models.ForexCalender.mCheckBox checkEUR;
        public Models.ForexCalender.mCheckBox checkGBP;
        public Models.ForexCalender.mCheckBox checkJPY;
        public Models.ForexCalender.mCheckBox checkNZD;
        public Models.ForexCalender.mCheckBox checkUSD;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label9;
        public Models.ForexCalender.mCheckBox checkALL;
        public Label label10;
        public Models.ForexCalender.mCheckBox checkHIGH;
        public Models.ForexCalender.mCheckBox checkMEDIUM;
        public Models.ForexCalender.mCheckBox checkLOW;
        public Models.ForexCalender.mCheckBox checkNON;
        public Label label11;
        public Label label12;
        public Label label13;
        public Label label14;
        public Label label15;
        public Models.ForexCalender.mButton btn1;
        public Models.ForexCalender.mButton btn2;
        public Models.ForexCalender.mButton btn3;
        public Models.ForexCalender.mButton btn4;
        public Models.ForexCalender.mButton btn5;
        public Models.ForexCalender.mButton btn6;
        public Models.ForexCalender.mButton btn7;
        public Panel pnlFilter;
        public Panel titleBar;
        public Button btnFilter;
        public Button btnExit;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox1;
        private Label label16;
        public Button btnMin;
    }
}

