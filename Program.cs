using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary < int , string > ciudades = new Dictionary < int , string > ();

            ciudades.Add(1520, " MEXICO"); 
            ciudades.Add(9526, " MADRID");
            ciudades.Add(4598, " BUENOS AIRES");
            ciudades.Add(1597, " BANGKOK");
            ciudades.Add(1687, " ESTAMBULGO");

            Console.WriteLine(" codigos ");
            foreach (var item in ciudades)
            {
                Console.WriteLine (item.Key);
            }
            Console.WriteLine("\n  ciudades ");
            foreach (var item in ciudades)
            {
                Console.WriteLine (item.Value);
            }


        }
    }
}
