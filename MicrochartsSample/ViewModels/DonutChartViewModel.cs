using Microcharts;
using MicrochartsSample.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicrochartsSample.ViewModels
{
    public class DonutChartViewModel : BaseViewModel
    {
        public Chart Chart { get; set; }

        public ObservableCollection<Microcharts.Entry> DataList
        {
            get { return this._dataList; }
            set
            {
                this._dataList = value;
                OnPropertyChanged(nameof(this.DataList));
            }
        }

        ObservableCollection<Microcharts.Entry> _dataList;
        public DonutChartViewModel()
        {
            Title = "DonutChart";
            PollValuesAsync();
        }

        static readonly HttpClient client = new HttpClient();
        SKBitmap webBitmap;

        private async Task PollValuesAsync()
        {

            await Task.Delay(500);

            try
            {
                string url = "https://simpleicon.com/wp-content/uploads/cute.png";
                using (Stream stream = await client.GetStreamAsync(url))
                {
                    using (MemoryStream memStream = new MemoryStream())
                    {
                        await stream.CopyToAsync(memStream);
                        memStream.Seek(0, SeekOrigin.Begin);

                        webBitmap = SKBitmap.Decode(memStream);
                    }
                }

                List<Consume> cosumes = cosumeService.GetConsumes();
                var entries = cosumes.Select(x => new Microcharts.Entry((float)x.Amount)
                {
                    Label = ChartHelper.ToWord(x.DataType),
                    ValueLabel = x.Amount.ToString(),
                    Color = ChartHelper.GetRandomColor(),
                    Icon = webBitmap
                }
                );

                var _chart = new DonutChart();
                _chart.Entries = entries;
                _chart.LabelTextSize = 40;
                this.Chart = _chart;

                this.DataList = new ObservableCollection<Microcharts.Entry>(entries);

                OnPropertyChanged(nameof(Chart));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}