using System.Drawing;

namespace WindowsFormsApp1.Services.ImageProcessing
{
    public class ImageProcessor : IImageProcessor
    {
        public Bitmap ToGrayscale(Bitmap source)
        {
            if (source == null) return null;

            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color c = source.GetPixel(x, y);
                    int gray = (int)((c.R + c.G + c.B) / 3.0);
                    Color g = Color.FromArgb(gray, gray, gray);
                    result.SetPixel(x, y, g);
                }
            }

            return result;
        }

        public Bitmap Invert(Bitmap source)
        {
            if (source == null) return null;

            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color c = source.GetPixel(x, y);
                    Color inv = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    result.SetPixel(x, y, inv);
                }
            }

            return result;
        }
    }
}
