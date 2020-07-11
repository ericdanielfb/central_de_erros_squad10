using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralDeErros.API.Models
{
    public class Environment
    {
        public int Id { get; set; }
        public string Phase { get; set; }

        public ICollection<Occurrence> Occurrences { get; set; }

    }
}
