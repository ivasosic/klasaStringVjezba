using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVjezba_IvaSosic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. zadatak: ");
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";
            string s3 = s1.Substring(0, 8) + s2.Substring(7, 17);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine("\n -- Novi s3 --");
            Console.WriteLine(s3);

            Console.WriteLine("\n 2. zadatak: ");
            Console.WriteLine("Unesite niz znakova: ");
            string niz = Console.ReadLine();
            Console.WriteLine(niz.Replace(" ", "_"));

            Console.WriteLine("\n 3. zadatak: ");
            Console.WriteLine("Unesite niz znakova: ");
            string s4 = Console.ReadLine();
            Console.WriteLine("Velika slova: " + s4.ToUpper());
            Console.WriteLine("Mala slova: " + s4.ToLower());
            Console.WriteLine(s4.Substring(0, 3));
            Console.WriteLine(s4.Substring(s4.Length - 5));
            Console.WriteLine(s4.Substring(8, 4));

            Console.WriteLine("\n 4. zadata: ");
            Console.WriteLine("Unesite neku rečenicu: ");
            string rijec = Console.ReadLine();
            string[] Srijec = rijec.Split(' ');
            Console.WriteLine("Prva rijec: {0}", Srijec[0] );
            Console.WriteLine("Zadnja rijec: {0}", Srijec[ Srijec.Length -1]);


            Console.WriteLine("\n 5. zadatak: ");
            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojene s razmakom");
            string s5=Console.ReadLine();
            string[] s6 =s5.Split(' ');
            string x=s6[0];
            string y=s6[1];
            Console.WriteLine("Vrijednost x= " + x + "\nVrijednost y= " + y );
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
