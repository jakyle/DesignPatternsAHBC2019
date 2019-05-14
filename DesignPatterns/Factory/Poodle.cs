using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Poodle : DogBase,  IDog
    {
        public string Bark()
        {
            return "Fancy Bark!";
        }
    }
}
