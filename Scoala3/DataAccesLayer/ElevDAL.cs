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

                    elev.IdElev = reader.GetInt32(0).ToString();
                    elev.Nume = reader.GetString(1);
                    elev.AnStudii = reader.GetInt32(2);
                    elev.Specializare = reader.GetString(3);
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
                SqlParameter paramIdClasa = new SqlParameter("@id_clasa", Int32.Parse(elev.IdClasa));

                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramIdClasa);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModifyElev(Elev elev)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModificaElev", con); 
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdElev = new SqlParameter("@elevID", Int32.Parse(elev.IdElev));
                SqlParameter paramNume = new SqlParameter("@name", elev.Nume);
                SqlParameter paramIdClasa = new SqlParameter("@clasa", Int32.Parse(elev.IdClasa));

                cmd.Parameters.Add(paramIdElev);
                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramIdClasa);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteElev(Elev elev)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("StergeElev", con); 
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdElev = new SqlParameter("@id", Int32.Parse(elev.IdElev));

                cmd.Parameters.Add(paramIdElev);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static Elev getElevFromAccount(Account account)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("getElevFromAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdAccount = new SqlParameter("@idCont", Int32.Parse(account.Id));

                cmd.Parameters.Add(paramIdAccount);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Elev()
                    {
                        IdElev=reader["id_elev"].ToString(),
                        Nume=reader["nume"].ToString(),
                        IdClasa=reader["id_clasa"].ToString(), 
                    };
                }
                reader.Close();

            }
            return null;
        }
    }
}
