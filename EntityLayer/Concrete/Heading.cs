using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        // ilişki category için

        public bool HeadingStatus { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } // sonsuz

        public ICollection<Content> Contents { get; set; } //1--

        // ilişki writer için
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
