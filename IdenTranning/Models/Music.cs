using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdenTranning.Models
{
    public class Music
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        public string Single { get; set; }
        [Required]
        [ForeignKey("Category")]
        public int CategoriesId { get; set; }
        [DataType(DataType.Date)]
        public int Year { get; set; }
    }
}
