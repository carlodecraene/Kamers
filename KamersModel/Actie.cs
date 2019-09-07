using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    public class Actie
    {
        public Actie(string actienaam)
        {
            ActieNaam = actienaam;
        }
        public string ActieNaam { get; set; }
    }
}
