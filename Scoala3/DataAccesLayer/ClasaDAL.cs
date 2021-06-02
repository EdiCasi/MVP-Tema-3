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
    class ClasaDAL
    {
        public static ObservableCollection<Clasa> GetAllClase()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("getClase", con);
                ObservableCollection<Clasa> result = new ObservableCollection<Clasa>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Clasa clasa = new Clasa();

                    clasa.Id = reader.GetInt32(0);
                    clasa.NumeClasa = reader.GetString(1);
                    clasa.Specializare = reader.GetString(2);
                    clasa.AnStudii = reader.GetInt32(3);
                    clasa.NumeDiriginte = reader.GetString(4);
                    result.Add(clasa);
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
