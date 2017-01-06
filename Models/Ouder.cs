using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppSE2.Models
{
    public class UserOuder
    {
        public string initialen { get; set; }
        public string achternaam { get; set; }
        public int loginPin { get; set; }
        public int mobielNr { get; set; }
        public int telNr { get; set; }
        public string eMail { get; set; }
        public string thuisAdres { get; set; }
        public string beperkingen { get; set; }
        public int leeftijd { get; set; }
    }
}