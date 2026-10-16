namespace TombFeladatsor
{
    internal class Program
    {
        static Random r = new Random();
        
        static void Feladat1()
        {
            int[] tomb = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(5, 10);
            }
            foreach (int item in tomb)
            {
                Console.WriteLine(item);
            }
        }
        static void Feladat5()
        {
            int[] tomb = new int[5];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a tömb {i + 1}. számát: ");
                int szam = Convert.ToInt32(Console.ReadLine());
                tomb[i] = szam;
            }
            Console.WriteLine("Kiíratás:");
            foreach (int item in tomb)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Fordítva:");
            for (int i = tomb.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine("Minden második eleme:");
            for (int i = 1; i < tomb.Length; i += 2)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.Write("Kérek egy számot 1 és 5 között: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            while (j< tomb.Length && index != j)
            {
                j++;
            }
            Console.WriteLine(tomb[j - 1]);
        }
        static void Feladat13()
        {
            int[] tomb = new int[20];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-100, 99);
            }
            Console.WriteLine("Kiiratás:");
            foreach (int item in tomb)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Kiírás táblázatban:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine($"|{i + 1}.|{Math.Abs(tomb[i])}|{(tomb[i] >= 0 ? "+" : "-")}|");
            }
            Console.WriteLine("Minden harmadik taghoz 1-et adunk:");
            for (int i = 1; i < tomb.Length; i += 3)
            {
                Console.WriteLine(tomb[i] += 1);
            }
            Console.WriteLine("Minden második elem csökkentése az előtte lévővel");
            for (int i = 1; i < tomb.Length; i += 2)
            {
                Console.WriteLine(tomb[i] += tomb[i - 1]);
            }
        }
        static void Karneval()
        {
            int[] sorjegyek = new int[100];
            string[] nyermenyek = new string[5];

        }
        static void Main(string[] args)
        {
            //Feladat1();
            //Feladat5();
            //Feladat13();
            Karneval();
            Console.ReadLine();
        }
    }
}
