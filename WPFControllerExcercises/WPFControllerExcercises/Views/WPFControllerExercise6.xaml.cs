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

namespace WPFControllerExercises.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WPFControllerExercise6 : Window
    {
        public WPFControllerExercise6()
        {
            InitializeComponent();
            for (int i = 0; i < studentListBox.Items.Count; i++)
            {
                ListBoxItem item = (ListBoxItem)studentListBox.Items.GetItemAt(i);
                string[] fullNameString = item.Content.ToString().Split(' ');
                CustomProperties.SetFirstName(item, fullNameString[0]);
                CustomProperties.SetLastName(item, fullNameString[1]);
                CustomProperties.SetEmail(item, $"{fullNameString[0].Substring(0,3).ToLower()}" +
                    $".{fullNameString[1].Substring(0, 3).ToLower()}@studentmail.com");
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            firstNameTextBox.Text = CustomProperties.GetFirstName((ListBoxItem)studentListBox.SelectedItem);
            lastNameTextBox.Text = CustomProperties.GetLastName((ListBoxItem)studentListBox.SelectedItem);
            emailTextBox.Text = CustomProperties.GetEmail((ListBoxItem)studentListBox.SelectedItem);
        }

        private void firstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListBoxItem selectedItem = (studentListBox.SelectedItem as ListBoxItem);
            CustomProperties.SetFirstName(selectedItem, firstNameTextBox.Text);
            selectedItem.Content = $"{CustomProperties.GetFirstName(selectedItem)} {CustomProperties.GetLastName(selectedItem)}";
        }

        private void lastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListBoxItem selectedItem = (studentListBox.SelectedItem as ListBoxItem);
            CustomProperties.SetLastName(selectedItem, lastNameTextBox.Text);
            selectedItem.Content = $"{CustomProperties.GetFirstName(selectedItem)} {CustomProperties.GetLastName(selectedItem)}";
        }

        private void emailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListBoxItem selectedItem = (studentListBox.SelectedItem as ListBoxItem);
            CustomProperties.SetEmail(selectedItem, emailTextBox.Text);
        }
    }
}
