using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRickNMorty.Models
{
    public class Page<T>
    {
        public PageInfo Info { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}
