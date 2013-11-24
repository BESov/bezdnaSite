using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EgorSite.Models
{
    public class UserModel
    {
        private string connStr = "";

        public string[] GetUserNames()
        {

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Select email From User";

            SqlDataReader reader = command.ExecuteReader();
            List<string> emails = new List<string>();

            while (reader.Read())
            {
                emails.Add(readers            }
        }
    }
}