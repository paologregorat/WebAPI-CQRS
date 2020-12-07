using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_CQRS.Domain.Entity
{
    public class Widget
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Shape { get; set; }
    }
}
