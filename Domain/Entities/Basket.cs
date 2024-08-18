using CleanArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Basket:Entity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public Order Order { get; set; }
    }
}
