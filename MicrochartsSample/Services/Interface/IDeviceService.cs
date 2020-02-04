using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrochartsSample.Services
{
    public interface IDeviceService
    {
        /// <summary>
        /// 抓圖片
        /// </summary>
        SKBitmap GetImgFromFile(int shopType);
    }
}
