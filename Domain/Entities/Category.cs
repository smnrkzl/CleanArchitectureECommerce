using CleanArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Category:Entity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public Product Product { get; set; }
    }
}
