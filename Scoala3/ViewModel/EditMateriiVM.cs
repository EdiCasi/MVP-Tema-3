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
    class EditMateriiVM
    {
        public EditMateriiVM()
        {
            Materii = MaterieDAL.GetAllMaterii();
            Clase = ClasaDAL.GetAllClase();
            Profesori = ProfesorDAL.GetAllProfesori();
        }



        #region Command Members

        private ICommand goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                if (goBackCommand == null)
                {
                    goBackCommand = new RelayCommand<Materie>(goBack);
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
                    addCommand = new RelayCommand<Materie>(addMaterie);
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
                    modifyCommand = new RelayCommand<Materie>(modifyMaterie);
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
                    deleteCommand = new RelayCommand<Materie>(deleteMaterie);
                }
                return deleteCommand;
            }
        }
        #endregion


        #region Data Members
        public ObservableCollection<Clasa> Clase { get; set; }
        public ObservableCollection<Profesor> Profesori { get; set; }
        public ObservableCollection<Materie> Materii { get; set; }


        public void goBack(object account)
        {
            HelperMethod.SwitchWindow(new AdminWindow());
        }


        public void addMaterie(object materie)
        {
            if (String.IsNullOrEmpty(((Materie)materie).Nume))
            {
                throw new Exception("Numele persoanei trebuie sa fie precizat");
            }
            if (((Materie)materie).IdClasa == "")
            {
                throw new Exception("Trebuie selectata o clasa la care sa fie predata materia");
            }
            if (((Materie)materie).IdProfesor == "")
            {
                throw new Exception("Trebuie selectata un profesor care sa predea materia");
            }
            MaterieDAL.AddMaterie((Materie)materie);
        }

        public void modifyMaterie(object materie)
        {
            if (((Materie)materie).Id == "")
            {
                throw new Exception("Trebuie selectata o materie pentru a fi modificata");
            }
            if (String.IsNullOrEmpty(((Materie)materie).Nume))
            {
                throw new Exception("Numele persoanei trebuie sa fie precizat");
            }
            if (((Materie)materie).IdClasa == "")
            {
                throw new Exception("Trebuie selectata o clasa la care sa fie predata materia");
            }
            if (((Materie)materie).IdProfesor == "")
            {
                throw new Exception("Trebuie selectata un profesor care sa predea materia");
            }
            MaterieDAL.ModifyMaterie((Materie)materie);
        }

        public void deleteMaterie(object materie)
        {
            if (String.IsNullOrEmpty(((Materie)materie).Id))
            {
                throw new Exception("Trebuie selectata o materie!");

            }
            MaterieDAL.DeleteMaterie((Materie)materie);
            foreach (Materie index in Materii)
            {
                if (index.Id == ((Materie)materie).Id)
                {
                    Materii.Remove(index);
                    break;
                }
            }
        }


        #endregion
    }
}
