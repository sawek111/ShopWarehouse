using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    class Connector
    {
        private const string CONNECTION_STRING = 
                "Data Source=DESKTOP-H4T84M1;" +
                "Initial Catalog=ShopWarehouse;" +
                "Integrated Security=SSPI;";

        SqlConnection _connection;
        SqlCommand command;
        SqlDataReader dataReader;


        public static string Select(int year)
        {
            string sql = "SELECT year_id FROM  ShopWarehouse.dbo.Year WHERE year_number = " + year.ToString();
            return sql;
        }


        public void SELECT(string columnName, string table, string statement)
        {
            Connect();
            string sql = "SELECT year_id FROM  ShopWarehouse.dbo.Year WHERE year_number = 2017";
            command = new SqlCommand(sql, _connection);
            ReadData(sql,1);

            Disconnect();
        }

        public void SelectWhere(string columnName, string table, string whereStatement, int records)
        {
            Connect();
            string sql = "SELECT "+columnName+ " FROM  ShopWarehouse.dbo." + table + " WHERE " + whereStatement;
            command = new SqlCommand(sql, _connection);
            ReadData(sql, 1);

            Disconnect();
        }

        public int GetScopeIndentity(string table)
        {
            Connect();
            string sql = "SELECT IDENT_CURRENT('dbo." + table + "')";
            command = new SqlCommand(sql, _connection);
            object datum = ReadDatum(sql);
            int scopeIdentity = int.Parse(datum.ToString());
            Disconnect();

            return scopeIdentity;
        }

        public void SelectOneIntRecordRow (string columnName, string table, string condition, ref int refValue)
        {
            Connect();
            string sql = "SELECT " + columnName + " FROM  ShopWarehouse.dbo." + table + " WHERE " + condition;
            command = new SqlCommand(sql, _connection);
            List<int> data = ReadIntData(sql);
            refValue = data[0];
            Disconnect();

            return;
        }

        public void InsertInto(string tableName, params string[] values)
        {
            Connect();
            string sql = "INSERT INTO  ShopWarehouse.dbo." + tableName + " VALUES (";
                for(int i = 0; i < values.Length; i++)
            {
                string endline = (i == values.Length - 1) ? ");" : ", ";
                string data = values[i] + endline;
                sql += data;
            }
            Console.WriteLine(sql);
            try
            {
                command = new SqlCommand(sql, _connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Disconnect();
            }

            Disconnect();
        }

        private List<string> ReadData(string SQLQuery, int columns)
        {
            List<string> memory = new List<string>();
            Console.WriteLine(SQLQuery);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string row = "";
                for(int i = 0; i < columns; i++)
                {
                    row += dataReader.GetString(i).ToString();
                }
                memory.Add(row);
            }
            dataReader.Close();

            return memory;
        }

        private List<int> ReadIntData(string SQLQuery)
        {
            List<int> memory = new List<int>();
            Console.WriteLine(SQLQuery);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetValue(0));
                memory.Add((int)dataReader.GetValue(0));
            }
            dataReader.Close();

            return memory;
        }

        private object ReadDatum(string SQLQuery)
        {
            Console.WriteLine(SQLQuery);
            object datum = "";
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetValue(0));
                datum = dataReader.GetValue(0);
            }
            dataReader.Close();

            return datum;
        }


        private void Connect()
        {

            _connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                _connection.Open();
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Connection Open ! ");
        
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return;
        }
       
        public void Disconnect()
        {
            _connection.Close();
        }
    }
}
