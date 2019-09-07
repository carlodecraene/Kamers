using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    ///Een spelomgeving

    public class Level
    {
        public Plaats StartPlaats { get;  }
        public List<Plaats> Plaatsen { get;  }

        public Level(Plaats plaats)
        {
            StartPlaats = plaats;
            Plaatsen = new List<Plaats>();
            Plaatsen.Add(StartPlaats);
        }

        public void VoegSpelerToe(Speler speler)
        {
            StartPlaats.VoegSpelerToe(speler);
        }
    }
}
