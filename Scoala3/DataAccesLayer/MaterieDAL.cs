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
    class MaterieDAL
    {
        public static ObservableCollection<Materie> GetAllMaterii()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("getMaterii", con);
                ObservableCollection<Materie> result = new ObservableCollection<Materie>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Materie materie = new Materie();

                    materie.Id = reader.GetInt32(0).ToString();
                    materie.Nume = reader.GetString(1);
                    materie.IdProfesor = reader.GetInt32(2).ToString();
                    materie.IdClasa = reader.GetInt32(3).ToString();
                    result.Add(materie);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }


        public static void AddMaterie(Materie materie)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddMaterie", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramNume = new SqlParameter("@name", materie.Nume);
                SqlParameter paramIdProfesor = new SqlParameter("@idProfesor", Int32.Parse(materie.IdProfesor));
                SqlParameter paramIdClasa = new SqlParameter("@idClasa", Int32.Parse(materie.IdClasa));

                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramIdProfesor);
                cmd.Parameters.Add(paramIdClasa);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModifyMaterie(Materie materie)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModificaMaterie", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdMaterie = new SqlParameter("@materieId", Int32.Parse(materie.Id));
                SqlParameter paramNume = new SqlParameter("@name", materie.Nume);
                SqlParameter paramIdProfesor = new SqlParameter("@idProfesor", Int32.Parse(materie.IdProfesor));
                SqlParameter paramIdClasa = new SqlParameter("@idClasa", Int32.Parse(materie.IdClasa));

                cmd.Parameters.Add(paramIdMaterie);
                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramIdProfesor);
                cmd.Parameters.Add(paramIdClasa);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteMaterie(Materie materie)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("StergeMaterie", con); 
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdMaterie = new SqlParameter("@id", Int32.Parse(materie.Id));

                cmd.Parameters.Add(paramIdMaterie);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static ObservableCollection<Medie> getMateriiNume(Elev elev)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Medie> result = new ObservableCollection<Medie>();

                SqlCommand cmd = new SqlCommand("getNumeMaterii", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdClasa = new SqlParameter("@idClasa", elev.IdClasa);
                cmd.Parameters.Add(paramIdClasa);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Medie medie = new Medie();

                    medie.NumeMaterie = reader.GetString(0);
                    medie.medieNumeric = "0";
                    result.Add(medie);
                }
                reader.Close();

                return result;
            }
        }
    }
}
