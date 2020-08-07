using BirthdayCake.Command;
using BirthdayCake.Models;
using BirthdayCake.Services;
using BirthdayCake.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BirthdayCake.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        readonly MainWindow mainWindow;

        #region Properties
        private List<tblGuest> guestList;
        public List<tblGuest> GuestList
        {
            get
            {
                return guestList;
            }
            set
            {
                guestList = value;
                OnPropertyChanged("GuestList");
            }
        }

        private tblGuest guest;
        public tblGuest Guest
        {
            get
            {
                return guest;
            }
            set
            {
                guest = value;
                OnPropertyChanged("Guest");
            }
        }
        private bool isUpdateGuest;
        public bool IsUpdateGuest
        {
            get
            {
                return isUpdateGuest;
            }
            set
            {
                isUpdateGuest = value;
            }
        }
        #endregion

        public MainWindowViewModel(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            guest = new tblGuest();
        }

        private ICommand exit;
        public ICommand Exit
        {
            get
            {
                if (exit == null)
                {
                    exit = new RelayCommand(param => ExitExecute(), param => CanExitExecute());
                }
                return exit;
            }
        }

        /// <summary>
        /// Exit application
        /// </summary>
        private void ExitExecute()
        {
            MessageBoxResult dialog = Xceed.Wpf.Toolkit.MessageBox.Show("Da li želite napustiti aplikaciju?", "Izlaz", MessageBoxButton.YesNo);

            if (dialog == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private bool CanExitExecute()
        {
            return true;
        }

        private ICommand login;
        public ICommand Login
        {
            get
            {
                if (login == null)
                {
                    login = new RelayCommand(param => LoginExecute(), param => CanLoginExecute());
                }
                return login;
            }
        }

        /// <summary>
        /// Method for login user
        /// </summary>
        private void LoginExecute()
        {
            string username = mainWindow.NameTextBox.Text;

            // Hash password
            var hasher = new SHA256Managed();
            var unhashed = Encoding.Unicode.GetBytes(mainWindow.passwordBox.Password);
            var hashed = hasher.ComputeHash(unhashed);
            var hashedPassword = Convert.ToBase64String(hashed);

            string password = hashedPassword;

            Service s = new Service();

            //Checks if there is a username and password in the database
            tblGuest userLogin = s.GetUsernamePassword(username, password);

            if (userLogin != null)
            {
                PrintMessage();

                CakeMenu cakeMenu = new CakeMenu
                {
                    Owner = mainWindow
                };
                mainWindow.Hide();
                cakeMenu.ShowDialog();
            }
            else
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("Korisničko ime ili lozinka nisu ispravni,\n pokušajte opet.", "Nalog nije pronađen.");
            }
        }

        async void PrintMessage()
        {
            await Task.Delay(1000);
            Xceed.Wpf.Toolkit.MessageBox.Show($"Spremili smo Vam nešto slatko, uživajte ;)", "L-Cake");

        }

        private bool CanLoginExecute()
        {
            return true;
        }

        private ICommand backToLogin;
        public ICommand BackToLogin
        {
            get
            {
                if (backToLogin == null)
                {
                    backToLogin = new RelayCommand(param => BackLoginExecute(), param => CanBackLoginExecute());
                }
                return backToLogin;
            }
        }

        //Return to the login page
        private void BackLoginExecute()
        {
            mainWindow.NameTextBox.Text = "";
            mainWindow.passwordBox.Password = "";
            mainWindow.login.Visibility = Visibility.Visible;
            mainWindow.Images0.Visibility = Visibility.Collapsed;
            mainWindow.Images1.Visibility = Visibility.Visible;
            mainWindow.SignUp.Visibility = Visibility.Collapsed;
            mainWindow.NameTextBox.Focus();
            mainWindow.txtKorisnickoIme.Text = "";
            mainWindow.txtLozinkaRegistracija.Text = "";
            mainWindow.txtReLozinkaRegistracija.Text = "";

            return;
        }
        private bool CanBackLoginExecute()
        {
            return true;
        }

        private ICommand signUp;
        public ICommand SignUp
        {
            get
            {
                if (signUp == null)
                {
                    signUp = new RelayCommand(param => SignUpExecute(), param => CanSignUpExecute());
                }
                return signUp;
            }
        }
        //Create new user
        private void SignUpExecute()
        {
            try
            {
                Service s = new Service();

                string user = this.Guest.GuestUsername;
                string phoneNumber = this.Guest.PhoneNumber;

                //uniqueness check username
                tblGuest User = s.GetUsername(user);

                if (User != null)
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Korisničko ime već postoji u bazi, pokušajte sa drugim.", "Korisničko ime");
                    return;
                }

                //uniqueness check phonenumber
                tblGuest PhoneNumber = s.GetPhoneNumber(phoneNumber);

                if (PhoneNumber != null)
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Broj telefona već neko koristi, pokušajte sa drugim.", "Korisničko ime");
                    return;
                }

                string password = this.Guest.GuestPassword;
                // Hash Password
                var hasher = new SHA256Managed();
                var unhashed = Encoding.Unicode.GetBytes(this.Guest.GuestPassword);
                var hashed = hasher.ComputeHash(unhashed);
                var hashedPassword = Convert.ToBase64String(hashed);

                this.Guest.GuestPassword = hashedPassword;

                s.AddUser(this.Guest);
                IsUpdateGuest = true;

                string poruka = this.Guest.GuestNameSurname + "\nHvala Vam što ste nam uakzali poverenje.";
                Xceed.Wpf.Toolkit.MessageBox.Show(poruka, "Dobrodošli u L-Cake", MessageBoxButton.OK);

                mainWindow.NameTextBox.Text = "";
                mainWindow.txtAddress.Text = "";
                mainWindow.txtIme.Text = "";
                mainWindow.txtPhoneNumber.Text = "";
                mainWindow.passwordBox.Password = "";
                mainWindow.txtKorisnickoIme.Text = "";
                mainWindow.txtLozinkaRegistracija.Text = "";
                mainWindow.txtReLozinkaRegistracija.Text = "";
                mainWindow.login.Visibility = Visibility.Visible;
                mainWindow.Images0.Visibility = Visibility.Collapsed;
                mainWindow.Images1.Visibility = Visibility.Visible;
                mainWindow.SignUp.Visibility = Visibility.Collapsed;
                mainWindow.NameTextBox.Focus();
            }
            catch (Exception ex)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(ex.ToString());
            }
        }

        private bool CanSignUpExecute()
        {
            if (String.IsNullOrEmpty(guest.GuestUsername) ||
                String.IsNullOrEmpty(guest.GuestPassword))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
