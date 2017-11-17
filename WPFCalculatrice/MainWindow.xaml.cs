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

namespace WPFCalculatrice
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxN(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double dblNb1;
            double dblNb2;
            double dblRes;

            if(double.TryParse(tbxNumber1.Text, out dblNb1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNb2))
                {
                    dblRes = dblNb1 + dblNb2;
                    lblResponse.Content = dblRes.ToString();
                }
                else
                {
                    MessageBox.Show("Please control input..");
                }
            }
            else
            {
                MessageBox.Show("Please control input..");
            }
            


            
        }

        private void btnSous_Click(object sender, RoutedEventArgs e)
        {
            double dblNb1;
            double dblNb2;
            double dblRes;

            if (double.TryParse(tbxNumber1.Text, out dblNb1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNb2))
                {
                    dblRes = dblNb1 - dblNb2;
                    lblResponse.Content = dblRes.ToString();
                }
                else
                {
                    MessageBox.Show("Please control input..");
                }
            }
            else
            {
                MessageBox.Show("Please control input..");
            }
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            double dblNb1;
            double dblNb2;
            double dblRes;

            if (double.TryParse(tbxNumber1.Text, out dblNb1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNb2))
                {
                    dblRes = dblNb1 * dblNb2;
                    lblResponse.Content = dblRes.ToString();
                }
                else
                {
                    MessageBox.Show("Please control input..");
                }
            }
            else
            {
                MessageBox.Show("Please control input..");
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            double dblNb1;
            double dblNb2;
            double dblRes;

            if (double.TryParse(tbxNumber1.Text, out dblNb1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNb2))
                {
                    dblRes = dblNb1 / dblNb2;
                    lblResponse.Content = dblRes.ToString();
                }
                else
                {
                    MessageBox.Show("Please control input..");
                }
            }
            else
            {
                MessageBox.Show("Please control input..");
            }
        }
    }
}
