using Microcharts;
using MicrochartsSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MicrochartsSample.ViewModels
{
    public class LineChartViewModel : BaseViewModel
    {
        public Chart Chart { get; set; }

        public LineChartViewModel()
        {
            Title = "LineChar";
            PollValuesAsync();
        }


        private async Task PollValuesAsync()
        {
            await Task.Delay(500);

            List<Consume> cosumes = cosumeService.GetConsumes();
            var entries = cosumes.Select(x => new Microcharts.Entry((float)x.Amount) { Label = ChartHelper.ToWord(x.DataType), ValueLabel = x.Amount.ToString(), Color = ChartHelper.GetRandomColor() });

            var _chart = new LineChart();
            _chart.Entries = entries;

            // customized
            _chart.LabelTextSize = 40;
            _chart.LineMode = LineMode.Straight;
            _chart.LineSize = 8;
            _chart.PointMode = PointMode.Square;
            _chart.PointSize = 18;


            this.Chart = _chart;



            OnPropertyChanged(nameof(Chart));

        }
    }
}