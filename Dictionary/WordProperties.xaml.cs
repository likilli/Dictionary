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

namespace Dictionary
{
    /// <summary>
    /// Interaction logic for WordProperties.xaml
    /// </summary>
    public partial class WordProperties : Window
    {
        int? index;
        DictLibrary dict;
        public WordProperties(DictLibrary d, int? index)
        {
            InitializeComponent();
            dict = d;
            this.index = index;
            if(index != null)
            {
                
                WordOneTextBox.Text = d.Find((int)(index)).Word1;
                WordTwoTextBox.Text = d.Find((int)(index)).Word2;
            }
        }
        // Save
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (index == null)
            {
                dict.AddWord(WordOneTextBox.Text, WordTwoTextBox.Text);

            }
            else
            {
                dict.Find((int)(index)).Word1 = WordOneTextBox.Text;
                dict.Find((int)(index)).Word2 = WordTwoTextBox.Text;
            }
        }

       
    }
}
