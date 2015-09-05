using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace VisualAssetsGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BrowseInputGraphicsButtonOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.DefaultExt = ".svg";
                openFileDialog.Filter = "Scalable Vector Graphics (*.svg)|*.svg";
                if (openFileDialog.ShowDialog().GetValueOrDefault())
                {
                    this.inputGraphicsTextBox.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void BrowseInputImageButtonOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.DefaultExt = ".png";
                openFileDialog.Filter = "Portable Network Graphics (*.png)|*.png";
                if (openFileDialog.ShowDialog().GetValueOrDefault())
                {
                    this.inputImageTextBox.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void BrowseOutputFolderButtonOnClick(object sender, RoutedEventArgs e)
        {

            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Logo.png";
                saveFileDialog.DefaultExt = ".png";
                saveFileDialog.Filter = "Portable Network Graphics (*.png)|*.png";
                if (saveFileDialog.ShowDialog().GetValueOrDefault())
                {
                    var fileName = saveFileDialog.FileName;
                    this.outputFolderTextBox.Text = System.IO.Path.GetDirectoryName(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void GenerateButtonClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.outputFolderTextBox.Text))
            {
                MessageBox.Show("Please, specify output folder.", "Visual Assets Generator");
                return;
            }

            try
            {
                var sources = new List<IAssetImageSource>();
                if (!string.IsNullOrEmpty(this.inputImageTextBox.Text))
                {
                    sources.Add(new PngImageSource(this.inputImageTextBox.Text));
                }

                if (!string.IsNullOrEmpty(this.inputGraphicsTextBox.Text))
                {
                    sources.Add(new SvgImageSource(this.inputGraphicsTextBox.Text));
                }

                VisualAssetsConverter converter;
                if (this.windows8RadioButton.IsChecked.GetValueOrDefault())
                {
                    converter = new VisualAssetsConverter8();
                }
                else
                {
                    converter = new VisualAssetsConverter10();
                }

                converter.Convert(sources, this.outputFolderTextBox.Text, this.GetCategories());

                MessageBox.Show("Visual assets generated successfully.", "Visual Assets Generator");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private List<VisualAssetCategoryInfo> GetCategories()
        {
            var categories = new List<VisualAssetCategoryInfo>();
            this.AddCategory(categories, LogoCategories.SmallLogo, categorySmallLogoCheckBox, categorySmallLogoMarginTextBox);
            this.AddCategory(categories, LogoCategories.Logo, categoryLogoCheckBox, categoryLogoMarginTextBox);
            this.AddCategory(categories, LogoCategories.WideLogo, categoryWideLogoCheckBox, categoryWideLogoMarginTextBox);
            this.AddCategory(categories, LogoCategories.BigLogo, categoryBigLogoCheckBox, categoryBigLogoMarginTextBox);
            this.AddCategory(categories, LogoCategories.Icon, categoryIconCheckBox, categoryIconMarginTextBox);
            this.AddCategory(categories, LogoCategories.StoreLogo, categoryStoreLogoCheckBox, categoryStoreLogoMarginTextBox);
            this.AddCategory(categories, LogoCategories.Badge, categoryBadgeCheckBox, categoryBadgeMarginTextBox);
            this.AddCategory(categories, LogoCategories.SplashScreen, categorySplashScreenCheckBox, categorySplashScreenMarginTextBox);
            return categories;
        }

        private VisualAssetCategoryInfo AddCategory(List<VisualAssetCategoryInfo> categories, string name, CheckBox checkbox, TextBox marginTextBox)
        {
            if (checkbox.IsChecked.GetValueOrDefault())
            {
                var result = new VisualAssetCategoryInfo() { Name = name };
                double margin = 0;
                if (double.TryParse(marginTextBox.Text, out margin))
                {
                    result.Margin = margin / 100.0;
                }
                else
                {
                    marginTextBox.Text = "0";
                }

                categories.Add(result);
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
