using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entity.Concreate
{
    public class Satis:IEntity
    {
        public int ID{ get; set; }
        public DateTime Gun { get; set; }
        public int ToplamTutar { get; set; }
    }
}
