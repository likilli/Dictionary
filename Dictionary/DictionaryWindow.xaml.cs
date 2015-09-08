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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dictionary
{
   
    public partial class DictionaryWindow : Window
    {
        DictLibrary dict = new DictLibrary();
        public DictionaryWindow()
        {
            InitializeComponent();
            MainMenuGrid.Visibility = Visibility.Visible;
            DictionaryGrid.Visibility = Visibility.Hidden;
            
        }
        private void RefreshList()
        {
            DictionaryListWords.Items.Clear();
            foreach (var item in dict.Words)
            { 
                DictionaryListWords.Items.Add(item.Word1 + " - " + item.Word2);
            }
        }
        private void DictionaryButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuGrid.Visibility = Visibility.Hidden;
            DictionaryGrid.Visibility = Visibility.Visible;
        }

        private void AddWordButton_Click(object sender, RoutedEventArgs e)
        {
            WordProperties wp = new WordProperties(dict, null);
            wp.Show();
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuGrid.Visibility = Visibility.Visible;
            DictionaryGrid.Visibility = Visibility.Hidden;

        }

        private void EditWordButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD

=======
            if (DictionaryListWords.SelectedIndex != -1)
            {
                WordProperties wp = new WordProperties(dict, DictionaryListWords.SelectedIndex);
                wp.Show();
            }
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshList();
>>>>>>> origin/master
        }
    }
}
