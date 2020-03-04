using Data.Entity;
using Data.Infrastructure;
using PMSApplication.Data.Infrastructure;
using PMSApplication.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceServices : Service<Service>, IserviceServices
    {
        private static IDatabaseFactory dbfactory = new DatabaseFactory();
        private static IUnitOfWork UOW = new UnitOfWork(dbfactory);
        public ServiceServices() : base(UOW)
        {
        }
    }
}
