using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Presence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPresence { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [StringLength(25)]
        [Required]
        public string PresenceEmp { get; set; }

        public Employe employe { get; set; }
    }
}
