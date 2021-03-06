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
    class MediiVM
    {
        public MediiVM()
        {
            Medii = MaterieDAL.getMateriiNume(ElevWindowVM.ELEVLOGAT);
            Note = NotaDAL.GetAllNote(ElevWindowVM.ELEVLOGAT);
            CalculareMedii();
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

        public ObservableCollection<Medie> Medii { get; set; }
        public ObservableCollection<Nota> Note { get; set; }
        public float formulaCalcultare(float suma, float count, float teza)
        {
            if (suma == 0)
                return 0;
            if (teza != 0)
            {
                return ((suma / count) * 3 + teza) / 4;
            }
            else
            {
                return (suma / count);
            }
        }
        public void CalculareMedii()
        {
            foreach (Medie medie in Medii)
            {
                float suma = 0;
                float countNota = 0;
                float teza = 0;
                foreach (Nota nota in Note)
                {
                    if (medie.NumeMaterie.Equals(nota.NumeMaterie) && nota.isTeza != "0")
                    {
                        teza = Int32.Parse(nota.valoareNota);
                        continue;
                    }
                    if (medie.NumeMaterie.Equals(nota.NumeMaterie))
                    {
                        suma += Int32.Parse(nota.valoareNota);
                        countNota++;
                    }
                }
                float medieAritmetica = formulaCalcultare(suma, countNota, teza);

                medie.medieNumeric = medieAritmetica.ToString("0.00");
            }
        }

        public void goBack(object account)
        {
            HelperMethod.SwitchWindow(new ElevWindow());
        }
        public void refresh(object account)
        {
            HelperMethod.SwitchWindow(new Medii());
        }
        #endregion
    }
}
