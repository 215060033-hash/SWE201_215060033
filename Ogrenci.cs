using System;

public class Ogrenci
{
    // Üye değişkenler
    private string ad;
    private int yas;

    // Otomatik özellikler
    public string Bolum { get; set; }
    public double Ortalama { get; set; }

    // Parametresiz kurucu
    public Ogrenci()
    {
        ad = "Bilinmiyor";
        yas = 0;
        Bolum = "Yazılım Mühendisliği";
        Ortalama = 0.0;
    }

    // Parametre alan kurucu
    public Ogrenci(string ad, int yas, string bolum, double ortalama)
    {
        this.ad = ad;
        this.yas = yas;
        Bolum = bolum;
        Ortalama = ortalama;
    }

    // Not güncelleme fonksiyonu
    public void OrtalamaGuncelle(double yeniOrtalama)
    {
        Ortalama = yeniOrtalama;
    }

    // ToString override
    public override string ToString()
    {
        return $"Ad: {ad}, Yaş: {yas}, Bölüm: {Bolum}, Ortalama: {Ortalama}";
    }
}
