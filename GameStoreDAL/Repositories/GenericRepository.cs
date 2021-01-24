using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Repositories
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
    public interface IGenericRepository<T, TId> where T : class, IEntity<TId>
    {
        IEnumerable<T> GetAll();
        T GetById(TId id);
        void Create(T model);
        void Update(T model);
        void Delete(TId id);
    }
    public class GenericRepository<T, TId> : IGenericRepository<T, TId> where T : class, IEntity<TId>
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
        public void Delete(TId id)
        {
            var entity = _table.FirstOrDefault(x => x.Id.Equals(id));
            _table.Remove(entity);
            _ctx.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }
        public T GetById(TId id)
        {
            return _table.FirstOrDefault(x => x.Id.Equals(id));
        }
        public void Update(T model)
        {
            //_table.AddOrUpdate(model);
            //_ctx.SaveChanges();
        }
    }
}
