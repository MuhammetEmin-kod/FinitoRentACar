using Bussinies.Abstract;
using DataAcces.Abstract;
using Entity.Concreate;

namespace Bussinies.Concreate
{
    public class MusteriManager : IMusterilerServices
    {
        IMusteriDAL musterilerDAL;
        public MusteriManager(IMusteriDAL musterilerDAL)
        {
            this.musterilerDAL = musterilerDAL;
        }

        public void add(Musteri musteriler)
        {
            musterilerDAL.add(musteriler);
        }

        public void delete(Musteri Musteriler)
        {
            musterilerDAL.delete(Musteriler);
        }

        public Musteri get(string MusterilerID)
        {
            return musterilerDAL.get(x => x.Tc == MusterilerID);
        }

        public List<Musteri> GetAllOf()
        {
            return musterilerDAL.GetAll(x => x.Durum == true);
        }

        public void update(Musteri Musteriler)
        {

            musterilerDAL.update(Musteriler);
        }
    }


}
