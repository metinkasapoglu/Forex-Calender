using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ForexCalender.Properties;
using Models.ForexCalender;
using Repository.ForexCalender;

namespace ForexCalender
{
    public partial class MainForm : Form
    {
        #region Fields

        public bool isToday;
        public string selectedDate;
        mCheckBox[] checkBoxes;

        #endregion

        #region Main

        public MainForm()
        {
            this.Icon = Resources.AppIcon;
            InitializeComponent();
            FormSettings settings = new FormSettings(this);
            selectedDate = DateTime.Now.ToString("dd-MM-yyyy");
            checkBoxes = new mCheckBox[] { checkAUD, checkCAD, checkCHF, checkCNY, checkEUR, checkGBP, checkJPY, checkNZD, checkUSD, checkALL, checkHIGH, checkMEDIUM, checkLOW, checkNON };
            UpdateList();
            ControlCheckBoxes();
            RenameButtons();
        }

        void RenameButtons()
        {
            string today = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToUpper();
            for (int i = 1; i <= 7; i++)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is mButton && c.Name == $"btn{i}")
                    {
                        c.Text = $"{GetMonday().AddDays(i - 1).ToString("dd")}\n{c.Text}";
                        if (c.Text.Contains(today))
                        {
                            c.BackColor = Color.SlateBlue;
                        }
                    }
                }
            }
        }

        DateTime GetMonday()
        {
            DateTime today = DateTime.Now;
            DayOfWeek firstDayOfWeek = DayOfWeek.Monday;
            int todayIndex = (int)today.DayOfWeek;
            int daysUntilMonday = (todayIndex - (int)firstDayOfWeek + 7) % 7;
            return today.AddDays(-daysUntilMonday);
        }

        void UpdateList()
        {
            listView.Items.Clear();
            foreach (Event e in GetXML.CategoriseByImpact(this))
            {
                ListViewItem lstItem = new ListViewItem(new[] { e.date, e.time, e.country, e.title, e.impact, e.forecast, e.previous });
                switch (e.impact)
                {
                    case "High":
                        lstItem.ForeColor = Color.Red;
                        break;
                    case "Medium":
                        lstItem.ForeColor = Color.FromArgb(255, 200, 0);
                        break;
                    case "Low":
                        lstItem.ForeColor = Color.LimeGreen;
                        break;
                    case "Holiday":
                        lstItem.ForeColor = SystemColors.ScrollBar;
                        break;
                }
                listView.Items.Add(lstItem);
            }
        }

        void TimerTick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("HH-mm") == "00-00")
            {
                if (!isToday)
                {
                    ButtonDaysClicked(btnToday, null);
                    isToday = true;
                }
            }
            else
            {
                isToday = false;
            }
        }

        void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (mCheckBox checkBox in checkBoxes)
            {
                Settings.Default[checkBox.Name] = checkBox.CheckState == CheckState.Checked ? true : false;
            }
            Settings.Default.Save();
        }

        #endregion

        #region CheckBox

        void ControlCheckBoxes()
        {
            foreach (mCheckBox checkBox in checkBoxes)
            {
                bool settings = Settings.Default[checkBox.Name] == null ? false : (bool)Settings.Default[checkBox.Name];
                checkBox.Checked = settings;
            }

        }

        void CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        #endregion

        #region Buttons

        void ButtonDaysClicked(object sender, EventArgs e)
        {
            DateTime monday = GetMonday();
            if (((Button)sender).Name == "btn1")
            {
                selectedDate = monday.ToString("dd-MM-yyyy");
            }
            else if (((Button)sender).Name == "btn2")
            {
                selectedDate = monday.AddDays(1).ToString("dd-MM-yyyy");
            }
            else if (((Button)sender).Name == "btn3")
            {
                selectedDate = monday.AddDays(2).ToString("dd-MM-yyyy");
            }
            else if (((Button)sender).Name == "btn4")
            {
                selectedDate = monday.AddDays(3).ToString("dd-MM-yyyy");
            }
            else if (((Button)sender).Name == "btn5")
            {
                selectedDate = monday.AddDays(4).ToString("dd-MM-yyyy");
            }
            else if (((Button)sender).Name == "btn6")
            {
                selectedDate = monday.AddDays(5).ToString("dd-MM-yyyy");
            }
            else if (((Button)sender).Name == "btn7")
            {
                selectedDate = monday.AddDays(6).ToString("dd-MM-yyyy");
            }
            else if (((Button)sender).Name == "btnToday")
            {
                selectedDate = DateTime.Now.ToString("dd-MM-yyyy");
            }
            else if (((Button)sender).Name == "btnWeek")
            {
                selectedDate = string.Empty;
            }
            UpdateList();

        }

        void ButtonOthersClicked(object sender, EventArgs e)
        {
            if (((Button)sender).Name == "btnCheck")
            {
                foreach (Control c in pnlFilter.Controls)
                {
                    if (c is mCheckBox cb)
                    {
                        if (btnCheck.Text == "All")
                        {
                            cb.CheckState = CheckState.Checked;
                            btnCheck.BackColor = Color.Gray;
                        }
                        else
                        {
                            cb.CheckState = CheckState.Unchecked;
                            btnCheck.BackColor = Color.DarkSlateBlue;
                        }
                    }
                }
                btnCheck.Text = btnCheck.Text == "All" ? "Non" : "All";
            }
            else if (((Button)sender).Name == "btnFilter")
            {
                this.Width = this.Width == 562 ? 692 : 562;
                pnlFilter.Visible = btnFilter.Text == ">" ? true : false;
                btnFilter.Text = btnFilter.Text == ">" ? "<" : ">";
            }
            else if (((Button)sender).Name == "btnMin")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (((Button)sender).Name == "btnExit")
            {
                Application.Exit();
            }
        }

        #endregion
    }
}
