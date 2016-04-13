using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeroAedes.Data.Entity
{
    [Table("Photo")]
    public class PhotoEntity : Entity
    {
        public string Url { get; set; }
        public int FocusId { get; set; }

        // Navigation
        [ForeignKey("FocusId")]
        public virtual FocusEntity Focus { get; set; }
    }
}
