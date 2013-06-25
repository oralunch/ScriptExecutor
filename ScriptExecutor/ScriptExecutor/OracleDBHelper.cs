using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace ScriptExecutor
{
    class OracleDBHelper
    {
        private OracleConnection connection;

        private OracleConnectionStringBuilder connStrBuilder;

        public string UserID
        {
            set { this.connStrBuilder.UserID = value; }
        }

        public string Password
        {
            set { this.connStrBuilder.Password = value; }
        }

        public string DBAPrivilege
        {
            set { this.connStrBuilder.DBAPrivilege = value; }
        }

        public string DataSource
        {
            set { this.connStrBuilder.DataSource = value; }
        }

        public int MinPoolSize
        {
            set { this.connStrBuilder.MinPoolSize = value; }
        }

        public OracleDBHelper()
        {
            connStrBuilder = new OracleConnectionStringBuilder()
            {
                MaxPoolSize = 50,
                MinPoolSize = 1,
                ConnectionLifeTime = 60
            };
        }

        public OracleDBHelper(string dataSource, string userID, string password)
        {
            connStrBuilder = new OracleConnectionStringBuilder()
            {
                DataSource = dataSource,
                UserID = userID,
                Password = password,
                MaxPoolSize = 50,
                MinPoolSize = 1,
                ConnectionLifeTime = 60
            };
        }

        public void Close()
        {
            if (this.connection != null && this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }

        public void Open()
        {
            Close();
            try
            {
                this.connection = new OracleConnection(connStrBuilder.ConnectionString);
                this.connection.Open();
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
            }
        }

        public OracleDataReader GetDataReader(string sql)
        {
            OracleCommand command = new OracleCommand(sql, this.connection);
            
            return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public void ExecuteNonQuery(string sql)
        {
            OracleCommand command = new OracleCommand(sql, this.connection);
            command.ExecuteNonQuery();
        }
    }
}
