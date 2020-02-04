using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrochartsSample.Services.Interface
{
    public interface IDeviceService
    {
        SKBitmap GetImgFromFile(string fileName);
    }
}
