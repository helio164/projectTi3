using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projectTi3.Models
{
    [Table("Albums")]
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        //public List<int> PhotosId { get; set; }
        //[ForeignKey("PhotosId")]
        public virtual List<Photo> Photos { get; set; }
    }
}