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
    class ElevWindowVM
    {
        #region Command Members

        private ICommand openNoteCommand;
        public ICommand OpenNoteCommand
        {
            get
            {
                if (openNoteCommand == null)
                {
                    openNoteCommand = new RelayCommand<Elev>(OpenNote);
                }

                return openNoteCommand;
            }
        }

        private ICommand openAbsenteCommand;
        public ICommand OpenAbsenteCommand
        {
            get
            {
                if (openAbsenteCommand == null)
                {
                    openAbsenteCommand = new RelayCommand<Elev>(OpenAbsente);
                }

                return openAbsenteCommand;
            }
        }

        private ICommand openMediiCommand;
        public ICommand OpenMediiCommand
        {
            get
            {
                if (openMediiCommand == null)
                {
                    openMediiCommand = new RelayCommand<Elev>(OpenMedii);
                }

                return openMediiCommand;
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


        public static Elev ELEVLOGAT { get; set; }


        public void OpenNote(object account)
        {
            HelperMethod.SwitchWindow(new Note());
        }
        public void OpenAbsente(object account)
        {
            HelperMethod.SwitchWindow(new Absente());
        }
        public void OpenMedii(object account)
        {
            HelperMethod.SwitchWindow(new Medii());
        }
        public void goBack(object account)
        {

            HelperMethod.SwitchWindow(new MainWindow());
        }
        #endregion
    }
}
