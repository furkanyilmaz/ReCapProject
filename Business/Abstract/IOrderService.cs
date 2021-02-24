using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetCarsOrderdId(int OrderId);

        List<Order> Add();
        List<Order> Delete();
        List<Order> Update();
    }
}
