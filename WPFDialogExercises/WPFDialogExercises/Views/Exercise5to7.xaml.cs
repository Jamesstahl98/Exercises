using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WPFDialogExercises.UserControls;

namespace WPFDialogExercises.Views
{
    /// <summary>
    /// Interaction logic for Exercise5to7.xaml
    /// </summary>
    public partial class Exercise5to7 : Window
    {
        private PaletteRectangle? selectedRectangle;
        public Exercise5to7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChooseColorWindow window = new();
            window.Brush = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            var result = window.ShowDialog();

            if(result == true)
            {
                Debug.WriteLine("true");
            }
        }

        private void Palette_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ChooseColorWindow window = new();
            
            window.Brush = new SolidColorBrush(((e.Source as PaletteRectangle).Rectangle.Fill as SolidColorBrush).Color);
            var result = window.ShowDialog();

            if(result == true)
            {
                (e.Source as PaletteRectangle).Rectangle.Fill = window.Brush;
                for (int i = 0; i < (e.Source as PaletteRectangle).LinkedGridRectangles.Count; i++)
                {
                    (e.Source as PaletteRectangle).LinkedGridRectangles[i].Rectangle.Fill = window.Brush;
                }
            }
        }

        private void Palette_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DeselectRectangle();
            selectedRectangle = (e.Source as PaletteRectangle);
            selectedRectangle.Rectangle.StrokeThickness = 5;
        }

        private void DeselectRectangle()
        {
            if(selectedRectangle != null)
            {
                selectedRectangle.Rectangle.StrokeThickness = 0;
                selectedRectangle = null;
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(selectedRectangle == null) { return; }
            if((e.Source as GridRectangle).LinkedPaletteRectangle != null)
            {
                (e.Source as GridRectangle).LinkedPaletteRectangle.LinkedGridRectangles.Remove((e.Source as GridRectangle));
            }
            (e.Source as GridRectangle).LinkedPaletteRectangle = selectedRectangle;
            selectedRectangle.LinkedGridRectangles.Add((e.Source as GridRectangle));
            (e.Source as GridRectangle).Rectangle.Fill = selectedRectangle.Rectangle.Fill;
        }
    }
}
