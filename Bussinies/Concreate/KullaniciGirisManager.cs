using Bussinies.Abstract;
using DataAcces.Abstract;
using Entity.Concreate;

namespace Bussinies.Concreate
{
    public class KullaniciGirisManager : IKullaniciGirisServices
    {
        IKullaniciGirisDAL kullaniciGirisDAL;
        public KullaniciGirisManager(IKullaniciGirisDAL kullaniciGirisDAL)
        {
            this.kullaniciGirisDAL = kullaniciGirisDAL;
        }

        public void add(KullaniciGiris KullaniciGiris)
        {
            kullaniciGirisDAL.add(KullaniciGiris);
        }

        public void delete(KullaniciGiris KullaniciGiris)
        {
            kullaniciGirisDAL.delete(KullaniciGiris);
        }

        public KullaniciGiris get(int KullaniciGirisID)
        {
            return kullaniciGirisDAL.get(x => x.ID == KullaniciGirisID);
        }

        public List<KullaniciGiris> GetAllOf()
        {
            return kullaniciGirisDAL.GetAll(x=>x.Durum==true);
        }

        public void update(KullaniciGiris KullaniciGiris)
        {
            kullaniciGirisDAL.update(KullaniciGiris);
        }
    }


}
