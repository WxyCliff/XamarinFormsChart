

using Android.Net;
using MicrochartsSample.Droid;
using MicrochartsSample.Services.Interface;
using SkiaSharp;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceService))]
namespace MicrochartsSample.Droid
{
    public class DeviceService : IDeviceService
    {
        public SKBitmap GetImgFromFile(string fileName)
        {
            var assembly = this.GetType().GetTypeInfo().Assembly;

            using (Stream s = assembly.GetManifestResourceStream(fileName))
            {
                return SKBitmap.Decode(s);
            }
        }
    }
}