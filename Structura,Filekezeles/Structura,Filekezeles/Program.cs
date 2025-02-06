using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Structura_Filekezeles
{
    internal class Program
    {
        public struct ember
        {
            public string keresztnev;
            public string vezeteknev;
            public int eletkor;
           
        }

        public static List<ember> Adatok = new List<ember>();
        static void Main(string[] args)
        {
            
            FileStream f = new FileStream("adatok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f, Encoding.UTF8);
            ember aktualis = new ember();
            while (!sr.EndOfStream) {
                string[] sor = sr.ReadLine().Split(' ');
                aktualis.vezeteknev = sor[0];
                aktualis.keresztnev = sor[1];
                aktualis.eletkor = Convert.ToInt32(sor[2]);
                Adatok.Add(aktualis);
            
            }
            sr.Close();
            f.Close();
            Console.WriteLine("A fájl beolvasása megtörtént!\n");
            for (int i = 0; i < Adatok.Count; i++)
            {
                Console.WriteLine($"{Adatok[i].vezeteknev}, {Adatok[i].keresztnev}, {Adatok[i].eletkor}");
            }


            //Kiírása
            Console.WriteLine("Adj meg egy nevet");
            string veznev = Console.ReadLine();
            Console.WriteLine("Adj meg egy Kereszt nevet");
            string kernev = Console.ReadLine();
            Console.WriteLine("Adj meg egy életkort");
            
            int kor = Convert.ToInt32(Console.ReadLine());
            Adatok.Add(new ember { vezeteknev = veznev, keresztnev = kernev, eletkor = kor });

            FileStream f2 = new FileStream("adatok_2.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f2);
            for (int i = 0;i < Adatok.Count; i++)
            {
                sw.WriteLine($"{Adatok[i].vezeteknev}, {Adatok[i].keresztnev}, {Adatok[i].eletkor}");
            }
            sw.WriteLine($"{veznev} {kernev} {kor}");
            sw.Close();
            f2.Close();

            Console.WriteLine("Az új adat elmentve az adatok_2.txt fájlba.");

            Console.ReadKey();
        }
    }
}
