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
    class EditProfesoriVM
    {
        public EditProfesoriVM()
        {
            profesori = ProfesorDAL.GetAllProfesori();
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

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand<Elev>(addProfesor);
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
                    modifyCommand = new RelayCommand<Elev>(modifyProfesor);
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
                    deleteCommand = new RelayCommand<Elev>(deleteProfesor);
                }
                return deleteCommand;
            }
        }

        #endregion

        #region Data Members

        private ObservableCollection<Profesor> profesori;

        public ObservableCollection<Profesor> Profesori
        {
            get { return profesori; }
            set { profesori = value; }
        }

        public void goBack(object account)
        {
            HelperMethod.SwitchWindow(new AdminWindow());
        }

        public void refresh(object account)
        {
            HelperMethod.SwitchWindow(new EditProfesori());
        }

        public void addProfesor(object profesor)
        {
            if (((Profesor)profesor).Nume == "")
            {
                throw new Exception("Numele profesorului trebuie sa fie precizat");
            }
            if (String.IsNullOrEmpty(((Profesor)profesor).Specializare))
            {
                throw new Exception("Specializarea profesorului trebuie sa fie precizat");
            }
            if (String.IsNullOrEmpty(((Profesor)profesor).isDiriginte))
            {
                throw new Exception("Specificati daca profesorul este diriginte");
            }
            ProfesorDAL.AddProfesor((Profesor)profesor);
        }

        public void modifyProfesor(object profesor)
        {
            if (String.IsNullOrEmpty(((Profesor)profesor).Id))
            {
                throw new Exception("Trebuie selectat un profesor, prima data");
            }
            if (String.IsNullOrEmpty(((Profesor)profesor).Nume))
            {
                throw new Exception("Numele profesorului trebuie sa fie precizat");
            }
            if (String.IsNullOrEmpty(((Profesor)profesor).Specializare))
            {
                throw new Exception("Specializarea profesorului trebuie precizata");
            }
            if (String.IsNullOrEmpty(((Profesor)profesor).isDiriginte))
            {
                throw new Exception("Specificati daca profesorul este sau nu diriginte");
            }

            ProfesorDAL.ModifyProfesor((Profesor)profesor);
        }

        public void deleteProfesor(object profesor)
        {
            if (String.IsNullOrEmpty(((Profesor)profesor).Id))
            {
                throw new Exception("Id-ul profesorului trebuie trebuie sa fie precizat");
            }

            ProfesorDAL.DeleteProfesor((Profesor)profesor);

            foreach (Profesor index in profesori)
            {
                if (index.Id == ((Profesor)profesor).Id)
                {
                    profesori.Remove(index);
                    break;
                }
            }
        }

        #endregion
    }
}
