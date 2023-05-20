using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

///<summary>Collection of methods for image manipulation</summary>
public class ImageProcessor
{
    ///<summary>inverts the colorscale of images</summary>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach (filenames, file => {
            CreateInverse(file);
        });
    }

    private static void CreateInverse(string file)
    {
        Bitmap bmp = new Bitmap(file);
        BitmapData bitmapData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);

        int bytesPerPixel = Bitmap.GetPixelFormatSize(bmp.PixelFormat) / 8;
        int byteCount = bitmapData.Stride * bmp.Height;
        byte[] pixels = new byte[byteCount];
        IntPtr ptrFirstPixel = bitmapData.Scan0;
        Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
        int heightInPixels = bitmapData.Height;
        int widthInBytes = bitmapData.Width * bytesPerPixel;

        for (int y = 0; y < heightInPixels; y++)
        {
            int currentLine = y * bitmapData.Stride;
            for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
            {
                int oldBlue = pixels[currentLine + x];
                int oldGreen = pixels[currentLine + x + 1];
                int oldRed = pixels[currentLine + x + 2];

                // calculate new pixel value
                pixels[currentLine + x] = (byte)(255 - oldBlue);
                pixels[currentLine + x + 1] = (byte)(255 - oldGreen);
                pixels[currentLine + x + 2] = (byte)(255 - oldRed);
            }
        }
 
        // copy modified bytes back
        Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
        bmp.UnlockBits(bitmapData);

        //create new file name
        string name = string.Format("{0}_inverse{1}",
                                    Path.GetFileNameWithoutExtension(file),
                                    Path.GetExtension(file));
        //save new image
        bmp.Save(name);
    }
}
