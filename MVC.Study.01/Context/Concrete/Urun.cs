namespace MVC.Study._01.Context.Concrete
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public ICollection<Siparis> Siparisler { get; set; }
    }
}
