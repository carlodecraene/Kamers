using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Speler
    {
        
        public int Score { get; set; }

        /// <summary>
        /// De plaats waar de speler zich nu bevindt
        /// </summary>
        public Plaats HuidigePlaats { get; set; }

        /// <summary>
        /// De lijst van voorwerpen die de speler nu bij zich heeft.
        /// Deze kan enkel voorwerpen bevatten die niet vastopplaats zijn.
        /// </summary>
        public List<Voorwerp> Rugzak { get; set; }

        public  bool PlaatsVoorwerpInRuimte(Voorwerp voorwerp)
        {
            if (Rugzak.Contains(voorwerp))
            {
                ///Haal het voorwerp uit de rugzak
                Rugzak.Remove(voorwerp);
                /// Voeg het voorwerp toe aan de ruimte waar de speler zich nu bevindt
                HuidigePlaats.Voorwerpen.Add(voorwerp);
                return true;
            }
            return false;               
        }
        public bool NeemVoorwerpUitRuimte(Voorwerp voorwerp)
        {
            if (HuidigePlaats.Voorwerpen.Contains(voorwerp))
            {
                HuidigePlaats.Voorwerpen.Remove(voorwerp);
                if (!voorwerp.VastOpPlaats)
                 {
                    Rugzak.Add(voorwerp);
                    return true;

                }
            }
            return false;
        }
    }
}
