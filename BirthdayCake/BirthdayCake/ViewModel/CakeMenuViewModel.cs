using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirthdayCake.Models;
using BirthdayCake.Services;
using BirthdayCake.Views;

namespace BirthdayCake.ViewModel
{
    class CakeMenuViewModel : ViewModelBase
    {
        readonly CakeMenu cakeMenu;

        private tblCake allMenu;
        public tblCake AllMenu
        {
            get
            {
                return allMenu;
            }
            set
            {
                allMenu = value;
                OnPropertyChanged("AllMenu");
            }
        }

        private List<tblCake> allMenuList;
        public List<tblCake> AllMenuList
        {
            get
            {
                return allMenuList;
            }
            set
            {
                allMenuList = value;
                OnPropertyChanged("AllMenuList");
            }
        }

        public CakeMenuViewModel(CakeMenu cakeMenu)
        {
            this.cakeMenu = cakeMenu;

            Service s = new Service();

            AllMenuList = s.GetAllMenu().ToList();
        }
    }
}
