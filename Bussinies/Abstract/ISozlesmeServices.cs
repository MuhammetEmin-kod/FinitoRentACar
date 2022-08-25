using Entity.Concreate;

namespace Bussinies.Abstract
{
    public interface ISozlesmeServices
    {
        List<Sozlesme> GetAllOf();
        Sozlesme get(int SozlesmeID);
        void delete(Sozlesme Sozlesme);
        void update(Sozlesme Sozlesme);
        void add(Sozlesme Sozlesme);
    }
}
