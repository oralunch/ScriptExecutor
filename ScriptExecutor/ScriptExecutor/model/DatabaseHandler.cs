using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ScriptExecutor
{
    class DatabaseHandler
    {
        public OracleConnection GetConnection()
        {
            string connStr = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                             @"(HOST=127.0.0.1)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl)));" +
                              "Persist Security Info=True;USER ID=scott;password=tiger;" +
                              "Min Pool Size=5;Max Pool Size=30;Connection Lifetime=120;";
            OracleConnection conn = new OracleConnection(connStr);

            return conn;
        }

        public OracleDataReader GetResult(string sql, OracleConnection conn)
        {
            OracleCommand comm = conn.CreateCommand();
            comm.CommandText = sql;
            OracleDataReader result = comm.ExecuteReader();
            
            return result;
        }
    }
}
