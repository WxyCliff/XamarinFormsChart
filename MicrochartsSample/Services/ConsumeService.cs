using Microcharts;
using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;
using MicrochartsSample.Models;

namespace MicrochartsSample.Services
{
    public class ConsumeService : IConsumeService
    {
        /// <summary>
        /// TODO 實際資料從資料庫或API 取得
        /// </summary>
        public List<Consume> GetConsumes()
        {
            var list = new List<Consume>();
            list.Add(new Consume() { Id = "1", DataType = 0, Amount = 100 });
            list.Add(new Consume() { Id = "2", DataType = 1, Amount = 200 });
            list.Add(new Consume() { Id = "3", DataType = 2, Amount = 300 });
            list.Add(new Consume() { Id = "4", DataType = 3, Amount = 400 });
            list.Add(new Consume() { Id = "5", DataType = 4, Amount = 450 });
            list.Add(new Consume() { Id = "6", DataType = 5, Amount = 50 });

            return list;
        }
    }
}
