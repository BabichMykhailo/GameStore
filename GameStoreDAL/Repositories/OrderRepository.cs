using GameStoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Repositories
{
    public interface IOrderRepository
    {
        void Create(Order model);
        void Update(Order model);
        void Delete(int id);
        Order GetById(int id);
        IEnumerable<Order> GetAll();
    }

    public class OrderRepository : GenericRepository<Order, int>, IOrderRepository
    {
        public override IEnumerable<Order> GetAll()
        {
            return _table.Include(x => x.Games).ToList();
        }

        
    }
}
