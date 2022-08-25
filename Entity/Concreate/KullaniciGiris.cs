using Core.Entities;

namespace Entity.Concreate
{
    public class KullaniciGiris:IEntity
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public bool Durum { get; set; }
    }
}
