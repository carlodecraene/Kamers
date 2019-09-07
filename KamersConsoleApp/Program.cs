using KamersModel;
using System;

namespace KamersConsoleApp
{
    class Program
    {
       
        
        static void Main()
        {
            /// Maak een spelomgeving aan 
            /// Maak een speler aan 
            /// Plaats een speler in de speelomgeving
            /// Speel 
            var spelomgeving = MaakSpelOmgevingAan();
            var speler = MaakSpeler();
            spelomgeving.VoegSpelerToe(speler);
            var kamer = spelomgeving.Plaatsen.Find(x => x.Plaatsnaam == "Kortrijk");
            var stukje = new Voorwerp();
            if (kamer.Plaatsnaam=="Kortrijk")
            {
                kamer.Voorwerpen.Add(new Voorwerp("winkelwagen", true,true));
                stukje = kamer.Voorwerpen.Find(x => x.VoorwerpNaam == "wikelwagen");
                if (stukje==null)  
                {
                    Console.WriteLine("Stukje is niet gevonden");
                    Console.ReadLine();
                    Console.WriteLine("Dinge");
                    
                }
                else
                {
                    Console.WriteLine(stukje.VoorwerpNaam);
                    Console.ReadLine();
                }
                

            }
            var stuk = new Voorwerp("Tafel", true,true);
            if (stuk.ActieMogelijk)
            {
                stuk.Daad = new Actie("Cijferslot veranderen");
            }
                  
            Console.WriteLine(stuk.VoorwerpNaam);
            Console.WriteLine(stuk.Daad.ActieNaam);


            //Speel(spelomgeving);
        }

        private static void Speel(Level spelomgeving)
        {
            string command = "";

            while (command != "STOP")
            {
                switch (command)
                {
                    
                    case "Toon plaats":
                        ///
                        ///Zoek de plaats waar de speler zich bevindt
                        ///
                        foreach(var plaats in spelomgeving.Plaatsen)
                        {
                            if (plaats.Speler!=null)
                            {
                                Console.WriteLine(plaats.Plaatsnaam.ToString());
                            }
                        }
                        break;
                    case "Help":
                        break;
                    default:
                        Console.WriteLine("Mogeljke waardes :");
                        Console.WriteLine("Toon plaats : Toont de plaats waar de speler zich bevindt");
                        Console.WriteLine("Help: Helpinstructies van het spel");
                        break;
                        
                }
                command = Console.ReadLine().Trim();
            }
        }

        private static Speler MaakSpeler()
        {
            var speler = new Speler();
            return speler;
        }

        private static Level MaakSpelOmgevingAan()
        {
            var plaats = new Plaats("Kortrijk");
            return new Level(plaats);
        }
    }

            
}
