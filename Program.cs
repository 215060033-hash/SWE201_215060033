using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("SWE201 PROJE - BURAK ONUR CAN ÇÖRTÜK - 215060033");
        Console.WriteLine("-----------------------------------------------");

        // Varsayılan kurucu ile nesne
        Ogrenci o1 = new Ogrenci();
        Console.WriteLine("\nVarsayılan Öğrenci:");
        Console.WriteLine(o1.ToString());

        // Parametreli kurucu ile nesne
        Ogrenci o2 = new Ogrenci("Öğrenci 2", 21, "Yazılım Mühendisliği", 2.95);
        Console.WriteLine("\nParametreli Öğrenci:");
        Console.WriteLine(o2.ToString());

        // Ortalama güncelleme
        Console.WriteLine("\nOrtalama Güncelleme:");
        o2.OrtalamaGuncelle(3.10);
        Console.WriteLine(o2.ToString());

        // Başka bir örnek
        Ogrenci o3 = new Ogrenci("Öğrenci 3", 20, "Yazılım Mühendisliği", 3.40);
        Console.WriteLine("\nBaşka Bir Öğrenci:");
        Console.WriteLine(o3.ToString());
    }
}
