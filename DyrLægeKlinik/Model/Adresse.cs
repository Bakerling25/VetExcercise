using System;
using System.Collections.Generic;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class Adresse
    {
        private int adresse_ID;
        private string streetName;
        private ZipCode zipCode_ID;
        public int Adresse_ID { get; set; }
        public string StreetName { get; set; }
        public ZipCode ZipCode_ID { get; set; }
    }
}
