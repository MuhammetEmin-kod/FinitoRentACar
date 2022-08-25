using Entity.Concreate;

namespace Bussinies.Abstract
{
    public interface IKullaniciGirisServices
    {
        List<KullaniciGiris> GetAllOf();
        KullaniciGiris get(int KullaniciGirisID);
        void delete(KullaniciGiris KullaniciGiris);
        void update(KullaniciGiris KullaniciGiris);
        void add(KullaniciGiris KullaniciGiris);
    }
}
