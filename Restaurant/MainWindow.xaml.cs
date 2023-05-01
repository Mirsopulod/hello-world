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

namespace Restaurant
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

        private void Submit(object sender, RoutedEventArgs e)
        {
            //button clicked
            if (RbChicken.IsChecked == true && !string.IsNullOrEmpty(TxtQuantity.Text))
            {
                try
                {
                    LbLog.Items.Add("Cooked Chicken " + Convert.ToInt32(TxtQuantity.Text));
                    TxtQuantity.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    TxtQuantity.Clear();
                }
            }
            else if (RbEgg.IsChecked == true && !string.IsNullOrEmpty(TxtQuantity.Text))
            {
                try
                {
                    LbLog.Items.Add("Cooked Egg " + Convert.ToInt32(TxtQuantity.Text));
                    TxtQuantity.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else if(RbChicken.IsChecked == false && RbEgg.IsChecked == false)
            {
                MessageBox.Show("you have not chosen.\nplease choose ");
            }
            else
            {
                MessageBox.Show("Write count of meal!");
            }
    }
    }
}