using Microcharts;
using MicrochartsSample.Models;
using SkiaSharp.Views.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
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

            // 取得資料
            List<ShopAnalysis> cosumes = cosumeService.GetShopsConsumes();

            // 將資料轉為圖表物件
            IEnumerable<Microcharts.Entry> entries = cosumes.Select((x, i) => new Microcharts.Entry((float)x.ConsumeCount)
            {
                Label = (i + 1).ToString(),
                ValueLabel = x.ConsumeCount.ToString(),
                Color = ConvertColor(i).ToSKColor()
            });

            var _chart = new BarChart();

            //  加入圖表資料
            _chart.Entries = entries;

            // 設定文字大小
            _chart.LabelTextSize = 40;

            // 更新圖表系結屬性
            this.Chart = _chart;

            var list = cosumes.Select((x, i) => new ShopAnalysisViewModel() { ShopName = x.ShopName, ConsumeCount = x.ConsumeCount, CosumeAmount = x.CosumeAmount, ItemColor = ConvertColor(i) }).ToList();
            DataList = new ObservableCollection<ShopAnalysisViewModel>(list); ;
            OnPropertyChanged(nameof(Chart));
        }

        /// <summary>
        /// 數字轉顏色
        /// </summary>
        private Color ConvertColor(int idx)
        {
            int colorIndex = idx % 5;

            switch (colorIndex)
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