using Data.Infrastructure;
using PMSApplication.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;
using PMSApplication.Data.Infrastructure;

namespace PMSApplication.Services.Message
{
    public class ServiceMessage : Service<Data.Entity.Message>, IServiceMessage
    {
        private static IDatabaseFactory dbfactory = new DatabaseFactory();
        //private static IUnitOfWork U = new UnitOfWork(dbfactory);
        private static IUnitOfWork UOW = new UnitOfWork(dbfactory);

        public ServiceMessage():base(UOW)
        {

        }
    }
}
