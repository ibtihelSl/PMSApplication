using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Service
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idService { get; set; }

        [StringLength(50)]
        public string TypeService { get; set; }

        public int NbrEmployee { get; set; }

        public virtual ICollection<Employe> employes { get; set; }

        public virtual ICollection<Site> sites { get; set; }

    }
}
