using Bussinies.Abstract;
using DataAcces.Abstract;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinies.Concreate
{
    public class AracManager:IAracServices
    {

        IAracDAL iaraclarDal;
        public AracManager(IAracDAL iaraclarDal)
        {
            this.iaraclarDal = iaraclarDal;
        }

        public void add(Arac Araclar)
        {
            iaraclarDal.add(Araclar);
        }

        public void delete(Arac Araclar)
        {
            iaraclarDal.delete(Araclar);
        }

        public Arac get(int AraclarID)
        {
            return iaraclarDal.get(x => x.ID == AraclarID);
        }

        public List<Arac> GetAllOf()
        {
            return iaraclarDal.GetAll(x => x.Durum == true);

        }

        public void update(Arac Araclar)
        {
            iaraclarDal.update(Araclar);
        }
    }


}
