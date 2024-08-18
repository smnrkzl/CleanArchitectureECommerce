using CleanArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Order:Entity
    {
        public int OrderId { get; set; } 
        public string Description { get; set; }
        public string Address { get; set; }
        public string OrderCode { get; set; }
        
    }
}
