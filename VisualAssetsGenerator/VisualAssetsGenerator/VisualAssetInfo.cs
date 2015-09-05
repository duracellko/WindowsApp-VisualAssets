using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualAssetsGenerator
{
    public class VisualAssetInfo
    {
        public string FileName { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public double Margin { get; set; } = 0.06;

        public string Category { get; set; }
    }
}
