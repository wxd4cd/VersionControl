using RemoteWebService.Entities;
using RemoteWebService.MnbServiceReference;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace RemoteWebService
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();
        public Form1()
        {
            
            InitializeComponent();
            ParsingCurrencies(FetchCurrencies());
            dataGridView1.DataSource = Rates;
            CurrencycomboBox.DataSource = Currencies;
            // FetchExchangeRates();
            RefreshData();
            
        }

        public void RefreshData()
        {
            Rates.Clear();
            ParsingXML(FetchExchangeRates());
            
            FillChart();

        }
        public string FetchExchangeRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = CurrencycomboBox.SelectedItem.ToString(),
                startDate = FromdateTimePicker.Value.ToString(),
                endDate = UntildateTimePicker.Value.ToString()
            };

            // Ebben az esetben a "var" a GetExchangeRates visszatérési értékéből kapja a típusát.
            // Ezért a response változó valójában GetExchangeRatesResponseBody típusú.
            var response = mnbService.GetExchangeRates(request);

            // Ebben az esetben a "var" a GetExchangeRatesResult property alapján kapja a típusát.
            // Ezért a result változó valójában string típusú.
            var result = response.GetExchangeRatesResult;
            return result;
        }

        public string FetchCurrencies()
        {
            var mnbServiece = new MNBArfolyamServiceSoapClient();

            var request = new GetCurrenciesRequestBody();
            var respone = mnbServiece.GetCurrencies(request);
            var result = respone.GetCurrenciesResult;
            return result;
        }

        public void ParsingCurrencies(string result)
        {
            MessageBox.Show(result.ToString());
            var xml = new XmlDocument();
            xml.LoadXml(result);

            // Végigmegünk a dokumentum fő elemének gyermekein
            foreach (XmlElement element in xml.DocumentElement.ChildNodes[0])
            {
                Currencies.Add(element.InnerText.ToString());
            }
        }

            public void ParsingXML(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            // Végigmegünk a dokumentum fő elemének gyermekein
            foreach (XmlElement element in xml.DocumentElement)
            {
                // Létrehozzuk az adatsort és rögtön hozzáadjuk a listához
                // Mivel ez egy referencia típusú változó, megtehetjük, hogy előbb adjuk a listához és csak később töltjük fel a tulajdonságait
                var rate = new RateData();
                Rates.Add(rate);

                // Dátum
                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                // Valuta
                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;

                rate.Currency = childElement.GetAttribute("curr");

                // Érték
                // Decimal separator is a hard thing, especial when input comes with non-English decimal separator, but the Studio default language is English...
                //string message = string.Format("Parsing Unit and Value: {0} -- {1}, separator: {3}", childElement.GetAttribute("unit").ToString(), childElement.InnerText.ToString(), separator);
                
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                decimal value;
                if (System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "hu")
                {
                    value = decimal.Parse(childElement.InnerText);
                } else
                {
                    value = decimal.Parse(childElement.InnerText.Replace(',','.'));
                }
                
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        public void FillChart()
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void FromdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void UntildateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CurrencycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
