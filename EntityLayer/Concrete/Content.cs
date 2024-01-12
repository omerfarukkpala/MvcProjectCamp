using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public bool ContentStatus { get; set; }

        // content yazar
        // content başlık

        // ilişki heading

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; } // sonsuz

        // ilişki writer
        // ? boş geçilebilir

        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; } // sonsuz
    }
}
