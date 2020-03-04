using Data.Entity;
using Data.Infrastructure;
using PMSApplication.Data.Infrastructure;
using PMSApplication.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Services;

namespace Services
{
    public class ServiceSite : Service<Site>, ISeviceSite
    {
        private static IDatabaseFactory dbfactory = new DatabaseFactory();
        private static IUnitOfWork UOW = new UnitOfWork(dbfactory);
        public ServiceSite() : base(UOW)
        {
        }
    }
}
