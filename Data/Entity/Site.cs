using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Site
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idSite { get; set; }


        [StringLength(25)]
        [Required]
        public string Nom { get; set; }

        public virtual ICollection<Service> services { get; set; }
    }
}
