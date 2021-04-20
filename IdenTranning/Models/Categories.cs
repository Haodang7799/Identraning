using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdenTranning.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CateName { get; set; }
    }
}
