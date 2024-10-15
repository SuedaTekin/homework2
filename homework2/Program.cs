using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Ogrenci
{
    private int ogrenciNo;
    private string isim;
    private string soyisim;
    private double vize1;
    private double vize2;
    private double final;
    private string okulismi;

    public Ogrenci(int ogrenciNo, string isim, string soyisim, double vize1, double vize2, double final, string okulismi)
    {
        this.ogrenciNo = ogrenciNo;
        this.isim = isim;
        this.soyisim = soyisim;
        this.vize1 = vize1;
        this.vize2 = vize2;
        this.final = final;
        this.okulismi = okulismi;
    }

    public void OgrenciBilgileriGoster()
    {
        Console.WriteLine("Öğrenci No: " + ogrenciNo);
        Console.WriteLine("İsim: " + isim);
        Console.WriteLine("Soyisim: " + soyisim);
        Console.WriteLine("Vize 1: " + vize1);
        Console.WriteLine("Vize 2: " + vize2);
        Console.WriteLine("Final: " + final);
        Console.WriteLine("Okul İsmi: " + okulismi);
    }

    public double OgrenciOrtalamasiBul()
    {
        return (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);
    }

    public string OkulGetir()
    {
        return okulismi;
    }
}

class Program
{
    static void Main()
    {
        Ogrenci ogrenci = new Ogrenci(12345, "Jessica", "Mayel", 20.0, 60.0, 98.0, "AbCd Üniversitesi");

        while (true)
        {
            Console.WriteLine("1- Öğrenci Bilgileri Göster");
            Console.WriteLine("2- Öğrenci Ortalaması Göster");
            Console.WriteLine("3- Öğrencinin Okulunu Öğren");
            Console.WriteLine("4- Çıkış Yap");
            Console.Write("Seçiminizi yapınız: ");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    ogrenci.OgrenciBilgileriGoster();
                    break;
                case 2:
                    Console.WriteLine("Öğrenci Ortalaması: " + ogrenci.OgrenciOrtalamasiBul());
                    break;
                case 3:
                    Console.WriteLine("Öğrencinin Okulu: " + ogrenci.OkulGetir());
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Geçersiz seçimdir, lütfen tekrar deneyiniz.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

