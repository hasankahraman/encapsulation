using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Hasan";
            ogrenci1.Soyisim = "KAHRAMAN";
            ogrenci1.No = 12345678;
            ogrenci1.Sinif = 3;

            ogrenci1.BilgileriGetir();
            Console.ReadLine();

            ogrenci1.SinifAtlat();
            ogrenci1.BilgileriGetir();
            Console.ReadLine();

            Ogrenci ogrenci2 = new Ogrenci("Hakan", "KARAMAN", 123, -2);
            ogrenci2.BilgileriGetir();
            Console.ReadLine();

            ogrenci2.SinifDusur();
            ogrenci2.BilgileriGetir();
            Console.ReadLine();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public string Isim{
            get {return isim;}
            set {isim = value;}
        }

        public string Soyisim{
            get {return soyisim;}
            set {soyisim = value;}
        }

        public int No{
            get {return no;}
            set {no = value;}
        }

        public int Sinif{

            get {return sinif;}
            set {
                if(value<=1){
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }else
                sinif = value;
                }
        }

        public Ogrenci(){}

        public Ogrenci(string isim, string soyisim, int no, int sinif){

            this.Isim = isim;
            this.Soyisim = soyisim;
            this.No = no;
            this.Sinif = sinif;

        }

        public void BilgileriGetir(){
            Console.WriteLine("---Ogrenci Bilgileri---");
            Console.WriteLine("Adı: {0}", Isim);
            Console.WriteLine("Soyadı: {0}", Soyisim);
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Sınıfı: {0}", Sinif);
        }

        public void SinifAtlat(){
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur(){
            this.Sinif = this.Sinif - 1;
        }

    }
}
