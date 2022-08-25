using Core.DataAccesGeneric;
using DataAcces.Abstract;
using Entity.Concreate;

namespace DataAcces.Concreate.EntityFramework
{
    public class EFKullaniciGirisDAL : EFRepositoryBase<KullaniciGiris, FinitoContext>, IKullaniciGirisDAL { }


}
