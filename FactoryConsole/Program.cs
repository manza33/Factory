using System;

namespace FactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PoupeeRusse p1 = FactoryPoupee.genererPoupee("Titi 1");
            PoupeeRusse p2 = FactoryPoupee.genererPoupee("Tata 2");
            PoupeeRusse p3 = FactoryPoupee.genererPoupee("Toto 3");

            Console.WriteLine($"1ère poupée : {p1.MonNom} | Parent : {p1.NomParent}");
            Console.WriteLine($"2ème poupée : {p2.MonNom} | Parent : {p2.NomParent}");
            Console.WriteLine($"3ème poupée : {p3.MonNom} | Parent : {p3.NomParent}");

            Console.WriteLine("Hello World!");
        }
    }
}
