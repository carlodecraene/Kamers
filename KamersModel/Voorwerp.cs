using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Voorwerp
    {


        public Voorwerp()
        {
            VastOpPlaats = false;
            ActieMogelijk = false;
            Status = false;
            VoorwerpNaam = "";
        }
        public Voorwerp(string voorwerpnaam,bool vastopplaats,bool actiemogelijk)
        {
            VoorwerpNaam = voorwerpnaam;
            VastOpPlaats = vastopplaats;
            ActieMogelijk = actiemogelijk;
            
        }
        
        public string VoorwerpNaam { get; set; }
        /// <summary>
        /// Op een plaats kunnen zich voorwerpen bevinden.
        /// Sommige voorwerpen zitten vast op een plaats (bv een standbeeld, een lichtschakelaar,...) 
        /// Sommige kan je meenemen (bv een afstandsbediening). 
        /// </summary>
        public bool VastOpPlaats { get; set; }
        /// <summary>
        /// Met sommige voorwerpen kan je iets doen. 
        /// Als dat zo is, kan je zien aan het voorwerp wat ermee kan gedaan worden. 
        /// Bv van een cijferslot kan je de combinatie veranderen. Een schakelaar kan je aan- en uitzetten, â€¦ 
        /// </summary>
        public bool ActieMogelijk { get; set; }
        /// <summary>
        /// Soms kan je alleen maar zien wat de status van een object is (een lamp is aan of uit).
        /// </summary>
        public bool Status { get; set; }

        private Actie daad;

        public Actie Daad
        {
            get
            {
                return daad;
            }
            set
            {
                if (!this.ActieMogelijk)
                {
                    Console.WriteLine("Kan geen actie toekennen gezien er voor voorwerp geen actie mogelijk is");
                }
                else
                {
                    daad = value;
                }

                
            }
        }



    }
}
