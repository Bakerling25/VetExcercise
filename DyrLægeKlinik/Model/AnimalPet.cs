using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DyrLægeKlinik.Model
{
    class AnimalPet:ConnectionClass
    {
        private int animalId;
        private string animalName;
        private int animalAge;
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
        public string AnimalName
        {
            get;
            set;
        }
        public int AnimalAge
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
       

    }
}
