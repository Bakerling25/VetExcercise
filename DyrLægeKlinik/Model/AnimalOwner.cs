using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class AnimalOwner:ConnectionClass
    {
        private string tableName = "DyrEjer";
        private int dyrEjer_ID;
        private string navn;
        private List<Adresse> adresse_ID;
        public int DyrEjer_ID { get; set; }
        public string Navn
        { 
            get;
            set;
        }
        public List<Adresse> Adresse_ID
        {
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                Navn,
                Adresse_ID
            };
            List<string> keys = new List<string>()
            {
                "Navn",
                "Adresse_ID"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);
        }
    }
}
