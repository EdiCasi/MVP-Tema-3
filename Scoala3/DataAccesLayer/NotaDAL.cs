using Scoala3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala3.DataAccesLayer
{
    class NotaDAL
    {
        public static ObservableCollection<Nota> GetAllNote(Elev elev)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                ObservableCollection<Nota> result = new ObservableCollection<Nota>();

                SqlCommand cmd = new SqlCommand("getNote", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdElev = new SqlParameter("@idElev", elev.IdElev);

                cmd.Parameters.Add(paramIdElev);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Nota nota = new Nota();

                    nota.IdNota = reader.GetInt32(0).ToString();
                    nota.NumeMaterie = reader.GetString(1);
                    nota.isTeza = reader.GetInt32(2).ToString();
                    nota.Semestru = reader.GetInt32(3).ToString();
                    nota.valoareNota = reader.GetInt32(4).ToString();

                    result.Add(nota);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
