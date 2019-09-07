using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    public class Plaats
    {
        public Plaats(string plaatsnaam)
        {
            Plaatsnaam = plaatsnaam;
            Voorwerpen = new List<Voorwerp>();
        }

        /// <summary>
        /// De voorwerpen die zich op deze plaats bevinden
        /// </summary>
        public List<Voorwerp> Voorwerpen { get; set; }
        /// <summary>
        /// De Speler die zich op een plaats bevindt.
        /// </summary>
        public Speler Speler { get; set; }
        /// <summary>
        /// De naam van deze plaats
        /// </summary>
        public string Plaatsnaam { get; set; }

        public void VoegSpelerToe(Speler speler)

        {
            Speler = speler;
        }

            
    }
}
