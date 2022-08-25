using Bussinies.Abstract;
using DataAcces.Abstract;
using Entity.Concreate;

namespace Bussinies.Concreate
{
    public class SatisManager : ISatislarServices
    {
        ISatisDAL satislarDAL;
        public SatisManager(ISatisDAL satislarDAL)
        {
            this.satislarDAL = satislarDAL;
        }

        public void add(Satis Satislar)
        {
            satislarDAL.add(Satislar);
        }

        public void delete(Satis Satislar)
        {
            satislarDAL.delete(Satislar);
        }

    

        public List<Satis> GetAllOf()
        {
            return satislarDAL.GetAll();
        }

        public void update(Satis Satislar)
        {
            satislarDAL.update(Satislar);
        }
    }


}
