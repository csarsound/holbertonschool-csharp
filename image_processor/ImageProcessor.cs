using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

/// <summary>
/// Provides methods for image processing operations.
/// </summary>
public class ImageProcessor
{
    /// <summary>
    /// Inverts the colors of the specified images and saves the inverted versions.
    /// </summary>
    /// <param name="filenames">An array of image filenames to process.</param>
    /// <remarks>
    /// The output images will be saved in the same directory as the original images, using the following naming convention:
    /// &lt;original_file_name&gt;_inverse.&lt;original_file_extension&gt;
    /// The original images will not be overwritten.
    /// </remarks>
    public static void Inverse(string[] filenames)
    {
        string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;

        foreach (string filename in filenames)
        {
            string originalFilePath = Path.Combine(rootDirectory, filename);
            string outputFileName = GenerateOutputFileName(filename);
            string outputFilePath = Path.Combine(rootDirectory, outputFileName);

            Task.Run(() =>
            {
                using (Image originalImage = Image.FromFile(originalFilePath))
                {
                    Bitmap invertedImage = InvertImageColors((Bitmap)originalImage);
                    invertedImage.Save(outputFilePath);
                }
            });
        }

        Task.WaitAll();
    }

    private static Bitmap InvertImageColors(Bitmap originalImage)
    {
        Bitmap invertedImage = new Bitmap(originalImage.Width, originalImage.Height);

        for (int y = 0; y < originalImage.Height; y++)
        {
            for (int x = 0; x < originalImage.Width; x++)
            {
                Color pixelColor = originalImage.GetPixel(x, y);

                Color invertedColor = Color.FromArgb(
                    255 - pixelColor.R,
                    255 - pixelColor.G,
                    255 - pixelColor.B);

                invertedImage.SetPixel(x, y, invertedColor);
            }
        }

        return invertedImage;
    }

    private static string GenerateOutputFileName(string originalFileName)
    {
        string fileName = Path.GetFileNameWithoutExtension(originalFileName);
        string extension = Path.GetExtension(originalFileName);

        string outputFileName = $"{fileName}_inverse{extension}";
        return outputFileName;
    }
}
