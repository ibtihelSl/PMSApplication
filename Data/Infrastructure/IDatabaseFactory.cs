using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSApplication.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        pmsContext DataContext { get; }
    }
}
