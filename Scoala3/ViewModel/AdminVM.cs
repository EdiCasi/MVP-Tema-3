using Scoala3.Helpers;
using Scoala3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Scoala3.ViewModel
{
    class AdminVM
    {
        #region Command Members

        private ICommand openEditEleviCommand;
        public ICommand OpenEditEleviCommand
        {
            get
            {
                if (openEditEleviCommand == null)
                {
                    openEditEleviCommand = new RelayCommand(OpenEditElevi);
                }

                return openEditEleviCommand;
            }
        }

        private ICommand goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                if (goBackCommand == null)
                {
                    goBackCommand = new RelayCommand(goBack);
                }

                return goBackCommand;
            }
        }

        #endregion

        #region Data Members

        public void OpenEditElevi(object account)
        {
            EditElevi editElevi = new EditElevi();
            System.Windows.Application.Current.MainWindow.Close();
            App.Current.MainWindow = editElevi;
            editElevi.Show();
        }

        public void goBack(object account)
        {
            MainWindow main = new MainWindow();
            System.Windows.Application.Current.MainWindow.Close();
            App.Current.MainWindow = main;
            main.Show();
        }
        #endregion
    }
}
