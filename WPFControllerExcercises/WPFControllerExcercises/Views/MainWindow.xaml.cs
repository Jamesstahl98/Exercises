using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFControllerExcercises.Views;
using WPFControllerExercises.Views;

namespace WPFControllerExcercises
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

        private void myButton1_Click(object sender, RoutedEventArgs e)
        {
            WPFControllerExercise1 window = new WPFControllerExercise1();
            window.Show(); 
        }

        private void myButton2_Click(object sender, RoutedEventArgs e)
        {
            WPFControllerExercise2and3 window = new WPFControllerExercise2and3();
            window.Show();
        }

        private void myButton3_Click(object sender, RoutedEventArgs e)
        {
            WPFControllerExercise4 window = new WPFControllerExercise4();
            window.Show();
        }

        private void myButton4_Click(object sender, RoutedEventArgs e)
        {
            WPFControllerExercise5 window = new WPFControllerExercise5();
            window.Show();
        }

        private void myButton5_Click(object sender, RoutedEventArgs e)
        {
            WPFControllerExercise6789 window = new WPFControllerExercise6789();
            window.Show();
        }
    }
}