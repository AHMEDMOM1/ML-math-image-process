using System.Drawing;

namespace WindowsFormsApp1.Services.ImageProcessing
{
    public interface IImageProcessor
    {
        Bitmap ToGrayscale(Bitmap source);
        Bitmap Invert(Bitmap source);
    }
}
