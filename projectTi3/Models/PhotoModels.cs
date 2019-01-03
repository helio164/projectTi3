using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projectTi3.Models
{
    [Table("Photos")]
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public byte[] Thumbnail { get; set; }
        public byte[] Image { get; set; }

        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }
    }
}