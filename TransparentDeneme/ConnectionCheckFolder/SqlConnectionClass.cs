using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace TransparentDeneme.ConnectionCheckFolder
{
    public class SqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CGCNL6C\SQLEXPRESS;Initial Catalog=TransparentDenemeDatabase;Integrated Security=True");

        public static void CheckConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
                connection.Close();
            }
        }
    }



}
