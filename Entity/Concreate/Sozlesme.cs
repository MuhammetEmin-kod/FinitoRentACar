using Core.Entities;

namespace Entity.Concreate
{
    public class Sozlesme:IEntity
    {
        public int ID { get; set; }
        public string MusteriTC { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string Plaka { get; set; }
        public int KiraUcreti{ get; set; }
        public int Gun { get; set; }
        public int Tutar { get; set; }
        public DateTime VerilisTarih { get; set; }
        public DateTime AlinanTarih { get; set; }
        public bool Durum { get; set; }

    }
}
