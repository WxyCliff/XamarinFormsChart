using MicrochartsSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrochartsSample.Services
{
    public interface IConsumeService
    {
        /// <summary>
        /// 取得資料消費類別資料
        /// </summary>
        List<Consume> GetConsumes();

        /// <summary>
        /// 取得店家消費
        /// </summary>
        List<ShopAnalysis> GetShopsConsumes();
    }
}
