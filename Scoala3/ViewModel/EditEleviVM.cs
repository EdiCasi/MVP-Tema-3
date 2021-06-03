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
                    addCommand = new RelayCommand<Elev>(addElev);
                }
                return addCommand;
            }
        }

        private ICommand modifyCommand;
        public ICommand ModifyCommand
        {
            get
            {
                if (modifyCommand == null)
                {
                    modifyCommand = new RelayCommand<Elev>(modifyElev);
                }
                return modifyCommand;
            }
        }

        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand<Elev>(deleteElev);
                }
                return deleteCommand;
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
        public void refresh(object account)
        {
            HelperMethod.SwitchWindow(new EditElevi());
        }
        public void addElev(object elev)
        {
            if (((Elev)elev).IdClasa == "")
            {
                throw new Exception("Trebuie selectata o clasa in care sa fie elevul");
            }
            if (String.IsNullOrEmpty(((Elev)elev).Nume))
            {
                throw new Exception("Numele persoanei trebuie sa fie precizat");
            }
            ElevDAL.AddElev((Elev)elev);
        }

        public void modifyElev(object elev)
        {
            if (String.IsNullOrEmpty(((Elev)elev).IdClasa))
            {
                throw new Exception("Trebuie selectata o clasa in care sa fie elevul");
            }
            if (String.IsNullOrEmpty(((Elev)elev).Nume))
            {
                throw new Exception("Numele persoanei trebuie sa fie precizat");
            }
            if (String.IsNullOrEmpty(((Elev)elev).IdElev))
            {
                throw new Exception("Id-ul persoanei trebuie sa fie precizat");

            }
            ElevDAL.ModifyElev((Elev)elev);
        }

        public void deleteElev(object elev)
        {
            if (String.IsNullOrEmpty(((Elev)elev).IdElev))
            {
                throw new Exception("Id-ul persoanei trebuie sa fie precizat");

            }
            ElevDAL.DeleteElev((Elev)elev);
            foreach (Elev index in elevi)
            {
                if (index.IdElev == ((Elev)elev).IdElev)
                {
                    elevi.Remove(index); 
                    break; 
                }
            }
        }
        #endregion
    }
}
