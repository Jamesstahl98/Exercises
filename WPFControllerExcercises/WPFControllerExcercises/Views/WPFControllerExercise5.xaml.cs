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
    public partial class WPFControllerExercise5 : Window
    {
        public WPFControllerExercise5()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            xPositionLabel.Content = $"X-Position: {(int)xSlider.Value}";
            yPositionLabel.Content = $"Y-Position: {(int)ySlider.Value}";

            movingLabel.Content = string.Empty;
            Thickness margin = movingLabel.Margin;
            if (lockXCheckBox.IsChecked == false)
            {
                movingLabel.Content += $"X:{(int)xSlider.Value},";
                margin.Left = xSlider.Value;
            }
            else
            {
                movingLabel.Content += $"X:{(int)margin.Left},";
            }

            if (lockYCheckBox.IsChecked == false)
            {
                movingLabel.Content += $"Y:{(int)ySlider.Value}";
                margin.Top = ySlider.Value;
            }
            else
            {
                movingLabel.Content += $"Y:{(int)margin.Top}";
            }
            movingLabel.Margin = margin;
        }

        private void LockCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdatePosition();
        }
    }
}
