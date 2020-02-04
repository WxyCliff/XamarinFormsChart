using MicrochartsSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrochartsSample.Services
{
    public interface IConsumeService
    {
        /// <summary>
        /// 取得資料
        /// </summary>
        List<Consume> GetConsumes();
    }
}
