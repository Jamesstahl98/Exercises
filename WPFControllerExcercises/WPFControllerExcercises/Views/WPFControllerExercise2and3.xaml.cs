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
    public partial class WPFControllerExercise2and3 : Window
    {
        int labelValue = 5;
        public WPFControllerExercise2and3()
        {
            InitializeComponent();
            incrementingLabel.Content = labelValue; 
        }

        private void increaseButton_Click(object sender, RoutedEventArgs e)
        {
            labelValue++;
            incrementingLabel.Content = labelValue;
        }

        private void decreaseButton_Click(object sender, RoutedEventArgs e)
        {
            labelValue--;
            incrementingLabel.Content = labelValue;
        }

        private void increaseSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelValue += (int)increaseSlider.Value;
            sliderValueLabel.Content = increaseSlider.Value;
            incrementingLabel.Content = labelValue;
        }
    }
}
