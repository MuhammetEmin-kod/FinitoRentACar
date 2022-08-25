using Bussinies.Abstract;
using DataAcces.Abstract;
using Entity.Concreate;

namespace Bussinies.Concreate
{
    public class SozlesmeManager : ISozlesmeServices

    {
        ISozlesmeDAL sozlesmeDAL;
        public SozlesmeManager(ISozlesmeDAL sozlesmeDAL)
        {
            this.sozlesmeDAL = sozlesmeDAL;
        }

        public void add(Sozlesme sozlesme)
        {
            sozlesmeDAL.add(sozlesme);
        }

        public void delete(Sozlesme Sozlesme)
        {
            sozlesmeDAL.delete(Sozlesme);
        }

        public Sozlesme get(int SozlesmeID)
        {
            return sozlesmeDAL.get(x => x.ID == SozlesmeID);
        }

        public List<Sozlesme> GetAllOf()
        {
            return sozlesmeDAL.GetAll(x=>x.Durum==true);
        }

        public void update(Sozlesme Sozlesme)
        {
            sozlesmeDAL.update(Sozlesme);
        }
    }


}
