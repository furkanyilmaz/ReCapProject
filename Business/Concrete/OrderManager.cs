using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> Add()
        {
            throw new NotImplementedException();
        }

        public List<Order> Delete()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetCarsOrderdId(int OrderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> Update()
        {
            throw new NotImplementedException();
        }
    }
}
