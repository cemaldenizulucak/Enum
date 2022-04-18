using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aldığı değeri ekrana vermek için int ekledik.
            Console.WriteLine((int)Kategoriler.Elektronik);
        }


        // Önemli bir yeri vardır çünkü tekrar yazımları kodları engeller hız ve verim kazandırır.
        enum Kategoriler
        {
            Gıda = 1,
            Hırdavat = 2,
            Elektronik = 3,
            Güzellik = 4,
            Giyim = 5      

        }
    }
}
