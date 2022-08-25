using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccesGeneric
{
    public class EFRepositoryBase<Tentity,Tcontext>:IRepositoryBase<Tentity>
        where Tentity : class, IEntity,new()
        where Tcontext:DbContext,new()
    {

        public void add(Tentity entity)
        {
            using (Tcontext db = new Tcontext())
            {
                var AddEntity = db.Entry(entity);
                AddEntity.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void delete(Tentity entity)
        {
            using (Tcontext db = new Tcontext())
            {
                var DeleteEntity = db.Entry(entity);
                DeleteEntity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Tentity get(Expression<Func<Tentity, bool>> filter)
        {
            using (Tcontext db = new Tcontext())
            {
                return db.Set<Tentity>().SingleOrDefault(filter);
            }
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (Tcontext context = new Tcontext())
            {
                return filter == null ? context.Set<Tentity>().ToList() :
                    context.Set<Tentity>().Where(filter).ToList();
            }
        }

        public void update(Tentity entity)
        {
            using (Tcontext db = new Tcontext())
            {
               
                var updatedEntity = db.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                db.SaveChanges();

            }
        }
    }
}
