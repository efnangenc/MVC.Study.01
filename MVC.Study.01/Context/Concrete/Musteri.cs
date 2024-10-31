using System.Security.Principal;

namespace MVC.Study._01.Context.Concrete
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public ICollection<Siparis> Siparisler { get; set; }

    }
}
