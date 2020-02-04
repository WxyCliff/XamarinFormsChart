using Android.Graphics;
using MicrochartsSample.Droid;
using MicrochartsSample.Services;
using SkiaSharp;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceService))]
namespace MicrochartsSample.Droid
{
    public class DeviceService : IDeviceService
    {
        public SKBitmap GetImgFromFile(int shopType)
        {
            switch (shopType)
            {
                case 0:
                    return GetDrawableToBitmap(Resource.Drawable.shoppingcart);
                case 1:
                    return GetDrawableToBitmap(Resource.Drawable.car);
                case 2:
                    return GetDrawableToBitmap(Resource.Drawable.fork);
                case 3:
                    return GetDrawableToBitmap(Resource.Drawable.joystick);
                case 4:
                    return GetDrawableToBitmap(Resource.Drawable.house);
                case 5:
                    return GetDrawableToBitmap(Resource.Drawable.tag);
                default:
                    return GetDrawableToBitmap(Resource.Drawable.tag);
            }
        }

        private SKBitmap GetDrawableToBitmap(int resId)
        {
            Bitmap bitmap = BitmapFactory.DecodeResource(AndroidApp.CurrentContext.Resources, resId);
            return SKBitmap.FromImage(SkiaSharp.Views.Android.AndroidExtensions.ToSKImage(bitmap));
        }

    }
}