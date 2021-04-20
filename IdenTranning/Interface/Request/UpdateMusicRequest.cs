using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenTranning.Interface.Request
{
    public class UpdateMusicRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Single { get; set; }
        public int CateId { get; set; }
        public int Year { get; set; }
    }
}
