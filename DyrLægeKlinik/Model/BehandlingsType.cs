using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class BehandlingsType:ConnectionClass
    {
        private string tableName = "BehandlingsType";
        private int behandlingsType_Id;
        private string procedure;
        public int BehandlingsType_Id
        {
            get;
            set;
        }
        public string Procedure
        {
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                Procedure
            };
            List<string> keys = new List<string>()
            {
                "Procedure"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);
        }
    }
}
