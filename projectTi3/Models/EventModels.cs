using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projectTi3.Models
{
    [Table("Events")]
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}