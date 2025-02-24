using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;


namespace Jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Game> jatekok = new List<Game>();
            string[] adatok = File.ReadAllLines("jatekok.txt");
            foreach (var item in adatok)
            {
                string[] list = item.Split(',');
                Game jatek_object = new Game(list[0],list[1],list[2],list[3],list[4]);
                jatekok.Add(jatek_object);
            }

            foreach (var j in jatekok) {
                Console.WriteLine($"{j.sorszam}, {j.tipus}, {j.cim}, {j.ar}, {j.db}");
            }

            int db = 0;
            int osszeg = 0;

            int legdragabb = int.MinValue;
            string legdragabbcim = "";
            foreach (var item in jatekok)
            {
                if (item.ar > legdragabb) {
                    legdragabb = item.ar;
                    legdragabbcim = item.cim;
                }
               
                if (item.tipus == "Akció") {
                    
                    db++;
                    Console.WriteLine($"{db}, {item.cim}");
                    osszeg += item.ar;

                }
            }

            Console.WriteLine("Adj meg egy játék címet");
            string jatekcim = Console.ReadLine();
           
                foreach (var bennevan in jatekok) {
                if (bennevan.cim.Equals(jatekcim))
                {
                    Console.WriteLine($"{bennevan.sorszam},{bennevan.cim}, {bennevan.ar},{bennevan.db}");
                    break;
                }
                /*else {
                    Console.WriteLine("Nincs benne a listában.");
                    break;
                }*/

            }

            Console.WriteLine($"A txt-ben {jatekok.Count} db játék van.");
            Console.WriteLine($"{db} Akció játék van a listában.");
            Console.WriteLine($"Az Akció játékok összege: {osszeg}");
            Console.WriteLine($"A legdrágább játék címe: {legdragabbcim}, ára: {legdragabb}");
            Console.ReadKey();
        }
    }
}
