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
            List<Persoon> persoons = new List<Persoon>();
            persoons.Add(new Persoon("Jonas", "Van Mullem", true));
            persoons.Add(new Persoon("Ken", "Field"));
            persoons.Add(new Persoon("Koen", "De Jans", true));
            lbPersonen.ItemsSource = persoons;
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
            if (txtOefening3.Foreground == Brushes.Blue)
            {
                txtOefening3.Foreground = Brushes.Black;
            }
            else
            {
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

        private void selectColors(object sender, RoutedEventArgs e)
        {
            List<object> colors = new List<object>();
            foreach (CheckBox box in spColors.Children.OfType<CheckBox>())
            {
                object item = new { text = box.Content, color = box.Foreground };
                if (box.IsChecked == true)
                {
                    colors.Add(item);
                }
            }
            lbColors.ItemsSource = colors;
        }
    }
}
