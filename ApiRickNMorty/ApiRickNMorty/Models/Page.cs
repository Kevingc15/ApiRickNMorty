using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ApiRickNMorty.Models
{
    public class Page<T>
    {
        public PageInfo Info { get; set; }
        public List<T> Results { get; set; }
    }
}
