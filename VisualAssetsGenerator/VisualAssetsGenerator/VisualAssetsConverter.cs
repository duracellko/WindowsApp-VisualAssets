using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualAssetsGenerator
{
    public abstract class VisualAssetsConverter
    {
        public void Convert(IEnumerable<IAssetImageSource> sources, string targetFolder, IEnumerable<VisualAssetCategoryInfo> categories)
        {
            if (sources == null)
            {
                throw new ArgumentNullException("source");
            }
            if (string.IsNullOrEmpty(targetFolder))
            {
                throw new ArgumentNullException("targetFolder");
            }
            if (categories == null)
            {
                throw new ArgumentNullException("categories");
            }

            var imageConverter = new ImageAssetConverter();
            foreach (var visualAsset in this.VisualAssets)
            {
                var category = categories.FirstOrDefault(c => c.Name == visualAsset.Category) ?? null;
                if (category != null)
                {
                    visualAsset.Margin = category.Margin;

                    var path = System.IO.Path.Combine(targetFolder, visualAsset.FileName);
                    imageConverter.Convert(sources, path, visualAsset);
                }
            }
        }

        protected abstract IReadOnlyCollection<VisualAssetInfo> VisualAssets { get; }
    }
}
