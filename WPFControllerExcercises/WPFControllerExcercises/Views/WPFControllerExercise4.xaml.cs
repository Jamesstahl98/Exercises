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
using System.Windows.Shapes;

namespace WPFControllerExcercises.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WPFControllerExercise4 : Window
    {
        public WPFControllerExercise4()
        {
            InitializeComponent();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            xPositionLabel.Content = $"X-Position: {(int)xSlider.Value}";
            yPositionLabel.Content = $"Y-Position: {(int)ySlider.Value}";

            movingLabel.Content = $"X:{(int)xSlider.Value},Y:{(int)ySlider.Value}";

            Thickness margin = movingLabel.Margin;
            margin.Left = xSlider.Value;
            margin.Top = ySlider.Value;
            movingLabel.Margin = margin;
        }
    }
}
