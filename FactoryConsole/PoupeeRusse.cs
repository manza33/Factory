using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryConsole
{
    public class PoupeeRusse
    {
        public PoupeeRusse(string monNom, string nomParent)
        {
            MonNom = monNom;
            NomParent = nomParent;
        }

        public string getNomParent()
        {
            return null;
        }

        public string MonNom { get; private set; }
        public string NomParent { get; set; }

    }
}
