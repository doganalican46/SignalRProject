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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void BAdd(Product entity)
        {
            _productDal.Add(entity);    
        }

        public void BDelete(Product entity)
        {
            _productDal.Delete(entity); 
        }

        public Product BGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> BGetListAll()
        {
            return _productDal.GetListAll();
        }

        public void BUpdate(Product entity)
        {
            _productDal.Update(entity); 
        }
    }
}
