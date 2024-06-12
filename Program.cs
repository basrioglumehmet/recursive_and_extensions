using System;
namespace recursive_and_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 7;
            int number2 = 7;
            int number3 = 7;
            Console.WriteLine(number1.Factorial());
            Console.WriteLine(number2.Factorial());
            Console.WriteLine(number3.Factorial());
        }
    }

    /*
        Extension(Genişletilmiş) Metot Kullanımı
        Extension Metotların kelime anlamı genişletilebilir metotlardır. C# 3.0 ile hayatımıza giren, aynı kodu defalarca yazmak yerine, bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.

        Extension metot yazarken dikkat etmemiz gereken bir kaç kural vardır. Şu şekilde :

        Static bir class içerisinde static bir metot olarak yazılmalılar.
        Extension metod da tanımlı parametrelerden sadece 1 tanesi this ile tanımlanabilir.
    */
    public static class IntExtensionClass
    {
        /// <summary>
        /// Rekürsif olarak faktoriyel hesaplama işlemini yapar.  n! =  n*(n - 1) * n*(n - 2) n*(n - 3) * .... * 3 * 2 * 1
        /// </summary>
        public static int Factorial(this int n)
        {
            if (n == 0) return 1; //Dikkat burası 1 olmalıdır çünkü 0 verirseniz sonucu her zaman sıfır olacaktır dolayısıyla her zaman 1! eşit olmalı.
            return n * Factorial(n - 1);
        }
    }
}