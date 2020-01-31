using Microcharts;
using MicrochartsSample.Helper;
using MicrochartsSample.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MicrochartsSample.ViewModels
{
    public class DonutChartViewModel : BaseViewModel
    {
        public Chart Chart { get; set; }

        public ObservableCollection<Microcharts.Entry> DataList { get; set; }
        public DonutChartViewModel()
        {
            Title = "DonutChart";
            PollValuesAsync();
        }


        private async Task PollValuesAsync()
        {

            await Task.Delay(500);

            List<Consume> cosumes = cosumeService.GetConsumes();
            var entries = cosumes.Select(x => new Microcharts.Entry((float)x.Amount) { Label = x.DataType, ValueLabel = x.Amount.ToString(), Color = ChartHelper.GetRandomColor() });

            var _chart = new DonutChart();
            _chart.Entries = entries;
            _chart.LabelTextSize = 40;
            this.Chart = _chart;

            this.DataList = new ObservableCollection<Microcharts.Entry>(entries);

            OnPropertyChanged(nameof(Chart));

        }
    }
}