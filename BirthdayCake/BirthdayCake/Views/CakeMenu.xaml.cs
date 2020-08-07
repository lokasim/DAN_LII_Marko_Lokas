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
using System.Windows.Threading;

namespace BirthdayCake.Views
{
    /// <summary>
    /// Interaction logic for CakeMenu.xaml
    /// </summary>
    public partial class CakeMenu : Window
    {
        public CakeMenu()
        {
            InitializeComponent();

            Time();
        }

        private void DragMe(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void Time()
        {
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Dogadjaj;
            timer.Start();
        }

        /// <summary>
        /// method for printing the current time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dogadjaj(object sender, EventArgs e)
        {
            vr.Text = DateTime.Now.ToString(@"HH:mm:ss");
        }

        /// <summary>
        /// method for the application user to log out, 
        /// after which a new login form is displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.ShowDialog();
        }

        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dijalog = Xceed.Wpf.Toolkit.MessageBox.Show("Do you want to leave the program", "Exit app", MessageBoxButton.YesNo);

            if (dijalog == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        /// <summary>
        /// Window enlargement method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Povecaj_prozor(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                PovecajProzor.ToolTip = "Restore Down";
                PovecajProzor1.Visibility = Visibility.Visible;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                PovecajProzor.ToolTip = "Maximize";
                PovecajProzor1.Visibility = Visibility.Collapsed;
            }
        }

        /// <summary>
        /// Window reduction method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spusti_prozor(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
            else if (this.WindowState == WindowState.Minimized)
            {
                this.WindowState = WindowState.Normal;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Minimized;
            }
        }
    }
}
