using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KurssAdi = "C#";
            kurs1.Egitmeni = "Cengizhan Anar";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs1.KursAdi = "java";
            kurs1.Egitmeni = "Cengizhan Anar";
            kurs1.izlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.Egitmeni = "Cengizhan Anar";
            kurs1.izlenmeOrani = 68;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);


        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        
        public string Egitmeni { get; set; }

        public int izlenmeOrani { get; set; }
    }
}

