using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
   public class Employe : User
    {
        public virtual ICollection<Presence> presence { get; set; }
        public virtual Service service { get; set; }

    }
}
