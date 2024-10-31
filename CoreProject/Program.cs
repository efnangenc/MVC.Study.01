public record UrunRecord(int id, string Ad, decimal Fiyat);
//{
//    public int Id { get; set; }
//    public string Ad { get; set; }
//    public decimal Fiyat { get; set; }
//}

public class UrunClass
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }
}

internal class Program
{
    static void Main(string[] args)
    {
        var urun1 = new UrunClass() { Id = 1, Ad = "PC", Fiyat = 250m };
        var urun2 = new UrunClass() { Id = 1, Ad = "PC", Fiyat = 250m };

        Console.WriteLine(urun1 == urun2 ? "ürün değeri eşittir" : "ürün değeri eşit değildir.");

        var urunRecord1 = new UrunRecord(1, "PC", 250m);
        var urunRecord2 = new UrunRecord(1, "PC", 250m);

        Console.WriteLine(urunRecord1 == urunRecord2 ? "ürün değeri eşittir" : "ürün değeri eşit değildir.");

        var degistirilmisRecord = urunRecord1 with { Ad = "TB" };

        Console.WriteLine(degistirilmisRecord.Ad);

        Console.ReadKey();
    }
}