using Entity.Concreate;

namespace Bussinies.Abstract
{
    public interface ISatislarServices
    {
        List<Satis> GetAllOf();
        void delete(Satis Satislar);
        void update(Satis Satislar);
        void add(Satis Satislar);
    }
}
