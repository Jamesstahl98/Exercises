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
        bool existingFileOpen = false;
        bool textChanged = false;
        string openFile = string.Empty;

        public Exercise3and4()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            bool? result = dialog.ShowDialog();

            if(result == true)
            {
                existingFileOpen = true;
                openFile = dialog.FileName;
                textBox.Text = File.ReadAllText(dialog.FileName);
                Title = dialog.SafeFileName;
            }
        }

        private void NewFile(object sender, RoutedEventArgs e)
        {
            if(textChanged)
            {
                var messageBox = (MessageBox.Show("Save open file?",
                    "Unsaved Changes",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Question));
                switch(messageBox)
                {
                    case MessageBoxResult.Yes:
                        Save(sender, e);
                        break;
                    case MessageBoxResult.No:
                        existingFileOpen = false;
                        textChanged = false;
                        Title = "Untitled Document";
                        textBox.Text = string.Empty;
                        break;
                    case MessageBoxResult.Cancel:
                        return;
                }
            }
            textChanged = false;
            existingFileOpen = false;
            textBox.Text = string.Empty;
            Title = "Untitled Document";
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if(!existingFileOpen)
            {
                SaveAs(sender, e);
                return;
            }
            File.WriteAllText(openFile, textBox.Text);
            textChanged = false;
        }

        private void SaveAs(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = openFile;
            bool? result = dialog.ShowDialog();

            if(result == true)
            {
                File.WriteAllText(dialog.FileName, textBox.Text);
                Title = dialog.SafeFileName;
                textChanged = false;
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textChanged = true;
            if (!Title.EndsWith('*'))
            {
                Title += '*';
            }
        }
    }
}
