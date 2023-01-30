using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FT1
{
    internal class Program
    {
        
        

        static void Main(string[] args)
        {
            //esLoli();
            //Kelomokkan();
            Fibonaci();
            //kelipatan();
            //Kubus();
            //Gunung();
            //Perbandingan();
            //Libur();
            //hargaBuah();
            //jumlah();
        }

        static void esLoli()
        {
            int stik = 5;
            int harga = 1000;
            Console.Write("Masukkan Uang: ");
            int uang = int.Parse(Console.ReadLine());
            int hasil = uang/harga;

            if (hasil == 5)
            {
                Console.WriteLine("Jumlah es loli gratis: " + (hasil/stik));
                Console.WriteLine("" + ((hasil/stik)+hasil));
            }
            else if(hasil>5)
            {
                if (hasil > 200)
                {
                    Console.WriteLine("" + ((hasil / stik) + hasil +8));
                }
                else if (hasil > 50)
                {
                    Console.WriteLine("" + ((hasil / stik) + hasil + 4));
                }
                else if (hasil > 25)
                {
                    Console.WriteLine("" + ((hasil / stik) + hasil + 2));
                }
                else
                {
                    Console.WriteLine("" + ((hasil / stik) + hasil + 1));
                }
                
            }
            else if(hasil<5)
            {
                Console.WriteLine("" +hasil);
               
            }
        }

        static void Kelomokkan()
        {
            string kata = Console.ReadLine().ToLower();
            char[] charArray = kata.ToCharArray();
            List<char> chars= new List<char>();
            for (int i = 0; i < charArray.Length; i++)
            {
                chars.Add(charArray[i]);
            }
            chars.Sort();
        
            
            chars.Remove(' ');
            Console.WriteLine(String.Join("-",chars));
        }

        static void Fibonaci()
        {
            Console.Write("Please enter Fibonacci Series: ");
            int number = int.Parse(Console.ReadLine());
            FibonacciSeries(1, 1, number);
            Console.WriteLine(String.Join(" ", numbers));
            Console.Write(String.Join(" ", values.Count));
            Console.ReadKey();

        }

        static List<int> numbers = new List<int>();
        static List<int> values = new List<int>();

        public static void FibonacciSeries(int firstNumber, int secondNumber, int number)
        {
            if (firstNumber < number)
            {
                numbers.Add(firstNumber);
                if (firstNumber % 2 == 0)
                {
                    values.Add(firstNumber);
                }
                FibonacciSeries(secondNumber, firstNumber + secondNumber, number);
            }
        }    
        
        public static void kelipatan()
        {
            int x = int.Parse(Console.ReadLine());
            List<int> ar = new List<int>();
            List<int> ar2 = new List<int>();
            int i = 0;
            while (ar.Count < x)
            {
                i += 3;
                if (i % 2 == 0)
                {
                    ar.Add(i);
                }
            }
            foreach (int c in ar)
            {
                if(c % 4 == 0)
                {
                    ar2.Add(c);
                }
                
            }
            ar.Reverse();
            ar2.Reverse();
            Console.WriteLine(String.Join(" ", ar));
            Console.WriteLine(String.Join(" ", ar2));
        }

        static void Kubus()
        {
            Console.Write("Masukkan N: ");
            int n = int.Parse (Console.ReadLine());
            Console.Write("Masukkan M: ");
            int m = int.Parse (Console.ReadLine());
            double persegi = n * n;
            double kubus = (m * m)*6;
            
            double hasil = kubus / persegi;
            Console.WriteLine (hasil);
        }

        static void Gunung()
        {
            Console.WriteLine("Masukkan Kalimat: ");
            string kata = Console.ReadLine().ToUpper();
            char[] charArray = kata.ToCharArray();
            List<int> ar = new List<int>();
            int a = 0;
            int Naik = 0;
            int Turun = 0;
            for (int x = 0; x < charArray.Length; x++)
            {
                if (charArray[x] == 'N')
                {
                    a += 1;
                    ar.Add (a);
                }
                else if (charArray[x] == 'T')
                {
                    a -= 1;
                    ar.Add (a);
                }

                if (a == 0 && charArray[x]=='T')
                {
                    Naik++;
                }
                if (a == 0 && charArray[x] == 'N')
                {
                    Turun++;
                }
                //Console.Write(a);
            }
            Console.WriteLine(ar.Max());
            Console.WriteLine(ar.Min());
            Console.WriteLine(Naik);
            Console.WriteLine(Turun);
        }

        static void Perbandingan()
        {
            int[] alpa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
            string[] chars = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };


            for (int i = 0; i < alpa.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    //if (alpa[i] == chars[j])
                    {
                        Console.WriteLine(true);
                    }
                }
            }
        }

        static void Libur()
        {
            int Mary = int.Parse(Console.ReadLine());
            int Susan = int.Parse(Console.ReadLine());
            string awal = "25/02/2020";
            int a = Mary % Susan;
            int b = Mary % Susan;
            //while()
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Tanggal Libur Bersama: ");
            }
            else
            {
                if (Mary < Susan)
                {
                    Mary += Mary;
                }
                else
                {
                    Susan += Susan;
                }
            }
        }

        static void hargaBuah()
        {
            int semangka = 30000;
            int b = 20000;
            int pir = 10000;
            List<int> ar = new List<int>();
            Console.WriteLine("Nama buah: ");
            int a = 0;
            string x = Console.ReadLine().ToLower();
            foreach(char y in x)
            {
                if(y ==' ')
                {
                    a++;
                }
                ar.Add (y);
            }

            if (ar.Count<=3)
            {
                Console.WriteLine("harga buah per kg: " + pir);
            }
            else if(ar.Count <= 5 && ar.Count>3)
            {
                Console.WriteLine("harga buah per kg: " + b);
            }
            else
            {
                Console.WriteLine("harga buah per kg: " + semangka);
            }

        }

        static void jumlah()
        {
            Console.Write("Masukan Panjang deret: ");
            int x = int.Parse(Console.ReadLine());
            List<double> ar = new List<double>(x);
            List<double> ar2 = new List<double>(x);
            List<double> ar3 = new List<double>(x);
            double i = 0;
            int c = 0;
            while (ar.Count < x)
            {
                
                c= ((c + 3)-1);
                i= ((i + 4)/2);
                ar.Add(c);
                ar2.Add(i);
                ar3.Add(i + c);
                c = c+1;
                i = i *2;

            }
            Console.WriteLine(String.Join(" ", ar));
            Console.WriteLine(String.Join(" ", ar2));
            Console.WriteLine(String.Join(" ", ar3));
        }
    }   
}
