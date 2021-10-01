static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            int a = 20;
            int b = 10;

            Console.WriteLine("Hasil dari Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil dari Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil dari Pembagian {0} : {1} = {2}", a, b, Pembagian(a, b));
            Console.WriteLine("Hasil dari Perkalian {0} x {1} = {2}", a, b, Perkalian(a, b));

            Console.WriteLine("\nTekan key sembarang untuk keluar...");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
