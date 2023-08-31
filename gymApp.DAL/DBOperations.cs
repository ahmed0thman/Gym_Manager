using MySqlControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gymApp.DAL
{
    public static class DBOperations
    {
        public static MySqlClass db = new MySqlClass("server = localhost; database= gymdb;uid=root;password=;sslmode=none");
        //public static SQLServerControl db = new SQLServerControl(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "gymdb.mdf;Integrated Security=True;Connect Timeout=30");
    }
}
