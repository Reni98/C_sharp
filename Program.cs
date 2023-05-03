// See https://aka.ms/new-console-template for more information
using Casino;

Console.WriteLine("Hello, World!");
List<Rulett> rulett_list = new List<Rulett>();
List<NyeroSzam> nyeroSzam_list = new List<NyeroSzam>();
string[] lines = File.ReadAllLines("nyeremenyek.txt");
foreach (var item in lines)
{
    string[] values = item.Split(';');
    Rulett rulett_object = new Rulett(values[0], values[1], values[2], values[3], values[4]);
    rulett_list.Add(rulett_object);
}

foreach (var item in rulett_list)
{
    Console.WriteLine($"{item.sorszam} {item.felhnev} {item.fogadott_tet} {item.szorzo} {item.eredmeny}");
}

//2.Feladat
//Kérjen be egy számot és az alapján írja ki a bekért számmal megegyező sorszámú játszma adatait.

Console.WriteLine("2.Feladat");
Console.Write("Kérem adja meg a keresett sorszámot: ");
string keresettSorszam = Console.ReadLine();



    foreach(var item in rulett_list)
{
        if ( item.sorszam == int.Parse(keresettSorszam))
        {
            Console.WriteLine($"{item.sorszam} {item.felhnev} {item.fogadott_tet} {item.szorzo} {item.eredmeny}");
        }
}

//3.Feladat Adja meg, melyik felhasználó tette meg a legtöbb játszmát és ez mennyibe került összesen!
Console.WriteLine("3.Feladat");

//4. Feladat
//Adja meg hány nyertes játszma van összesen!

//int nyertesJatszma = 0;
int db = 0;
int nyer_osszeg = 0;

    foreach(var item in rulett_list)
    {
        if(item.eredmeny == "nyertes")
        {
        nyer_osszeg = item.fogadott_tet *= item.szorzo;
       // Console.WriteLine($"{item.sorszam} {item.felhnev} {nyer_osszeg}");
            db++;
        }
        
    }
Console.WriteLine("4.Feladat");
    Console.WriteLine($"A nyertes játszmák összege:" + db);


//5. Írja ki annak a játszmának az adatait, amely után a legkisebb nyereményt lehetett felvenni.

Console.WriteLine("5.Feladat");

int min = Int32.MaxValue;
int nyeremeny = 0;

foreach(var item in rulett_list)
{

    if (item.eredmeny == "nyertes")
    {
      nyeremeny= item.fogadott_tet *= item.szorzo;
        if (nyeremeny < min)
        {

            min = item.fogadott_tet;
        }
    }
    
}

foreach(var item in rulett_list)
{
    if (item.fogadott_tet == min)
    {
        Console.WriteLine($"Ennek a játszmának, van a legkisebb nyereménye: {item.sorszam} {item.felhnev} {item.fogadott_tet} {item.szorzo} {item.eredmeny}");
    }
}

