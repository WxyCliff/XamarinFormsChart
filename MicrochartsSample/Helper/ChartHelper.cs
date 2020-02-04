using MicrochartsSample.Models;
using SkiaSharp;
using System;
using System.IO;
using Xamarin.Forms;

namespace MicrochartsSample
{
    public static class ChartHelper
    {
        public static SKColor GetRandomColor()
        {
            Random rnd = new Random();
            var hex = $"#{rnd.Next(256):X2}{rnd.Next(256):X2}{rnd.Next(256):X2}";
            return SkiaSharp.SKColor.Parse(hex);
        }

        public static string ToWord(int shopType)
        {
            switch (shopType)
            {
                case 0:
                    return "購物";
                case 1:
                    return "交通";
                case 2:
                    return "飲食";
                case 3:
                    return "娛樂";
                case 4:
                    return "居家";
                case 5:
                    return "其他";
                default: return "其他";
            }
        }

        public static string ToImageName(int shopType)
        {
            switch (shopType)
            {
                case 0:
                    return "shoppingcart";
                case 1:
                    return "car";
                case 2:
                    return "fork";
                case 3:
                    return "joystick";
                case 4:
                    return "house";
                case 5:
                    return "tag";
                default:
                    return "tag";
            }
        }

        public static SKBitmap ToBitmap(int shopType)
        {
            string fileName = "";
            switch (shopType)
            {
                case 0:
                    fileName = "shoppingcart.png";
                    break;

                case 1:
                    fileName = "car.png";
                    break;

                case 2:
                    fileName = "fork.png";
                    break;

                case 3:
                    fileName = "joystick.png";
                    break;

                case 4:
                    fileName = "house.png";
                    break;

                case 5:
                    fileName = "tag.png";
                    break;

                default:
                    fileName = "tag.png";
                    break;
            }
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                var info = new SKImageInfo(20, 20);
                return SKBitmap.Decode(fs, info);
            }
        }
    }
}
