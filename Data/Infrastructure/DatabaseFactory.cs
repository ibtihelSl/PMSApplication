using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSApplication.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Data.pmsContext dataContext;
        public Data.pmsContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new Data.pmsContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }

    }
}
