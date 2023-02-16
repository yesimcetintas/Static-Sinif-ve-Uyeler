
Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);

Calisan calisan = new Calisan("Yeşim", "Çetintaş", "İK");

Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);

Console.WriteLine("Toplama İşlemi Sonucu: {0}",Islemler.Topla(200,10));
Console.WriteLine("Çıkarma İşlemi Sonucu: {0}",Islemler.Cikar(200,10));

class Calisan{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;
    private string Soyadi;
    private string Departman;

    static Calisan(){
        calisanSayisi=0;
    }

    public Calisan(string isim, string soyadi, string departman)
    {
        Isim = isim;
        Soyadi = soyadi;
        Departman = departman;
        calisanSayisi ++;
    }


}

static class Islemler{
    public static long Topla(int sayi1, int sayi2){
        return sayi1 + sayi2;
    }
    public static long Cikar(int sayi1, int sayi2){
        return sayi1 - sayi2;
    }
}
