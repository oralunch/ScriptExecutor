using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScriptExecutor
{
    class Executor
    {
        private string appUserID;

        private string appPassword;

        public string AppUserID
        {
            set { this.appUserID = value; }
        }

        public string AppPassword
        {
            set { this.appPassword = value; }
        }

        public Executor() { }

        public Executor(string userID, string password)
        {
            this.appUserID = userID;
            this.appPassword = password;
        }

        public void Init(string dataSource, string sysUserID,string sysPassword)
        {
            
        }

        public bool CheckAppSchema(string dataSource)
        {

        }
    }
}
