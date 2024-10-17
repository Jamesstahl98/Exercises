using Microsoft.Win32;
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
using System.IO;

namespace WPFDialogExercises.Views
{
    /// <summary>
    /// Interaction logic for Exercise3and4.xaml
    /// </summary>
    public partial class Exercise3and4 : Window
    {
        public Exercise3and4()
        {
            InitializeComponent();
        }

        private void Close_Window(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();

            if(result == true)
            {
                textBox.Text = File.ReadAllText(dialog.FileName);
            }
        }
    }
}
