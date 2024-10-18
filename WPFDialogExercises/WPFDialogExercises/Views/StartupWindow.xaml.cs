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

namespace WPFDialogExercises.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class StartupWindow : Window
    {
        public StartupWindow()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, RoutedEventArgs e)
        {
            Exercise1and2 window = new Exercise1and2();
            window.Show();
        }

        private void myButton2_Click(object sender, RoutedEventArgs e)
        {
            Exercise3and4 window = new Exercise3and4();
            window.Show();
        }

        private void myButton3_Click(object sender, RoutedEventArgs e)
        {
            Exercise5to7 window = new Exercise5to7();
            window.Show();
        }
    }
}
