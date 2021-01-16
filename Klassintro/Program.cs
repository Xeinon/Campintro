using System;

namespace Klassintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Cengizhan";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Jack";
            kurs2.izlenmeOrani = 69;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ali";
            kurs3.izlenmeOrani = 80;

            //Console.WriteLine(kurskurs1.KursAdi + " : " + 1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public  int izlenmeOrani { get; set; }
    }

}
