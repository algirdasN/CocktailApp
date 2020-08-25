using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace CocktailApp
{
    public static class Format
    {
        public static string CapitalizeFirst(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }

        public static string CapitalizeEvery(string str)
        {
            return string.Join(" ", str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(s => CapitalizeFirst(s)));
        }

        public static Bitmap ResizeImage(Image image)
        {
            int size = 160; 

            var destRect = new Rectangle(0, 0, size, size);
            var destImage = new Bitmap(size, size);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static Bitmap ReplaceTransparency(Bitmap image)
        {
            var result = new Bitmap(image.Size.Width, image.Size.Height, PixelFormat.Format24bppRgb);
            
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.Clear(Color.White);
                graphics.CompositingMode = CompositingMode.SourceOver;
                graphics.DrawImage(image, 0, 0);
            }
            
            return result;
        }

        public static byte[] GetByteArray(Bitmap image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public static Image GetImage(byte[] byteArr)
        {
            using (var ms = new MemoryStream(byteArr))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
