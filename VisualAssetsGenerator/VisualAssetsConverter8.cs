using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualAssetsGenerator
{
    public class VisualAssetsConverter8 : VisualAssetsConverter
    {
        private readonly VisualAssetInfo[] visualAssets = new VisualAssetInfo[]
        {
            new VisualAssetInfo() { FileName = "Square70x70Logo.scale-100.png", Width = 70, Height = 70, Category = LogoCategories.SmallLogo },
            new VisualAssetInfo() { FileName = "Square70x70Logo.scale-80.png", Width = 56, Height = 56, Category = LogoCategories.SmallLogo },
            new VisualAssetInfo() { FileName = "Square70x70Logo.scale-140.png", Width = 98, Height = 98, Category = LogoCategories.SmallLogo },
            new VisualAssetInfo() { FileName = "Square70x70Logo.scale-180.png", Width = 126, Height = 126, Category = LogoCategories.SmallLogo },

            new VisualAssetInfo() { FileName = "Logo.scale-100.png", Width = 150, Height = 150, Category = LogoCategories.Logo },
            new VisualAssetInfo() { FileName = "Logo.scale-80.png", Width = 120, Height = 120, Category = LogoCategories.Logo },
            new VisualAssetInfo() { FileName = "Logo.scale-140.png", Width = 210, Height = 210, Category = LogoCategories.Logo },
            new VisualAssetInfo() { FileName = "Logo.scale-180.png", Width = 270, Height = 270, Category = LogoCategories.Logo },

            new VisualAssetInfo() { FileName = "Wide310x150Logo.scale-100.png", Width = 310, Height = 150, Category = LogoCategories.WideLogo },
            new VisualAssetInfo() { FileName = "Wide310x150Logo.scale-80.png", Width = 248, Height = 120, Category = LogoCategories.WideLogo },
            new VisualAssetInfo() { FileName = "Wide310x150Logo.scale-140.png", Width = 434, Height = 210, Category = LogoCategories.WideLogo },
            new VisualAssetInfo() { FileName = "Wide310x150Logo.scale-180.png", Width = 558, Height = 270, Category = LogoCategories.WideLogo },

            new VisualAssetInfo() { FileName = "Square310x310Logo.scale-100.png", Width = 310, Height = 310, Category = LogoCategories.BigLogo },
            new VisualAssetInfo() { FileName = "Square310x310Logo.scale-80.png", Width = 248, Height = 248, Category = LogoCategories.BigLogo },
            new VisualAssetInfo() { FileName = "Square310x310Logo.scale-140.png", Width = 434, Height = 434, Category = LogoCategories.BigLogo },
            new VisualAssetInfo() { FileName = "Square310x310Logo.scale-180.png", Width = 558, Height = 558, Category = LogoCategories.BigLogo },

            new VisualAssetInfo() { FileName = "SmallLogo.scale-100.png", Width = 30, Height = 30, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "SmallLogo.scale-80.png", Width = 24, Height = 24, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "SmallLogo.scale-140.png", Width = 42, Height = 42, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "SmallLogo.scale-180.png", Width = 54, Height = 54, Category = LogoCategories.Icon },

            new VisualAssetInfo() { FileName = "SmallLogo.targetsize-16.png", Width = 16, Height = 16, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "SmallLogo.targetsize-32.png", Width = 32, Height = 32, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "SmallLogo.targetsize-48.png", Width = 48, Height = 48, Category = LogoCategories.Icon },
            new VisualAssetInfo() { FileName = "SmallLogo.targetsize-256.png", Width = 256, Height = 256, Category = LogoCategories.Icon },

            new VisualAssetInfo() { FileName = "StoreLogo.scale-100.png", Width = 50, Height = 50, Category = LogoCategories.StoreLogo },
            new VisualAssetInfo() { FileName = "StoreLogo.scale-140.png", Width = 70, Height = 70, Category = LogoCategories.StoreLogo },
            new VisualAssetInfo() { FileName = "StoreLogo.scale-180.png", Width = 90, Height = 90, Category = LogoCategories.StoreLogo },

            new VisualAssetInfo() { FileName = "BadgeLogo.scale-100.png", Width = 24, Height = 24, Category = LogoCategories.Badge },
            new VisualAssetInfo() { FileName = "BadgeLogo.scale-140.png", Width = 33, Height = 33, Category = LogoCategories.Badge },
            new VisualAssetInfo() { FileName = "BadgeLogo.scale-180.png", Width = 43, Height = 43, Category = LogoCategories.Badge },

            new VisualAssetInfo() { FileName = "SplashScreen.scale-100.png", Width = 620, Height = 300, Margin = 0.15, Category = LogoCategories.SplashScreen },
            new VisualAssetInfo() { FileName = "SplashScreen.scale-140.png", Width = 868, Height = 420, Margin = 0.15, Category = LogoCategories.SplashScreen },
            new VisualAssetInfo() { FileName = "SplashScreen.scale-180.png", Width = 1116, Height = 540, Margin = 0.15, Category = LogoCategories.SplashScreen }
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
