using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenTranning.Models
{
    public class Album
    {
        public int Id { get; set; }
        public List<Music> ListSing { get; set; }
        public decimal Price { get; set; }


    }
}
