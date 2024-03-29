﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Writer
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurname { get; set; }

        [StringLength(500)]
        public string WriterImage { get; set; }

        [StringLength(100)]
        public string WriterAbout { get; set; }

        [StringLength(200)]
        public string WriterMail { get; set; }

        [StringLength(200)]
        public string WriterPassword { get; set; }

        [StringLength(50)]
        public string WriterTitle { get; set; }

        public bool WriterStatus { get; set; }

        // ilişkiler heading için

        public ICollection<Heading> Headings { get; set; } //1--

        // ilişkiler content için
        public ICollection<Content> Contents { get; set; } //1--
    }
}
