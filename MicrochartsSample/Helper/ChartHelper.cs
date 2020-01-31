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


        private static SKTypeface GetTypeface(string label)
        {
            SKTypeface typeface;
            if (CultureInfo.CurrentUICulture.Name == "ja-JP")
                typeface = SKFontManager.Default.MatchCharacter("HiraginoSans", label[0]);
            else if (CultureInfo.CurrentUICulture.Name == "zh-CN")
                typeface = SKFontManager.Default.MatchCharacter("PingFangSC", label[0]);
            else if (CultureInfo.CurrentUICulture.Name == "zh-HK")
                typeface = SKFontManager.Default.MatchCharacter("PingFangHK", label[0]);
            else if (CultureInfo.CurrentUICulture.Name == "zh-TW")
                typeface = SKFontManager.Default.MatchCharacter("PingFangTC", label[0]);
            else
                typeface = SKFontManager.Default.MatchCharacter(".SFUIText-Regular", label[0]);
            return typeface;
        }
    }
}
