using Exchange_App.Model;
using Exchange_App.Tools;
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
using Image = Exchange_App.Model.Image;

namespace Exchange_App.CustomUserControls
{
    /// <summary>
    /// Interaction logic for PreviewImageUC.xaml
    /// </summary>
    public partial class PreviewImageUC : UserControl
    {
        public static readonly DependencyProperty PreviewImageProperty =
DependencyProperty.Register("ImageData", typeof(ICollection<Image>),
typeof(PreviewImageUC), new FrameworkPropertyMetadata(string.Empty));

        public PreviewImageUC()
        {
            InitializeComponent();
        }

    
        public BitmapImage PreviewImage
        {
            get
            {
                ICollection<Image> images = (ICollection<Image>)GetValue(PreviewImageProperty);
                Image firstImage = images.First();
                return firstImage.ImageBitmap;
            }
            set { SetValue(PreviewImageProperty, value); }
        }

    }
}
