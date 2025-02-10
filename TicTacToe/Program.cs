using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palya = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool jatekos1 = true;
            int gyozelmekszama = 0;
            int lepesek = 0;
            bool gyozelem = false;
            bool valasztas = true;

            while (!gyozelem && lepesek < 9)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{palya[i * 3]}|{palya[i * 3 + 1]}|{palya[i * 3 + 2]}|");
                    if (i < 2) Console.WriteLine("------");
                }

                if (jatekos1)
                {
                    Console.WriteLine("Jatekos 1 választ X.");
                }
                else
                {
                    Console.WriteLine("Játékos 2 választ O");
                }

                string valaszt = Console.ReadLine();
                int valasztIndex;

                if (int.TryParse(valaszt, out valasztIndex) && valasztIndex >= 1 && valasztIndex <= 9 && palya[valasztIndex] != "X" && palya[valasztIndex] != "O")
                {
                    palya[valasztIndex - 1] = jatekos1 ? "X " : "O";

                    gyozelem =
                        (palya[0] == palya[1] && palya[1] == palya[2]) ||
                        (palya[3] == palya[4] && palya[4] == palya[5]) ||
                        (palya[6] == palya[7] && palya[7] == palya[8]) ||
                        (palya[0] == palya[3] && palya[3] == palya[6]) ||
                        (palya[1] == palya[4] && palya[4] == palya[7]) ||
                        (palya[2] == palya[5] && palya[5] == palya[8]) ||
                        (palya[0] == palya[4] && palya[4] == palya[8]) ||
                        (palya[2] == palya[4] && palya[4] == palya[6]);


                }
                jatekos1 = !jatekos1;



            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{palya[i * 3]}|{palya[i * 3 + 1]}|{palya[i * 3 + 2]}|");
                if (i < 2) Console.WriteLine("------");
            }

            if (gyozelem)
            {
                Console.WriteLine("Győztél");
               

            }


            if (gyozelmekszama > 0) {
                while(true){
                    Console.WriteLine("Szeretnél még játszani (i/n)");
                    string valasz = Console.ReadLine();
                    if (valasz == "n")
                    {
                        
                        break;
                    }
                    else 
                    {
                        while (!gyozelem && lepesek < 9)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine($"{palya[i * 3]}|{palya[i * 3 + 1]}|{palya[i * 3 + 2]}|");
                                if (i < 2) Console.WriteLine("------");
                            }

                            if (jatekos1)
                            {
                                Console.WriteLine("Jatekos 1 választ X.");
                            }
                            else
                            {
                                Console.WriteLine("Játékos 2 választ O");
                            }

                            string valaszt = Console.ReadLine();
                            int valasztIndex;

                            if (int.TryParse(valaszt, out valasztIndex) && valasztIndex >= 1 && valasztIndex <= 9 && palya[valasztIndex] != "X" && palya[valasztIndex] != "O")
                            {
                                palya[valasztIndex - 1] = jatekos1 ? "X " : "O";

                                gyozelem =
                                    (palya[0] == palya[1] && palya[1] == palya[2]) ||
                                    (palya[3] == palya[4] && palya[4] == palya[5]) ||
                                    (palya[6] == palya[7] && palya[7] == palya[8]) ||
                                    (palya[0] == palya[3] && palya[3] == palya[6]) ||
                                    (palya[1] == palya[4] && palya[4] == palya[7]) ||
                                    (palya[2] == palya[5] && palya[5] == palya[8]) ||
                                    (palya[0] == palya[4] && palya[4] == palya[8]) ||
                                    (palya[2] == palya[4] && palya[4] == palya[6]);


                            }
                            jatekos1 = !jatekos1;



                        }

                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"{palya[i * 3]}|{palya[i * 3 + 1]}|{palya[i * 3 + 2]}|");
                            if (i < 2) Console.WriteLine("------");
                        }

                        if (gyozelem)
                        {
                            Console.WriteLine("Győztél");
                            gyozelmekszama += 1;
                            Console.WriteLine($"Gyozelmek száma: {gyozelmekszama}");

                        }


                    }


                }
            }

            Console.ReadKey();
        }




           

                      
        }
    }

