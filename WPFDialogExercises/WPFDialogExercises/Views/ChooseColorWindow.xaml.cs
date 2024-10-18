using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WPFDialogExercises.Views
{
    /// <summary>
    /// Interaction logic for ChooseColorWindow.xaml
    /// </summary>
    public partial class ChooseColorWindow : Window
    {
        public SolidColorBrush? Brush { get; set; }
        private bool windowLoaded = false;
        public ChooseColorWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(!windowLoaded) { return; }
            System.Windows.Media.Color newColor;

            newColor.R = (Byte)redSlider.Value;
            newColor.G = (Byte)greenSlider.Value;
            newColor.B = (Byte)blueSlider.Value;

            Brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, newColor.R, newColor.G, newColor.B));
            colorRectangle.Fill = Brush;
        }

        private void CloseButton_Clicked(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void OKButton_Clicked(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Brush == null)
            {
                Brush = new SolidColorBrush(Colors.Black);
            }
            colorRectangle.Fill = Brush;
            redSlider.Value = Brush.Color.R;
            greenSlider.Value = Brush.Color.G;
            blueSlider.Value = Brush.Color.B;
            windowLoaded = true;
        }
    }
}
