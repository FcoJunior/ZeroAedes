using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeroAedes.Data.Entity
{
    [Table("Focus")]
    public class FocusEntity : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // Navigation
        public virtual ICollection<PhotoEntity> Photos { get; set; }
    }
}
