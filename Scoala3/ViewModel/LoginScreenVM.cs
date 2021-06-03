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

        private ICommand logInCommand;
        public ICommand LogInCommand
        {
            get
            {
                if (logInCommand == null)
                {
                    logInCommand = new RelayCommand<Account>(Login);
                }

                return logInCommand;
            }
        }

        #endregion

        #region Data Members

        public void Login(object account)
        {
            Account readedAccount = AccountDAL.ExistAccount((Account)account);
            if(readedAccount!=null && readedAccount.acces=="administrator")
            {
                HelperMethod.SwitchWindow(new AdminWindow());
            }
            else if(readedAccount != null && readedAccount.acces == "elev")
            {
                HelperMethod.SwitchWindow(new ElevWindow());
                ElevWindowVM.ELEVLOGAT = ElevDAL.getElevFromAccount(readedAccount);
            }
        }

        #endregion

    }
}
