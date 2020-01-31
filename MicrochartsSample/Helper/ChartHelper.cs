using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MicrochartsSample.Helper
{
    public static class ChartHelper
    {
        public static SKColor GetRandomColor()
        {
            Random rnd = new Random();
            var hex = $"#{rnd.Next(256):X2}{rnd.Next(256):X2}{rnd.Next(256):X2}";
            return SkiaSharp.SKColor.Parse(hex);
        }
    }
}
