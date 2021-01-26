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
        IEnumerable<Order> GetAllOrders();
    }

    public class OrderRepository : GenericRepository<Order, int>, IOrderRepository
    {
        public IEnumerable<Order> GetAllOrders()
        {
            return GetAll().Include(x => x.Games).ToList();
        }

        public Order GetById(int id)
        {
            return _table.FirstOrDefault(x => x.Id == id);
        }
    }
}
