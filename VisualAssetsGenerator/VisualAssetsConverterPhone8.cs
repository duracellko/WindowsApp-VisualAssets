using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualAssetsGenerator
{
    public class VisualAssetsConverterPhone8 : VisualAssetsConverter
    {
        private readonly VisualAssetInfo[] visualAssets = new VisualAssetInfo[]
        {
            new VisualAssetInfo() { FileName = "Square71x71Logo.scale-100.png", Width = 71, Height = 71, Category = LogoCategories.SmallLogo },
            new VisualAssetInfo() { FileName = "Square71x71Logo.scale-140.png", Width = 99, Height = 99, Category = LogoCategories.SmallLogo },
            new VisualAssetInfo() { FileName = "Square71x71Logo.scale-240.png", Width = 170, Height = 170, Category = LogoCategories.SmallLogo },

            new VisualAssetInfo() { FileName = "Logo.scale-100.png", Width = 150, Height = 150, Category = LogoCategories.Logo },
            new VisualAssetInfo() { FileName = "Logo.scale-140.png", Width = 210, Height = 210, Category = LogoCategories.Logo },
            new VisualAssetInfo() { FileName = "Logo.scale-240.png", Width = 360, Height = 360, Category = LogoCategories.Logo },

            new VisualAssetInfo() { FileName = "WideLogo.scale-100.png", Width = 310, Height = 150, Category = LogoCategories.WideLogo },
            new VisualAssetInfo() { FileName = "WideLogo.scale-140.png", Width = 434, Height = 210, Category = LogoCategories.WideLogo },
            new VisualAssetInfo() { FileName = "WideLogo.scale-240.png", Width = 744, Height = 360, Category = LogoCategories.WideLogo },

            new VisualAssetInfo() { FileName = "SmallLogo.scale-100.png", Width = 44, Height = 44, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "SmallLogo.scale-140.png", Width = 62, Height = 62, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "SmallLogo.scale-240.png", Width = 106, Height = 106, Category = LogoCategories.Icon },

            new VisualAssetInfo() { FileName = "StoreLogo.scale-100.png", Width = 50, Height = 50, Category = LogoCategories.StoreLogo },
            new VisualAssetInfo() { FileName = "StoreLogo.scale-140.png", Width = 70, Height = 70, Category = LogoCategories.StoreLogo },
            new VisualAssetInfo() { FileName = "StoreLogo.scale-240.png", Width = 120, Height = 120, Category = LogoCategories.StoreLogo },

            new VisualAssetInfo() { FileName = "BadgeLogo.scale-100.png", Width = 24, Height = 24, Category = LogoCategories.Badge },
            new VisualAssetInfo() { FileName = "BadgeLogo.scale-140.png", Width = 33, Height = 33, Category = LogoCategories.Badge },
            new VisualAssetInfo() { FileName = "BadgeLogo.scale-240.png", Width = 58, Height = 58, Category = LogoCategories.Badge },

            new VisualAssetInfo() { FileName = "SplashScreen.scale-100.png", Width = 480, Height = 800, Margin = 0.15, Category = LogoCategories.SplashScreen },
            new VisualAssetInfo() { FileName = "SplashScreen.scale-140.png", Width = 672, Height = 1120, Margin = 0.15, Category = LogoCategories.SplashScreen },
            new VisualAssetInfo() { FileName = "SplashScreen.scale-240.png", Width = 1152, Height = 1920, Margin = 0.15, Category = LogoCategories.SplashScreen }
        };

        protected override IReadOnlyCollection<VisualAssetInfo> VisualAssets
        {
            get
            {
                return this.visualAssets;
            }
        }
    }
}
