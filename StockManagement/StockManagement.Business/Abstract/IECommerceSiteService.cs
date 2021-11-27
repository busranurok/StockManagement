using System;
using System.Collections.Generic;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Abstract
{
    public interface IECommerceSiteService
    {
        ECommerceSite GetById(int eCommerceSiteId);
        List<ECommerceSite> GetAllECommerceSites();
        void Add(ECommerceSite eCommerceSite);
        void Update(ECommerceSite eCommerceSite);
        void Delete(ECommerceSite eCommerceSite);
    }
}
