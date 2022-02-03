using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //RecursiveFunctiom
           //3^4

           int result =1;

           for(int i =1;i<5;i++)
           result=result*3;

           Console.WriteLine(result);
           Islemler instance = new();
           Console.WriteLine(instance.Expo(3,4));


            //Extension

            string ifade = "Gökhan Çam";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(sonuc);
            if(sonuc)
            {

                Console.WriteLine(ifade.RemoveWhiteSpace());
                Console.WriteLine(ifade.toUpper());
                Console.WriteLine(ifade.toLower());
            }


            int[] dizi = {56,34,789,23,897,23};
            dizi.SortArray();
            dizi.EkranaYazdir();


            int sayi = 42;
            Console.WriteLine(sayi.evenNumber());


            Console.WriteLine(ifade.getFirstChracter());


        }
    }

    public class Islemler{


        public int Expo(int sayi, int üs)
        {
             if(üs<2)
             return sayi;
             return Expo(sayi,üs-1)*sayi;
        }
    }


    public static class Extension
    {

        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpace(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string toUpper(this string param)
        {
            return param.ToUpper();
        }

        public static string toLower(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach(int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool evenNumber(this int param)
        {
            return param%2 ==0;
        }

        public static string getFirstChracter(this string param)
        {
            return param.Substring(0,5);
        }

    }

}