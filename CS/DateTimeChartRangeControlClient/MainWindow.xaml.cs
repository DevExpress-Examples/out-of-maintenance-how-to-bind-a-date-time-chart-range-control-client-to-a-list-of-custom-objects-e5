using System;
using System.Collections.Generic;
using System.Windows;

namespace DateTimeChartRangeControlClient {

    public class DateTimeItem {
        public object Argument { get; set; }
        public object Value { get; set; }
    }

    public partial class MainWindow : Window {

        const int dataCount = 100;
        List<DateTimeItem> data = new List<DateTimeItem>();

        List<DateTimeItem> GenerateDateTimeData() {
            DateTime now = DateTime.Now.Date;
            Random rand = new Random();
            double value = 0;
            for (int i = 0; i < dataCount; i++) {
                now = now.AddDays(1);
                value += (rand.NextDouble() - 0.5);
                data.Add(new DateTimeItem() { Argument = now, Value = value + Math.Sin(i * 0.6) });
            }
            return data;
        }

        public MainWindow() {
            InitializeComponent();
            this.DataContext = GenerateDateTimeData();
        }
    }
}
