using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IGenericService<T>where T : class
    {
        void BAdd(T entity);
        void BDelete(T entity);
        void BUpdate(T entity);
        T BGetByID(int id);
        List<T> BGetListAll();
    }
}
