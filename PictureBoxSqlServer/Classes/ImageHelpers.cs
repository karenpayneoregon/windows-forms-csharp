using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace PictureBoxSqlServer.Classes
{
    public static class ImageHelpers  
    {
        /// <summary>
        /// Generate a byte array from an <see cref="Image"/>
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        /// <summary>
        /// Generate a <see cref="Image"/> from a byte array
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns></returns>
        public static Image ByteArrayToImage(byte[] byteArray)
        {
            var converter = new ImageConverter();
            var image = (Image)converter.ConvertFrom(byteArray);

            return image;
        }
    }
}