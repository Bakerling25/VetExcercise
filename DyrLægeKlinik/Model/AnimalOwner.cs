using System;
using System.Collections.Generic;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class AnimalOwner
    {
        private int animalOwner_ID;
        private string name;
        private List<Adresse> adresse_ID;
        public int AnimalOwner_ID { get; set; }
        public string Name { get; set; }
        public List<Adresse> Adresse_ID { get; set; }
    }
}
