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
    class EditEleviVM
    {
        public EditEleviVM()
        {
            Clase = ClasaDAL.GetAllClase();
            Elevi = ElevDAL.GetAllElevi();
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

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand<Elev>(goBack);
                }
                return addCommand;
            }
        }

        #endregion

        #region Data Members

        private ObservableCollection<Clasa> clase;

        public ObservableCollection<Clasa> Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        private ObservableCollection<Elev> elevi;

        public ObservableCollection<Elev> Elevi
        {
            get { return elevi; }
            set { elevi = value; }
        }

        public void goBack(object account)
        {
            HelperMethod.SwitchWindow(new AdminWindow());
        }

        public void addElev(Elev elev)
        {
            if(elev.IdClasa==0)
            {
                throw new Exception("Trebuie selectata o clasa in care sa fie elevul");
            }
            if(String.IsNullOrEmpty(elev.Nume))
            {
                throw new Exception("Numele persoanei trebuie sa fie precizat");
            }
            ElevDAL.AddElev(elev);
        }
        #endregion
    }
}
