using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppSE2.Models
{
    public abstract class User
    {
        public string initialen { get; private set; }
        public string achternaam { get; private set; }
        public int loginPin { get; private set; }
        public string email { get; private set; }
        public int telNr { get; private set; }
        public string thuisAdres { get; private set; }
    }
}