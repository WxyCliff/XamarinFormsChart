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
        public List<Consume> GetConsumes()
        {
            var list = new List<Consume>();
            list.Add(new Consume() { Id = "1", DataType = "購物", Amount = 100 });
            list.Add(new Consume() { Id = "2", DataType = "交通", Amount = 200 });
            list.Add(new Consume() { Id = "3", DataType = "飲食", Amount = 300 });
            list.Add(new Consume() { Id = "4", DataType = "娛樂", Amount = 400 });
            list.Add(new Consume() { Id = "5", DataType = "居家", Amount = 450 });
            list.Add(new Consume() { Id = "6", DataType = "其他", Amount = 50 });

            //list.Add(new Consume() { Id = "1", DataType = "AA", Amount = 100 });
            //list.Add(new Consume() { Id = "2", DataType = "BB", Amount = 200 });
            //list.Add(new Consume() { Id = "3", DataType = "XX", Amount = 300 });
            //list.Add(new Consume() { Id = "4", DataType = "CC", Amount = 400 });
            //list.Add(new Consume() { Id = "5", DataType = "DD", Amount = 450 });
            //list.Add(new Consume() { Id = "6", DataType = "EE", Amount = 50 });

            return list;
        }
    }
}
