using Scoala3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala3.DataAccesLayer
{
    class AccountDAL
    {
        public static bool ExistAccount(Account account)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("getAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter username = new SqlParameter("@username", account.username);
                SqlParameter password = new SqlParameter("@password", account.password);
                cmd.Parameters.Add(username);
                cmd.Parameters.Add(password);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                reader.Close();
            }
            return false;
        }
    }
}
