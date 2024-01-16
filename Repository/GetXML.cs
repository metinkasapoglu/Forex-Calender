using ForexCalender;
using ForexCalender.Properties;
using Models.ForexCalender;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace Repository.ForexCalender
{
    public static class GetXML
    {
        static MainForm m;
        static XDocument dataXML = XDocument.Load(Settings.Default.pathXML);
        static List<Event> GetData()
        {
            List<Event> events = new List<Event>();
            List<XElement> list = dataXML.Descendants("event").ToList();
            foreach (XElement xe in list)
            {
                Event e = new Event();
                e.title = xe.Element("title").Value;
                e.country = xe.Element("country").Value;
                e.date = DateTime.ParseExact(xe.Element("date").Value, "MM-dd-yyyy", null).ToString("dd-MM-yyyy");
                e.time = DateTime.ParseExact(xe.Element("time").Value, "h:mmtt", CultureInfo.InvariantCulture).AddHours(3).ToString("HH:mm");
                e.impact = xe.Element("impact").Value;
                e.forecast = xe.Element("forecast").Value;
                e.previous = xe.Element("previous").Value;
                events.Add(e);
            }
            return events;
        }

        static List<Event> CategoriseByDate()
        {
            List<Event> dataList = GetXML.GetData();
            int dataCount = dataList.Count;
            int i = 0;
            while (i < dataList.Count)
            {
                Event e = dataList[i];
                if (!string.IsNullOrEmpty(m.selectedDate) && !e.date.Contains(m.selectedDate))
                {
                    dataList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            string today = DateTime.Today.ToString("dd-MM-yyyy");
            if (!string.IsNullOrEmpty(m.selectedDate))
            {
                m.labelInfo.Text = $"News: {dataCount}         Today: {today}         Selected Day: {m.selectedDate}";
            }
            else
            {
                m.labelInfo.Text = $"News: {dataCount}         Today: {today}         Selected All Week";
            }
            return dataList;
        }

        static List<Event> CategoriseByCountry()
        {
            List<Event> dataList = CategoriseByDate();
            int i = 0;
            while (i < dataList.Count)
            {
                Event e = dataList[i];
                if ((e.country.Contains("AUD") && !m.checkAUD.Checked) ||
                    (e.country.Contains("CAD") && !m.checkCAD.Checked) ||
                    (e.country.Contains("CHF") && !m.checkCHF.Checked) ||
                    (e.country.Contains("CNY") && !m.checkCNY.Checked) ||
                    (e.country.Contains("EUR") && !m.checkEUR.Checked) ||
                    (e.country.Contains("GBP") && !m.checkGBP.Checked) ||
                    (e.country.Contains("JPY") && !m.checkJPY.Checked) ||
                    (e.country.Contains("NZD") && !m.checkNZD.Checked) ||
                    (e.country.Contains("USD") && !m.checkUSD.Checked) ||
                    (e.country.Contains("All") && !m.checkALL.Checked))
                {
                    dataList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            return dataList;
        }

        public static List<Event> CategoriseByImpact(MainForm form)
        {
            m = form;
            List<Event> dataList = CategoriseByCountry();
            int i = 0;
            while (i < dataList.Count)
            {
                Event e = dataList[i];
                if ((e.impact.Contains("Low") && !m.checkLOW.Checked) ||
                    (e.impact.Contains("Medium") && !m.checkMEDIUM.Checked) ||
                    (e.impact.Contains("High") && !m.checkHIGH.Checked) ||
                    (e.impact.Contains("Holiday") && !m.checkNON.Checked))
                {
                    dataList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            return dataList;
        }

    }
}
