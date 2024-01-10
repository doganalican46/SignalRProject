using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    internal class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;
        public DiscountManager(IDiscountDal dicountDal)
        {
            _discountDal = dicountDal;
        }

        public void BAdd(Discount entity)
        {
            _discountDal.Add(entity);    
        }

        public void BDelete(Discount entity)
        {
            _discountDal.Delete(entity);    
        }

        public Discount BGetByID(int id)
        {
            return _discountDal.GetByID(id);
        }

        public List<Discount> BGetListAll()
        {
            return _discountDal.GetListAll();
        }

        public void BUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
