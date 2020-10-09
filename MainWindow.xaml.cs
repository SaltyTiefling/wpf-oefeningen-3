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

namespace wpf_oefeningen_3
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
        private void btnOefening1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{cbGeslacht.Text} {cbLeeftijd.Text}");
        }

        private void tbxTab1_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbxTab2.Text = tbxTab1.Text;
        }

        private void tbxTab2_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbxTab1.Text = tbxTab2.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtOefening3.Foreground == Brushes.Blue) {
                txtOefening3.Foreground = Brushes.Black;
            } else {
                txtOefening3.Foreground = Brushes.Blue;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtOefening4.Text = String.Empty;
        }

        private void txtOefening4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtOefening4.Text == "")
            {
                miClear.IsEnabled = false;
            }
            else
            {
                miClear.IsEnabled = true;
            }
        }


    }
}
