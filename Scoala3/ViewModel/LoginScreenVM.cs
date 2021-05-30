using Scoala3.DataAccesLayer;
using Scoala3.Helpers;
using Scoala3.Models;
using Scoala3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Scoala3.ViewModel
{
    class LoginScreenVM
    {
        public Account account { get; set; }

        #region Command Members

        private ICommand openWindowCommand;
        public ICommand OpenWindowCommand
        {
            get
            {
                if (openWindowCommand == null)
                {
                    openWindowCommand = new RelayCommand(OpenWindow);
                }

                return openWindowCommand;
            }
        }

        #endregion

        #region Data Members

        public void OpenWindow(object account)
        {
            Account readedAccount = AccountDAL.ExistAccount((Account)account);
            if(readedAccount!=null && readedAccount.acces=="administrator")
            {
                AdminWindow adminWindow = new AdminWindow();
                System.Windows.Application.Current.MainWindow.Close();
                App.Current.MainWindow = adminWindow;
                adminWindow.Show();
            }
        }

        #endregion

    }
}
