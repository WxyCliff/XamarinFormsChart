using Microcharts;
using MicrochartsSample.Models;
using SkiaSharp.Views.Forms;
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
    public class BarChartViewModel : BaseViewModel
    {
        public Chart Chart { get; set; }

        public ObservableCollection<ShopAnalysisViewModel> DataList
        {
            get { return this._dataList; }
            set
            {
                this._dataList = value;

                //todo 依實作改名稱
                OnPropertyChanged(nameof(this.DataList));
            }
        }

        ObservableCollection<ShopAnalysisViewModel> _dataList;

        public BarChartViewModel()
        {
            Title = "BarChart";
            PollValuesAsync();
        }


        private async Task PollValuesAsync()
        {

            await Task.Delay(500);


            List<ShopAnalysis> cosumes = cosumeService.GetShopsConsumes();
            var entries = cosumes.Select((x, i) => new Microcharts.Entry((float)x.ConsumeCount) { Label ="", ValueLabel = x.ConsumeCount.ToString(), Color = ConvertColor(i).ToSKColor() });

            var _chart = new BarChart();
            _chart.Entries = entries;
            _chart.LabelTextSize = 40;
            this.Chart = _chart;

            var list = cosumes.Select((x, i) => new ShopAnalysisViewModel() { ShopName = x.ShopName, ConsumeCount = x.ConsumeCount, CosumeAmount = x.CosumeAmount, ItemColor = ConvertColor(i) }).ToList();
            DataList = new ObservableCollection<ShopAnalysisViewModel>(list); ;
            OnPropertyChanged(nameof(Chart));
        }

        private Color ConvertColor(int idx)
        {
            switch (idx)
            {
                case 0: return Color.Red;
                case 1: return Color.Orange;
                case 2: return Color.Green;
                case 3: return Color.Blue;
                case 4: return Color.Purple;
                default: return Color.Black;
            }
        }
    }

    public class ShopAnalysisViewModel : ShopAnalysis
    {
        public Color ItemColor { get; set; }
    }


}