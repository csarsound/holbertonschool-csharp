using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

class ImageProcessor
{
    public static void Thumbnail(string[] filenames, int height)
    {
        Parallel.ForEach(filenames, (imagePath) =>
        {
            using (Bitmap image = new Bitmap(imagePath))
            {
                int thumbnailWidth = image.Width / (image.Height / height);
                Image thumbnail = image.GetThumbnailImage(thumbnailWidth, height, () => false, IntPtr.Zero);

                string newFilename = GetNewFilename(imagePath, "_th");
                thumbnail.Save(newFilename);
            }
        });
    }

    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach(filenames, (imagePath) =>
        {
            using (Bitmap image = new Bitmap(imagePath))
            {
                BitmapData bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);
                int bytes = bmpData.Stride * bmpData.Height;
                byte[] rgbBuffer = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, rgbBuffer, 0, bytes);

                for (int i = 0; i + 2 < bytes; i += 3)
                {
                    byte gray = (byte)((0.21 * rgbBuffer[i]) + (0.71 * rgbBuffer[i + 1]) + (0.071 * rgbBuffer[i + 2]));
                    gray = (byte)(gray >= threshold ? 255 : 0);
                    rgbBuffer[i] = rgbBuffer[i + 1] = rgbBuffer[i + 2] = gray;
                }

                System.Runtime.InteropServices.Marshal.Copy(rgbBuffer, 0, bmpData.Scan0, bytes);
                image.UnlockBits(bmpData);

                string newFilename = GetNewFilename(imagePath, "_bw");
                image.Save(newFilename);
            }
        });
    }

    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, (imagePath) =>
        {
            using (Bitmap image = new Bitmap(imagePath))
            {
                BitmapData bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);
                int bytes = bmpData.Stride * bmpData.Height;
                byte[] rgbBuffer = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, rgbBuffer, 0, bytes);

                for (int i = 0; i + 2 < bytes; i += 3)
                {
                    byte gray = (byte)((0.21 * rgbBuffer[i]) + (0.71 * rgbBuffer[i + 1]) + (0.071 * rgbBuffer[i + 2]));
                    rgbBuffer[i] = rgbBuffer[i + 1] = rgbBuffer[i + 2] = gray;
                }

                System.Runtime.InteropServices.Marshal.Copy(rgbBuffer, 0, bmpData.Scan0, bytes);
                image.UnlockBits(bmpData);

                string newFilename = GetNewFilename(imagePath, "_grayscale");
                image.Save(newFilename);
            }
        });
    }

    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, (imagePath) =>
        {
            using (Bitmap image = new Bitmap(imagePath))
            {
                BitmapData bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);
                int bytes = bmpData.Stride * bmpData.Height;
                byte[] rgbBuffer = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, rgbBuffer, 0, bytes);

                for (int i = 0; i < bytes; i++)
                {
                    rgbBuffer[i] = (byte)(255 - rgbBuffer[i]);
                }

                System.Runtime.InteropServices.Marshal.Copy(rgbBuffer, 0, bmpData.Scan0, bytes);
                image.UnlockBits(bmpData);

                string newFilename = GetNewFilename(imagePath, "_inverse");
                image.Save(newFilename);
            }
        });
    }

    private static string GetNewFilename(string imagePath, string suffix)
    {
        string directory = System.IO.Path.GetDirectoryName(imagePath);
        string filename = System.IO.Path.GetFileNameWithoutExtension(imagePath);
        string extension = System.IO.Path.GetExtension(imagePath);

        return System.IO.Path.Combine(directory, $"{filename}{suffix}{extension}");
    }
}
