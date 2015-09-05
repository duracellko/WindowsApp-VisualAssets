using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualAssetsGenerator
{
    public class VisualAssetsConverter10 : VisualAssetsConverter
    {
        private readonly VisualAssetInfo[] visualAssets = new VisualAssetInfo[]
        {
            new VisualAssetInfo() { FileName = "Square71x71Logo.scale-100.png", Width = 71, Height = 71, Category = LogoCategories.SmallLogo },
            new VisualAssetInfo() { FileName = "Square71x71Logo.scale-125.png", Width = 89, Height = 89, Category = LogoCategories.SmallLogo },
            new VisualAssetInfo() { FileName = "Square71x71Logo.scale-150.png", Width = 107, Height = 107, Category = LogoCategories.SmallLogo },
            new VisualAssetInfo() { FileName = "Square71x71Logo.scale-200.png", Width = 142, Height = 142, Category = LogoCategories.SmallLogo },
            new VisualAssetInfo() { FileName = "Square71x71Logo.scale-400.png", Width = 284, Height = 284, Category = LogoCategories.SmallLogo },

            new VisualAssetInfo() { FileName = "Square150x150Logo.scale-100.png", Width = 150, Height = 150, Category = LogoCategories.Logo },
            new VisualAssetInfo() { FileName = "Square150x150Logo.scale-125.png", Width = 188, Height = 188, Category = LogoCategories.Logo },
            new VisualAssetInfo() { FileName = "Square150x150Logo.scale-150.png", Width = 225, Height = 225, Category = LogoCategories.Logo },
            new VisualAssetInfo() { FileName = "Square150x150Logo.scale-200.png", Width = 300, Height = 300, Category = LogoCategories.Logo },
            new VisualAssetInfo() { FileName = "Square150x150Logo.scale-400.png", Width = 600, Height = 600, Category = LogoCategories.Logo },

            new VisualAssetInfo() { FileName = "Wide310x150Logo.scale-100.png", Width = 310, Height = 150, Category = LogoCategories.WideLogo },
            new VisualAssetInfo() { FileName = "Wide310x150Logo.scale-125.png", Width = 388, Height = 188, Category = LogoCategories.WideLogo },
            new VisualAssetInfo() { FileName = "Wide310x150Logo.scale-150.png", Width = 465, Height = 225, Category = LogoCategories.WideLogo },
            new VisualAssetInfo() { FileName = "Wide310x150Logo.scale-200.png", Width = 620, Height = 300, Category = LogoCategories.WideLogo },
            new VisualAssetInfo() { FileName = "Wide310x150Logo.scale-400.png", Width = 1240, Height = 600, Category = LogoCategories.WideLogo },

            new VisualAssetInfo() { FileName = "Square310x310Logo.scale-100.png", Width = 310, Height = 310, Category = LogoCategories.BigLogo },
            new VisualAssetInfo() { FileName = "Square310x310Logo.scale-125.png", Width = 388, Height = 388, Category = LogoCategories.BigLogo },
            new VisualAssetInfo() { FileName = "Square310x310Logo.scale-150.png", Width = 465, Height = 465, Category = LogoCategories.BigLogo },
            new VisualAssetInfo() { FileName = "Square310x310Logo.scale-200.png", Width = 620, Height = 620, Category = LogoCategories.BigLogo },
            new VisualAssetInfo() { FileName = "Square310x310Logo.scale-400.png", Width = 1240, Height = 1240, Category = LogoCategories.BigLogo },

            new VisualAssetInfo() { FileName = "Square44x44Logo.scale-100.png", Width = 44, Height = 44, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "Square44x44Logo.scale-125.png", Width = 55, Height = 55, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "Square44x44Logo.scale-150.png", Width = 66, Height = 66, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "Square44x44Logo.scale-200.png", Width = 88, Height = 88, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "Square44x44Logo.scale-400.png", Width = 176, Height = 176, Category = LogoCategories.Icon },

            new VisualAssetInfo() { FileName = "Square44x44Logo.targetsize-16.png", Width = 16, Height = 16, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "Square44x44Logo.targetsize-24.png", Width = 24, Height = 24, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "Square44x44Logo.targetsize-48.png", Width = 48, Height = 48, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "Square44x44Logo.targetsize-256.png", Width = 256, Height = 256, Category = LogoCategories.Icon },

            new VisualAssetInfo() { FileName = "StoreLogo.scale-100.png", Width = 50, Height = 50, Category = LogoCategories.StoreLogo },
            new VisualAssetInfo() { FileName = "StoreLogo.scale-125.png", Width = 63, Height = 63, Category = LogoCategories.StoreLogo },
            new VisualAssetInfo() { FileName = "StoreLogo.scale-150.png", Width = 75, Height = 75, Category = LogoCategories.StoreLogo },
            new VisualAssetInfo() { FileName = "StoreLogo.scale-200.png", Width = 100, Height = 100, Category = LogoCategories.StoreLogo },
            new VisualAssetInfo() { FileName = "StoreLogo.scale-400.png", Width = 200, Height = 200, Category = LogoCategories.StoreLogo },

            new VisualAssetInfo() { FileName = "BadgeLogo.scale-100.png", Width = 24, Height = 24, Margin = 0, Category = LogoCategories.Badge },
            new VisualAssetInfo() { FileName = "BadgeLogo.scale-125.png", Width = 30, Height = 30, Margin = 0, Category = LogoCategories.Badge },
            new VisualAssetInfo() { FileName = "BadgeLogo.scale-150.png", Width = 36, Height = 36, Margin = 0, Category = LogoCategories.Badge },
            new VisualAssetInfo() { FileName = "BadgeLogo.scale-200.png", Width = 48, Height = 48, Margin = 0, Category = LogoCategories.Badge },
            new VisualAssetInfo() { FileName = "BadgeLogo.scale-400.png", Width = 96, Height = 96, Margin = 0, Category = LogoCategories.Badge },

            new VisualAssetInfo() { FileName = "SplashScreen.scale-100.png", Width = 620, Height = 300, Margin = 0.15, Category = LogoCategories.SplashScreen },
            new VisualAssetInfo() { FileName = "SplashScreen.scale-125.png", Width = 775, Height = 375, Margin = 0.15, Category = LogoCategories.SplashScreen },
            new VisualAssetInfo() { FileName = "SplashScreen.scale-150.png", Width = 930, Height = 450, Margin = 0.15, Category = LogoCategories.SplashScreen },
            new VisualAssetInfo() { FileName = "SplashScreen.scale-200.png", Width = 1240, Height = 600, Margin = 0.15, Category = LogoCategories.SplashScreen },
            new VisualAssetInfo() { FileName = "SplashScreen.scale-400.png", Width = 2480, Height = 1200, Margin = 0.15, Category = LogoCategories.SplashScreen }
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
