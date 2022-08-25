using Core.Entities;

namespace Entity.Concreate
{
    public class Musteri:IEntity
    {
        public int ID { get; set; }
        public string Tc { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public bool Durum { get; set; }
    }
}
