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
    internal class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void BAdd(Feature entity)
        {
            _featureDal.Add(entity);    
        }

        public void BDelete(Feature entity)
        {
            _featureDal.Delete(entity); 
        }

        public Feature BGetByID(int id)
        {
            return _featureDal.GetByID(id); 
        }

        public List<Feature> BGetListAll()
        {
            return _featureDal.GetListAll();
        }

        public void BUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
