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
    class ElevDAL
    {
        public static ObservableCollection<Elev> GetAllElevi()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("getElevi", con);
                ObservableCollection<Elev> result = new ObservableCollection<Elev>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Elev elev = new Elev();

                    elev.Nume = reader.GetString(0);
                    elev.AnStudii = reader.GetInt32(1);
                    elev.Specializare = reader.GetString(2);
                    result.Add(elev);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }
        public static void AddElev(Elev elev)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddElev", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramNume = new SqlParameter("@name", elev.Nume);
                SqlParameter paramIdClasa = new SqlParameter("@id_clasa", elev.IdClasa);

                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramIdClasa);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
