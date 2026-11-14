using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TaskTrecker.Enums;

namespace TaskTrecker.Entities
{
    public class Service
    {
        public int Id { get; private set; }
        public decimal Price { get; private set; }
        public ServiceType Category { get; private set; }

        public static Service CreateEntity(int id, decimal price, ServiceType category)
        {
            return new Service { Id = id, Price = price, Category = category };
        }
    }
}
