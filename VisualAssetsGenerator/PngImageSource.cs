using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace VisualAssetsGenerator
{
    public class PngImageSource : IAssetImageSource
    {
        private readonly string path;

        public PngImageSource(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("path");
            }

            this.path = path;    
        }

        public ImageSource GetImageSource()
        {
            using (var stream = new FileStream(this.path, FileMode.Open, FileAccess.Read))
            {
                var png = new PngBitmapDecoder(stream, BitmapCreateOptions.None, BitmapCacheOption.Default);
                return png.Frames[0];
            }
        }
    }
}
