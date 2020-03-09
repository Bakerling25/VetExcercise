using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DyrLægeKlinik.Model
{
    class AnimalPet:ConnectionClass
    {
        private string tableName = "AnimalPet";
        private int animalId;
        private string navn;
        private int alder;
        private AnimalRace dyrRace;
        private AnimalSex dyrKøn;
        private AnimalOwner animalOwner;
        public AnimalPet(SqlConnection connection)
        {
            conn = connection;
        }
        public int AnimalId
        {
            get;
            set;
        }
        public string Navn
        {
            get;
            set;
        }
        public int Alder
        {
            get;
            set;
        }
        public AnimalRace DyrRace
        {
            get;
            set;
        }
        public AnimalSex DyrKøn
        {
            get;
            set;
        }
        public AnimalOwner AnimalOwner 
        { 
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                Navn,
                Alder
                //DyrRace,
                //AnimalOwner,
                //DyrKøn
            };
            List<string> keys = new List<string>()
            {
                "Navn",
                "Alder"
                //"DyrRace_ID",
                //"DyrEjer_ID",
                //"Køn_ID"
            };
            ConnectionClass.Insert(tableName, values, keys,conn);
        }
       

    }
}
