using System;

namespace exercise
{
    class program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] izal = new int[20]

        // Deklarasi Variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()
        {

            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("masukkan banyaknya elelmen Pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyi maksimal 51 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("_________________________");
            Console.WriteLine("\s\Syafrizal\s\" );
            Console.WriteLine(" Masukkan element array");
            Console.WriteLine("_________________________");
            
            // Pemgguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + "> ";
                string s1 = Console.ReadLine();
                izal[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan array yang tersususn
            Console.WriteLine("");
            Console.WriteLine("___________________________________");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("___________________________________");
            for (int ms = 0; ms < n; ms++)
            {
                Console.WriteLine(a[ms]);
            }
            Console.WriteLine("");
        }
        public void exerciseArray()
        {
            for (int i = 1; i < n; i++) // For n - 1 passes
            {
                // pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int ms = 0; ms < n - i; ms++)
                {
                    if (izal[ms] > izal[ms +1]) //jika elemen tidak dalam urutan yang benar
                    {
                        // Tuksr elemen
                        int temp;
                        temp = a[ms];
                        a[ms] = a[ms + 1];
                        a[ms + 1] = temp;
                    }
                }
            }
        }
        static void Main(String[] args)
        {
            // Creating the object of the exercise class
            program myList = new program();

            // Pemanggilan fungsi untuk menerima elemen pada array
            myList.read();
            // Pemanggilan fungsi untuk mengurutkan array
            myList.exerciseArray();
            // Pemanggilam fungsi untuk menampilkan array yang tersusun
            myList.display();
            //Exit
            Console.WriteLine("\n\nTekan Tomnol Apa aja untuk Keluar.");
            Console.Read();
        }
    }
}