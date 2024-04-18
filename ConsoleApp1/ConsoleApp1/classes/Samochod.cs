using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    enum StatusSamochodu
    {
        Nowy,
        Uzywany,
        Zabytkowy
    }

    internal class Samochod
    {
        public string marka { get; set; }
        public string model { get; set; }
        public int rokProdukcji { get; set; }
        public double pojemnoscSilnika { get; set; }
        public bool czyDisel { get; set; }
        public DateTime dataZakupu { get; set; }
        public StatusSamochodu StatusSamochodu { get; set; }

        public static string domyslnyKolor;
        public static int domyslnyPrzebieg;

        static Samochod()
        {
            domyslnyKolor = "Biały";
            domyslnyPrzebieg = 0;
        }
        public Samochod()
        {
            marka = "Ford";
            model = "Focus";
            rokProdukcji = 2020;
            pojemnoscSilnika = 2.0;
            czyDisel = false;
            dataZakupu = new DateTime(2020,01,01);
            StatusSamochodu = StatusSamochodu.Nowy;
        }
        public Samochod(string Marka, string Model, int RokProdukcji)
        {
            marka = Marka;
            model = Model;
            rokProdukcji = RokProdukcji;
        }
        public Samochod(string Marka, string Model, int RokProdukcji, double PojemnoscSilnika) : this(Marka, Model, RokProdukcji)
        {
            pojemnoscSilnika = PojemnoscSilnika;
        }
        public Samochod(string Marka, string Model, int RokProdukcji, double PojemnoscSilnika, bool CzyDisel) : this(Marka, Model, RokProdukcji, PojemnoscSilnika)
        {
            czyDisel = CzyDisel;
        }

        public string WyswietlInformacje()
        {

        }
    }
}
