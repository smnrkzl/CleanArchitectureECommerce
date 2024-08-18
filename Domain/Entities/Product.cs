using CleanArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Product:Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
