using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WcfService1.Utils
{
    public class Connector
    {
        private SqlConnection connection;

        public SqlConnection Connection { get { return this.connection; } }

        public Connector()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["wcf"].ConnectionString;
                this.connection = new SqlConnection(connectionString);
            }catch(SqlException e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}