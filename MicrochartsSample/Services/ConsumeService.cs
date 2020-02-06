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
        /// TODO ��ڸ�Ʊq��Ʈw��API ���o
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

        public List<ShopAnalysis> GetShopsConsumes()
        {
            var list = new List<ShopAnalysis>();
            list.Add(new ShopAnalysis() { ShopName = "�x�W���o�ѥ��������q", ConsumeCount = 15, CosumeAmount = 5000 });
            list.Add(new ShopAnalysis() { ShopName = "�M�w���ѥ��������q", ConsumeCount = 10, CosumeAmount = 4000 });
            list.Add(new ShopAnalysis() { ShopName = "�T�Ӧ�ѥ��������q", ConsumeCount = 8, CosumeAmount = 3000 });
            list.Add(new ShopAnalysis() { ShopName = "���ӫȪѥ��������q", ConsumeCount = 7, CosumeAmount = 2000 });
            list.Add(new ShopAnalysis() { ShopName = "�F���֩��Īѥ��������q", ConsumeCount = 6, CosumeAmount = 1000 });
            return list;
        }
    }
}
