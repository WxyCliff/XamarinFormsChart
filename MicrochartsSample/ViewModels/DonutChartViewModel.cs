﻿using Microcharts;
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
                }
                );

                var _chart = new DonutChart();
                _chart.Entries = entries;
                _chart.LabelTextSize = 40; //文字大小
                this.Chart = _chart;


                OnPropertyChanged(nameof(Chart));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}