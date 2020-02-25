using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DyrLægeKlinik.Model
{
    class DyrRace
    {
        private int dyrRaceId;
        private string race;
        public int DyrRaceId { get; set; }
        public string Race { get; set; }
    }
}
