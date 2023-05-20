using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

/// <summary>
/// Class containing method on editing an image
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Public class to invert an image
    /// </summary>
    /// <param name="filenames">List of image locations to edit</param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            string file = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);

            Bitmap inverted = new Bitmap(filename);

            Rectangle rect = new Rectangle(0, 0, inverted.Width, inverted.Height);
            BitmapData invertedData =
                inverted.LockBits(rect, ImageLockMode.ReadWrite,
                inverted.PixelFormat);

            IntPtr ptr = invertedData.Scan0;

            int bytes = Math.Abs(invertedData.Stride) * inverted.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i++)
                rgbValues[i] = (byte)(255 - rgbValues[i]);

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            inverted.UnlockBits(invertedData);

            inverted.Save(file + "_inverse" + extension);
        }
        );
    }

    /// <summary>
    /// Public class to turn an image into grayscale
    /// </summary>
    /// <param name="filenames">List of image locations to edit</param>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            string file = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);

            Bitmap grayscale = new Bitmap(filename);

            Rectangle rect = new Rectangle(0, 0, grayscale.Width, grayscale.Height);
            BitmapData grayscaleData =
                grayscale.LockBits(rect, ImageLockMode.ReadWrite,
                grayscale.PixelFormat);

            IntPtr ptr = grayscaleData.Scan0;

            int bytes = Math.Abs(grayscaleData.Stride) * grayscale.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length - 3; i += 3)
            {
                byte gray = (byte)(rgbValues[i] * .21 + rgbValues[i + 1] * .71 + rgbValues[i + 2] * .071);
                rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = gray;
            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            grayscale.UnlockBits(grayscaleData);

            grayscale.Save(file + "_grayscale" + extension);
        }
        );
    }

    /// <summary>
    /// Public class to turn an image into black and white
    /// </summary>
    /// <param name="filenames">List of image locations to edit</param>
    /// <param name="threshold">The limit for when something should be black vs white</param>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach(filenames, filename =>
        {
            string file = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);

            Bitmap blackwhite = new Bitmap(filename);

            Rectangle rect = new Rectangle(0, 0, blackwhite.Width, blackwhite.Height);
            BitmapData blackwhiteData =
                blackwhite.LockBits(rect, ImageLockMode.ReadWrite,
                blackwhite.PixelFormat);

            IntPtr ptr = blackwhiteData.Scan0;

            int bytes = Math.Abs(blackwhiteData.Stride) * blackwhite.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length - 3; i += 3)
            {
                if (rgbValues[i] + rgbValues[i + 1] + rgbValues[i + 2] > threshold)
                    rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = 255;
                else
                    rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = 0;
            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            blackwhite.UnlockBits(blackwhiteData);

            blackwhite.Save(file + "_bw" + extension);
        }
        );
    }

    /// <summary>
    /// Public class to turn an image into a thumbnail
    /// </summary>
    /// <param name="filenames">List of image locations to edit</param>
    /// <param name="height">The new height of the thumbnail</param>
    public static void Thumbnail(string[] filenames, int height)
    {
        Parallel.ForEach(filenames, filename =>
        {
            string file = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);

            Bitmap original = new Bitmap(filename);

            int width = (height * original.Width) / original.Height;

            Image thumbnail = original.GetThumbnailImage(width, height, null, IntPtr.Zero);

            thumbnail.Save(file + "_th" + extension);
        }
        );
    }
}
