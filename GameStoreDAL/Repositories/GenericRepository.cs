using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Repositories
{
    public interface IEntity
    {
        int Id { get; set; }
    }
    public interface IGenericRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T model);
        void Update(T model);
        void Delete(int id);
    }
    public abstract class GenericRepository<T, TId> : IGenericRepository<T> where T : class, IEntity
    {
        protected DbContext _ctx;
        protected DbSet<T> _table;
        public GenericRepository()
        {
            _ctx = new GameStoreContext();
            _table = _ctx.Set<T>();
        }
        public void Create(T model)
        {
            _table.Add(model);
            _ctx.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = _table.FirstOrDefault(x => x.Id.Equals(id));
            _table.Remove(entity);
            _ctx.SaveChanges();
        }
        public abstract IEnumerable<T> GetAll();

        public T GetById(int id)
        {
            return _table.FirstOrDefault(x => x.Id.Equals(id));
        }
        public void Update(T model)
        {
            _ctx.Entry(model).State = EntityState.Modified;
            _ctx.SaveChanges();
        }
    }
}
