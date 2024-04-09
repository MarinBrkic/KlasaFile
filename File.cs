using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string putanja = @"c:\test\";
            Console.WriteLine(putanja);

            Console.WriteLine("Upisi svoje ime: ");
            string ime = Console.ReadLine();

            string datoteka = "ime.txt";
            string putanjaDatoteke = putanja + datoteka;

            if (File.Exists(putanjaDatoteke))
            {
                Console.WriteLine("Datoteka postoji!");
                if (!Directory.Exists(putanja + "bkp"))
                {
                    Directory.CreateDirectory(putanja + "bkp");
                    File.Copy(putanjaDatoteke, putanja + "bkp\\ime_"
    + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + "txt");
                }
            }
            else
            {
                File.Create(putanjaDatoteke);
                Console.WriteLine("Datoteka kreirana!");
            }

            File.WriteAllText(putanjaDatoteke, ime);

            Console.ReadKey();
        }
    }
}
