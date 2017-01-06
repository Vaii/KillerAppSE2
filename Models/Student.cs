using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppSE2.Models
{
    public class Student : User
    {
        public int credits { get; private set; }
        public string emailRef { get; private set; }
        public string studeerLocatie { get; private set; }

        public Student()
        {
            
        }
    }
}