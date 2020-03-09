using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class AnimalSex:ConnectionClass
    {
        private string tableName = "Køn";
        private int dyrKønId;
        private string køn;
        public int DyrKønId
        {
            get;
            set;
        }
        public string Køn
        {
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                Køn
            };
            List<string> keys = new List<string>()
            {
                "Køn"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);
        }
    }
}
