using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projectTi3.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        
        public string Id { get; set; }
        [ForeignKey("Id")]
        public virtual ApplicationUser AppUser { get; set; }

        public virtual List<Album> Albums { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}