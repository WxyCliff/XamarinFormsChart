using MicrochartsSample.iOS;
using MicrochartsSample.Services;
using SkiaSharp;
using SkiaSharp.Views.iOS;
using System;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceService))]
namespace MicrochartsSample.iOS
{
    public class DeviceService : IDeviceService
    {
        public SKBitmap GetImgFromFile(int shopType)
        {
            switch (shopType)
            {
                case 0:
                    return UIImage.FromBundle("shoppingcart").ToSKBitmap();
                case 1:
                    return UIImage.FromBundle("car").ToSKBitmap();
                case 2:
                    return UIImage.FromBundle("fork").ToSKBitmap();
                case 3:
                    return UIImage.FromBundle("joystick").ToSKBitmap();
                case 4:
                    return UIImage.FromBundle("house").ToSKBitmap();
                case 5:
                    return UIImage.FromBundle("tag").ToSKBitmap();
                default:
                    return UIImage.FromBundle("tag").ToSKBitmap();
            }
        }
    }
}