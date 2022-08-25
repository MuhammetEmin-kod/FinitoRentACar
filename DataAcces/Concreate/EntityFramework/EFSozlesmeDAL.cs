using Core.DataAccesGeneric;
using DataAcces.Abstract;
using Entity.Concreate;

namespace DataAcces.Concreate.EntityFramework
{
    public class EFSozlesmeDAL : EFRepositoryBase<Sozlesme, FinitoContext>, ISozlesmeDAL { }


}
