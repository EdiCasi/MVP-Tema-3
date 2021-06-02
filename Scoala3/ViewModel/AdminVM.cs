using Scoala3.Helpers;
using Scoala3.Models;
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
                    openEditEleviCommand = new RelayCommand<Elev>(OpenEditElevi);
                }

                return openEditEleviCommand;
            }
        }

        private ICommand openEditProfesoriCommand;
        public ICommand OpenEditProfesoriCommand
        {
            get
            {
                if (openEditProfesoriCommand == null)
                {
                    openEditProfesoriCommand = new RelayCommand<Elev>(OpenEditProfesori);
                }

                return openEditProfesoriCommand;
            }
        }

        private ICommand openEditMateriiCommand;
        public ICommand OpenEditMateriiCommand
        {
            get
            {
                if (openEditMateriiCommand == null)
                {
                    openEditMateriiCommand = new RelayCommand<Elev>(OpenEditMaterii);
                }

                return openEditMateriiCommand;
            }
        }

        private ICommand goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                if (goBackCommand == null)
                {
                    goBackCommand = new RelayCommand<Elev>(goBack);
                }

                return goBackCommand;
            }
        }

        #endregion

        #region Data Members

        public void OpenEditElevi(object account)
        { 
            HelperMethod.SwitchWindow(new EditElevi());
        }
        public void OpenEditProfesori(object account)
        {
            HelperMethod.SwitchWindow(new EditProfesori());
        }
        public void OpenEditMaterii(object account)
        {
            HelperMethod.SwitchWindow(new EditMaterii());
        }
        public void goBack(object account)
        {
           
            HelperMethod.SwitchWindow(new MainWindow());
        }
        #endregion
    }
}
