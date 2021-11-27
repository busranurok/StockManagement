using System;
using System.Collections.Generic;
using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Concrete
{
    public class ECommerceSiteManager : IECommerceSiteService
    {

        IECommerceSiteDal _eCommerceSiteDal;

        public ECommerceSiteManager(IECommerceSiteDal eCommerceSiteDal)
        {
            _eCommerceSiteDal = eCommerceSiteDal;
        }

        public void Add(ECommerceSite eCommerceSite)
        {
            _eCommerceSiteDal.Add(eCommerceSite);
        }

        public void Delete(ECommerceSite eCommerceSite)
        {
            _eCommerceSiteDal.Delete(eCommerceSite);
        }

        public List<ECommerceSite> GetAllECommerceSites()
        {
            return _eCommerceSiteDal.GetAll();
        }

        public ECommerceSite GetById(int eCommerceSiteId)
        {
            return _eCommerceSiteDal.Get(filter: ecm => ecm.Id == eCommerceSiteId, true);
        }

        public void Update(ECommerceSite eCommerceSite)
        {
            _eCommerceSiteDal.Update(eCommerceSite);
        }
    }
}
