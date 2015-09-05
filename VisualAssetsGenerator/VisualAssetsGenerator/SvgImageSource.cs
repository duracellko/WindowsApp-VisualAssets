using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace VisualAssetsGenerator
{
    public class SvgImageSource : IAssetImageSource
    {
        private readonly string path;

        public SvgImageSource(string path)
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
                return Svg2Xaml.SvgReader.Load(stream);
            }
        }
    }
}
