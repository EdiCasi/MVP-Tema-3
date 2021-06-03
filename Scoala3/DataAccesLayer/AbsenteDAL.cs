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
    class AbsenteDAL
    {
        public static ObservableCollection<Absenta> GetAllAbsente(Elev elev)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                ObservableCollection<Absenta> result = new ObservableCollection<Absenta>();

                SqlCommand cmd = new SqlCommand("getAbsente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdElev = new SqlParameter("@idElev", elev.IdElev);

                cmd.Parameters.Add(paramIdElev);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Absenta absenta = new Absenta();

                    absenta.IdAbsenta = reader.GetInt32(0).ToString();
                    absenta.NumeMaterie = reader.GetString(1);
                    absenta.Semestru = reader.GetInt32(2).ToString();

                    result.Add(absenta);
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
