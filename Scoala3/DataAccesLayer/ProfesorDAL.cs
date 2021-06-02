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
    class ProfesorDAL
    {
        public static ObservableCollection<Profesor> GetAllProfesori()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("getProfesori", con);
                ObservableCollection<Profesor> result = new ObservableCollection<Profesor>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Profesor profesor = new Profesor();

                    profesor.Id = reader.GetInt32(0).ToString();
                    profesor.Nume = reader.GetString(1);
                    profesor.Specializare = reader.GetString(2);
                    profesor.isDiriginte = reader.GetInt32(3).ToString();
                    result.Add(profesor);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public static void AddProfesor(Profesor profesor)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddProfesor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                //Sa modific parametrii

                SqlParameter paramNume = new SqlParameter("@name", profesor.Nume);
                SqlParameter paramSpecializare = new SqlParameter("@specializare", profesor.Specializare);
                SqlParameter paramIdDiriginte = new SqlParameter("@diriginte", profesor.isDiriginte);

                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramSpecializare);
                cmd.Parameters.Add(paramIdDiriginte);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public static void ModifyProfesor(Profesor profesor)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModificaProfesor", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdProfesor = new SqlParameter("@persID", Int32.Parse(profesor.Id));
                SqlParameter paramNume = new SqlParameter("@name", profesor.Nume);
                SqlParameter paramSpecializare = new SqlParameter("@specializare", profesor.Specializare);
                SqlParameter paramIsDiriginte = new SqlParameter("@diriginte", Int32.Parse(profesor.isDiriginte));

                cmd.Parameters.Add(paramIdProfesor);
                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramSpecializare);
                cmd.Parameters.Add(paramIsDiriginte);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteProfesor(Profesor profesor)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("StergeProfesor", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdElev = new SqlParameter("@id", Int32.Parse(profesor.Id));

                cmd.Parameters.Add(paramIdElev);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
