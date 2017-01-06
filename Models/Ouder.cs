using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppSE2.Models
{
    public class Ouder : User
    {
        public int mobielNr { get; private set; }
        public string beperkingen { get; private set; }
        public int leeftijd { get; private set; }

        public Ouder()
        {
            
        }
    }
}