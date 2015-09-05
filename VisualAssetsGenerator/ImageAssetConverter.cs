using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace VisualAssetsGenerator
{
    public class ImageAssetConverter
    {
        public void Convert(IEnumerable<IAssetImageSource> sources, string target, VisualAssetInfo visualAsset)
        {
            if (sources == null)
            {
                throw new ArgumentNullException("sources");
            }
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException("target");
            }
            if (visualAsset == null)
            {
                throw new ArgumentNullException("visualAsset");
            }

            var rectangle = this.GetRectangleBounds(visualAsset.Width, visualAsset.Height, visualAsset.Margin);
            var drawingVisual = this.CreateDrawingVisual(sources, rectangle);

            var targetBitmap = new RenderTargetBitmap(visualAsset.Width, visualAsset.Height, 96, 96, PixelFormats.Pbgra32);
            targetBitmap.Render(drawingVisual);

            var png = new PngBitmapEncoder();
            png.Frames.Add(BitmapFrame.Create(targetBitmap));

            using (var stream = new FileStream(target, FileMode.Create, FileAccess.Write))
            {
                png.Save(stream);
            }
        }

        private DrawingVisual CreateDrawingVisual(IEnumerable<IAssetImageSource> sources, Rect rectangle)
        {
            var drawingVisual = new DrawingVisual();
            using (var context = drawingVisual.RenderOpen())
            {
                foreach (var source in sources)
                {
                    var sourceImage = source.GetImageSource();
                    context.DrawImage(sourceImage, rectangle);
                }

                context.Close();
            }

            return drawingVisual;
        }

        private Rect GetRectangleBounds(double width, double height, double margin)
        {
            double size = Math.Min(width, height) * (1.0 - margin);
            double x = (width - size) / 2.0;
            double y = (height - size) / 2.0;
            return new Rect(x, y, size, size);
        }
    }
}
