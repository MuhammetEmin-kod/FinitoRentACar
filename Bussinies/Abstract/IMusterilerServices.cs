using Entity.Concreate;

namespace Bussinies.Abstract
{
    public interface IMusterilerServices
    {
        List<Musteri> GetAllOf();
        Musteri get(string MusterilerID);
        void delete(Musteri Musteriler);
        void update(Musteri Musteriler);
        void add(Musteri musteriler);
    }
}
