using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace OpendataPermkraiExams
{
    public partial class FormExams : Form
    {
        private readonly Dictionary<int, Series> _serieses = new Dictionary<int, Series>();

        public FormExams()
        {
            InitializeComponent();
            LoadData();
            chrtMain.Titles.Add(
                "Доля лиц, сдавших единый государственный экзамен по русскому языку и математике, в общей численности выпускников муниципальных общеобразовательных учреждений, участвовавших в едином государственном экзамене по данным предметам");
            if (_serieses.Count > 0)
            {
                var seriesKvp = _serieses.First();
                trbYear.Minimum = _serieses.Keys.Min();
                trbYear.Maximum = _serieses.Keys.Max();
                trbYear.Value = seriesKvp.Key;
                chrtMain.Series.Add(seriesKvp.Value);
                trbYear.ValueChanged += trbYear_ValueChanged;
            }
        }

        private void LoadData()
        {
            var request =
                WebRequest.Create(
                    "http://opendata.permkrai.ru/LoadDataManager/api/getcsv.ashx?factor=14825&cube=6707330");
            using (var response = request.GetResponse())
            using (var dataStream = response.GetResponseStream())
            using (var parser = new TextFieldParser(dataStream, Encoding.GetEncoding("Windows-1251")))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                var isFirstRow = true;
                var dateColumnIdx = -1;
                var okatoColumnIdx = -1;
                var valueColumnIdx = -1;
                var locations = new List<string>();
                while (!parser.EndOfData)
                {
                    var fields = parser.ReadFields().ToList();
                    if (isFirstRow)
                    {
                        dateColumnIdx = fields.IndexOf("Дата");
                        okatoColumnIdx = fields.IndexOf("ОКАТО");
                        valueColumnIdx = fields.IndexOf("Значение");
                        isFirstRow = false;
                    }
                    else
                    {
                        var year = int.Parse(Strings.Right(fields[dateColumnIdx], 4));
                        var value = double.Parse(fields[valueColumnIdx]);
                        var location = fields[okatoColumnIdx];
                        if (!locations.Contains(location))
                            locations.Add(location);
                        var thisLocationIdx = locations.IndexOf(location);
                        var dataPoint = new DataPoint(thisLocationIdx, value)
                        {
                            AxisLabel = location
                        };
                        if (!_serieses.ContainsKey(year))
                        {
                            _serieses[year] = new Series(year + " год");
                        }
                        _serieses[year].Points.Add(dataPoint);
                    }
                }
            }
        }

        private void trbYear_ValueChanged(object sender, EventArgs e)
        {
            chrtMain.Series.Clear();
            if (_serieses.ContainsKey(trbYear.Value))
                chrtMain.Series.Add(_serieses[trbYear.Value]);
        }
    }
}