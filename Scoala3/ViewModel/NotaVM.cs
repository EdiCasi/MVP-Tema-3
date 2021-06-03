using Scoala3.DataAccesLayer;
using Scoala3.Helpers;
using Scoala3.Models;
using Scoala3.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Scoala3.ViewModel
{
    class NotaVM
    {
        public NotaVM()
        {
            Note = NotaDAL.GetAllNote(ElevWindowVM.ELEVLOGAT);
        }


        #region Command Members

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

        private ICommand refreshCommand;
        public ICommand RefreshCommand
        {
            get
            {
                if (refreshCommand == null)
                {
                    refreshCommand = new RelayCommand<Materie>(refresh);
                }

                return refreshCommand;
            }
        }
        #endregion 

        #region Data members

        public ObservableCollection<Nota> Note { get; set; }

        public void goBack(object account)
        {
            HelperMethod.SwitchWindow(new ElevWindow());
        }
        public void refresh(object account)
        {
            HelperMethod.SwitchWindow(new Note());
        }
        #endregion
    }
}
