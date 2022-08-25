using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinies.Abstract
{
    public interface IAracServices
    {
        List<Arac> GetAllOf();
        Arac get(int AraclarID);
        void delete(Arac Araclar);
        void update(Arac Araclar);
        void add(Arac Araclar);
    }
}
