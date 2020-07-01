using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryConsole
{
    public class FactoryPoupee
    {
		public static string _poupeeParent = "Aucun parents";

		public static PoupeeRusse genererPoupee(String nom)
		{
			PoupeeRusse p = new PoupeeRusse(nom, _poupeeParent);

			_poupeeParent = nom;
			return p;
		}
	}
}
