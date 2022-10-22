using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for splash.xaml
    /// </summary>
    public partial class splash : Window
    {
        public splash()
        {
            InitializeComponent();
        }

        private async void ManeSplash_Loaded(object sender, RoutedEventArgs e)
        {
            Boolean splash = true;
            if (splash == true)
            {
                while (true)
                {
                    if (LoadingBar.Value == 100)
                    {
                        MainWindow CheatWindow = new MainWindow();
                        MyMainLabel.Content = "Project status: Loading files...";
                        await Task.Delay(3000);
                        CheatWindow.Show();
                        ManeSplash.Close();
                        break;
                    }
                    else
                    {
                        if (MyMainLabel.Content == "Project status: Starting Up.")
                        {
                            MyMainLabel.Content = "Project status: Starting Up..";
                        }
                        else if (MyMainLabel.Content == "Project status: Starting Up..")
                        {
                            MyMainLabel.Content = "Project status: Starting Up...";
                        }
                        else
                        {
                            MyMainLabel.Content = "Project status: Starting Up.";
                        }
                        LoadingBar.Value = LoadingBar.Value + 1;
                        await Task.Delay(50);
                    }
                }
            }
            else {
                MainWindow CheatWindow = new MainWindow();
                CheatWindow.Show();
                ManeSplash.Close();
            }
        }
    }
}
