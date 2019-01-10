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

namespace FirstAppWPF
{
    public partial class MainWindow : Window
    {
        bool Xturn = true;

        public MainWindow()
        {
            InitializeComponent(); 
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            try
            {
                if (Xturn == true)
                {
                    button.Content = "X";
                    int countX = 0;
                    countX++;
                }
                else
                {
                    button.Content = "O";
                    int countO = 0;
                    countO++;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Xturn = !Xturn;
            button.IsEnabled = false;
            Game(button);
        }
        public void Game(Button Content_Button)
        {
            if (Button_1.Content == Button_2.Content && Button_2.Content == Button_3.Content && Button_3.IsEnabled == false)
            {
                MessageBox.Show("Win: "+Content_Button.Content);
            }
            if (Button_4.Content == Button_5.Content && Button_5.Content == Button_6.Content && Button_6.IsEnabled == false)
            {
                MessageBox.Show("Win: " + Content_Button.Content);
            }
            if (Button_7.Content == Button_8.Content && Button_8.Content == Button_9.Content && Button_9.IsEnabled == false)
            {
                MessageBox.Show("Win: " + Content_Button.Content);
            }


            if (Button_1.Content == Button_4.Content && Button_4.Content == Button_7.Content && Button_7.IsEnabled == false)
            {
                MessageBox.Show("Win: " + Content_Button.Content);
            }
            if (Button_2.Content == Button_5.Content && Button_5.Content == Button_8.Content && Button_8.IsEnabled == false)
            {
                MessageBox.Show("Win: " + Content_Button.Content);
            }
            if (Button_3.Content == Button_6.Content && Button_6.Content == Button_9.Content && Button_9.IsEnabled == false)
            {
                MessageBox.Show("Win: " + Content_Button.Content);
            }


            if (Button_1.Content == Button_5.Content && Button_5.Content == Button_9.Content && Button_9.IsEnabled == false)
            {
                MessageBox.Show("Win: " + Content_Button.Content);
            }
            if (Button_3.Content == Button_5.Content && Button_5.Content == Button_7.Content && Button_7.IsEnabled == false)
            {
                MessageBox.Show("Win: " + Content_Button.Content);
            }
        }
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Exet_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            Xturn = true;
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            Xturn = false;
        }
    }
}
