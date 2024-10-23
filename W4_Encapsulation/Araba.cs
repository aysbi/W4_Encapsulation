using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_Encapsulation
{
    public class Araba // araba sinifini olusturduk 
    {
        private string _brand; //private olmasinin sebebi disaridan manipule edilmemesini saglamak ve encapsulasion kisminda 
        private string _model; //if kosullarini sagladigi durumlarda deger atabilmek 
        private string _color;
        private int _numberOfDoors;

        public Araba (string brand, string model, string color, int numberOfDoors)
        {
            _brand = brand; //burada direkt constructor icerisine yazilmis model ve markayi alip iceri atayabiliriz
            _model = model;
            Color = color;  // fakat renk ve kapi sayisi icin kontrol etmemiz gereken parametreler oldugu icin direkt olarak setter'a yonlendiriyoruz burada
            NumberOfDoors = numberOfDoors;
        }

        public string Brand { get { return _brand; } } //sadece okunabilir yazilamaz 
        public string Model { get { return _model; } }
        public string Color 
        {
            get { return _color; }
            set //setterda renk bosluk veya null girilirse uyari mesaji yazip renksiz olarak geciriyor
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _color = value;
                } else
                {
                    Console.WriteLine("Gecerli bir renk giriniz");
                    _color = "Renksiz";
                }
            }
        }
        public int NumberOfDoors 
        {
            get { return _numberOfDoors; }  // kapi sayisi 2 veya 4 girilmediginde kapi sayisini -1 gosterip hata mesaji veriyor
            set
            {
                if (value == 2 || value == 4)
                { 
                    _numberOfDoors = value;
                } 
                else
                {
                    Console.WriteLine("Yanlis bir kapi sayisi girdiniz");
                    _numberOfDoors--;
                }
            }
        }

        public void Display() //butun hepsini tek bir noktada gorebilmek adina yazilmis bir metot
        {
            Console.WriteLine($"marka : {_brand} \r\nModel : {_model} \r\nRenk : {_color} \r\nKapi Sayisi: {_numberOfDoors} \r\n-----------------");
        }
    }
}
