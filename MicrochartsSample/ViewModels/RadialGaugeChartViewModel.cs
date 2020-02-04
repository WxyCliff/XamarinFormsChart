using Microcharts;
using MicrochartsSample.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrochartsSample.ViewModels
{
    public class RadialGaugeChartViewModel : BaseViewModel
    {
        public Chart Chart { get; set; }

        public RadialGaugeChartViewModel()
        {
            Title = "RadialGaugeChart";
            PollValuesAsync();
        }


        private async Task PollValuesAsync()
        {

            await Task.Delay(500);

            List<Consume> cosumes = cosumeService.GetConsumes();
            var entries = cosumes.Select(x => new Microcharts.Entry((float)x.Amount) { Label = ChartHelper.ToWord(x.DataType), ValueLabel = x.Amount.ToString(), Color = ChartHelper.GetRandomColor() });

            var _chart = new RadialGaugeChart();
            _chart.Entries = entries;
            _chart.LabelTextSize = 40;
            this.Chart = _chart;

            OnPropertyChanged(nameof(Chart));

        }
    }
}