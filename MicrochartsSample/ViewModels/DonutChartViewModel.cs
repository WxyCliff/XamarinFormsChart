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

        public ObservableCollection<ConsumViewModel> DataList
        {
            get { return this._dataList; }
            set
            {
                this._dataList = value;

                //todo 依實作改名稱
                OnPropertyChanged(nameof(this.DataList));
            }
        }


        public DonutChartViewModel()
        {
            Title = "DonutChart";
            PollValuesAsync();
        }

        private async Task PollValuesAsync()
        {
            await Task.Delay(500);

            try
            {
                List<Consume> cosumes = cosumeService.GetConsumes();
                var entries = cosumes.Select(x => new Microcharts.Entry((float)x.Amount)
                {
                    Label = ChartHelper.ToWord(x.DataType),
                    ValueLabel = x.Amount.ToString(),
                    Color = ChartHelper.GetRandomColor(),  //TODO 隨機顏色或 改成指定顏色
                    Icon = deviceService.GetImgFromFile(x.DataType) //TODO 圖案可以不加
                }
                );
                
                var _chart = new DonutChart();
                _chart.Entries = entries;
                _chart.LabelTextSize = 40; //文字大小
                this.Chart = _chart;

                var list = cosumes.Select(x => new ConsumViewModel() { Id = x.Id, DataType = x.DataType, Amount = x.Amount }).ToList();
                this.DataList = new ObservableCollection<ConsumViewModel>(list);

                OnPropertyChanged(nameof(Chart));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ObservableCollection<ConsumViewModel> _dataList;
    }

    public class ConsumViewModel : Consume
    {
        public string ImageName
        {
            get
            {
                return ChartHelper.ToImageName(this.DataType);
            }
        }

        public string ShopTypeName
        {
            get
            {
                return ChartHelper.ToWord(this.DataType);
            }
        }
    }
}