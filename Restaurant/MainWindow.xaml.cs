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

namespace Restaurant{

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
            if (!string.IsNullOrEmpty(TxtQuantity.Text))
            {
                if (RbChicken.IsChecked == true)
                {
                    try
                    {
                        List<Egg> eggs = new List<Egg>();
                        for (int i = 0; i < Convert.ToInt32(TxtQuantity.Text); i++)
                        {
                            eggs.Add(new Egg());
                            while (eggs[i].Crack()<30)
                            {
                                eggs[i].Crack();
                            }
                            eggs[i].Cook();
                        }

                        LbLog.Items.Add("coocked " + TxtQuantity.Text + " eggs");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else if (RbEgg.IsChecked == true)
                {
                    try
                    {
                        List<Chicken> chickens = new List<Chicken>();
                        for (int i = 0; i < Convert.ToInt32(TxtQuantity.Text); i++)
                        {
                            chickens.Add(new Chicken());
                            chickens[i].CutUp();
                            chickens[i].Cook();
                        }

                        LbLog.Items.Add("coocked " + TxtQuantity.Text + " chickens");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("you have not chosen.\nplease choose ");
                }
            }
            else
            {
                MessageBox.Show("Write count of meal!");
            }
            TxtQuantity.Clear();
    }
    }
}
