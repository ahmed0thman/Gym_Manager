﻿using System.Data;
using MySql.Data.MySqlClient;

namespace MySqlControl
{
    public class MySqlClass
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public MySqlClass(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
            command = new MySqlCommand("", connection);
        }

        public void Open()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataTable GetData(string select)
        {
            DataTable tbl = new DataTable();
            command.CommandText = select;
            tbl.Load(command.ExecuteReader());
            return tbl;
        }

        public void Run(string SQL, string param = null, byte[] data = null)
        {
            command.CommandText = SQL;
            if(param != null)
            command.Parameters.Add($"{param}", MySqlDbType.Blob).Value = data;
            command.ExecuteNonQuery();
        }
    }
}