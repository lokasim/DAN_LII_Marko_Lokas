using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BirthdayCake.Command;
using BirthdayCake.Views;

namespace BirthdayCake.ViewModel
{
    class CreateOrderViewModel : ViewModelBase
    {
        readonly CreateOrder createOrder;

        public CreateOrderViewModel(CreateOrder createOrder)
        {
            this.createOrder = createOrder;
        }

        #region Commandes

        private ICommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }
                return save;
            }
        }

        /// <summary>
        /// Method for create order
        /// </summary>
        private void SaveExecute()
        {
        }

        private bool CanSaveExecute()
        {
            return false;

        }

        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }

        /// <summary>
        /// Exit form
        /// </summary>
        private void CloseExecute()
        {
            try
            {
                createOrder.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanCloseExecute()
        {
            return true;
        }
        #endregion
    }
}
