using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsWeb

{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            // get connection string from Web.config
            string connString = ConfigurationManager.ConnectionStrings["TravelExpertsConnectionString"].ConnectionString;   //connection string
            SqlConnection conn = new SqlConnection(connString);     //sqlconnection object
            return conn;    //returns the connection object
        }
    }
}
