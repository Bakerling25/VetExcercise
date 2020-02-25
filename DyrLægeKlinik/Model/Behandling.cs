using System;
using System.Collections.Generic;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class Behandling:SuperClass
    {
        private int behandling_ID;
        private DateTime dateOfProcedure;
        private List<BehandlingsType> behandlingsType_ID;
        private List<AnimalPet> kæleDyr_ID;
        public int Behandling_ID 
        {
            get;
            set;
        }
        public DateTime DateOfProcedure { get; set; }
        public List<BehandlingsType> BehandlingsType_ID { get; set; }
        public List<AnimalPet> KæleDyr_ID { get; set; }
        public void View()
        {
            string query = "Placeholder";
            ConnectionClass.Connection(conn, query);
        }
    }
}
