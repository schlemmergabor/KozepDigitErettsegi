/*
 * 2023. őszi (október-november) digitális kultúra középszintű
 * érettségi feladat megoldása
 * (c) https://digiterettsegi.hu/
 */

namespace _2023osz_szallitas_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int (egész számok) tárolására alkalmas tömbbe teszem a számokat
            int[] tomegek = new int[] { 16, 8, 9, 4, 3, 2, 4, 7, 7, 12, 3, 5, 4, 3, 2};

            // összes tömeg kezdetben 0
            int összTömeg = 0;

            // végig járom a tömböt, egyes elemei item-ek
            foreach (int item in tomegek)
            {
                // hozzáadom az összes tömeghez az éppen aktuális számot
                összTömeg += item;
            }

            // feladat kiírása
            Console.WriteLine("2. feladat");
            
            // $ -jel után a szövegben { } közé tehetek változókat
            Console.WriteLine($"A tárgyak tömegének összege: {összTömeg} kg");

            Console.WriteLine("\n3. feladat");
            Console.Write("A dobozok tartalmának tömege (kg): ");
            
            // teli dobozok száma kezdetben 0
            int dobozokSzama = 0;
            // doboz kezdő súlya 0
            int dobozKg = 0;

            // végig járom a tömegek tömböt
            foreach (int item in tomegek)
            {
                // ha már nem fér bele az eddigi dobozba
                if (dobozKg+item > 20)
                {
                    // dobozok számát megnövelem 1-el
                    dobozokSzama++;
                    // kiírom a doboz eddigi kg-ját
                    Console.Write($"{dobozKg} ");
                    // új dobozbe beleteszem az item-et (kg)
                    dobozKg = item;

                }
                // minden más esetben -> tehát ha belefér
                else
                {
                    // beleteszem a dobozba az item (kg)-t
                    dobozKg += item;
                }
            }
            // utolsó doboz súlyát kiírom -> ami lehet nem teli is
            Console.WriteLine($"{dobozKg}");
            // dobozokSzama+1 -> mivel az utolsót is hozzászámolom
            Console.WriteLine($"A szükséges dobozok száma: {dobozokSzama+1}");

        }
    }
}