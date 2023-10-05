using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetmicroserviceone.Models
{
    public class OrderDbContext:DbContext
    {
       public OrderDbContext(DbContectOptions<OrderDbContext> options):base(options)

       {
        
       } 
       public DbSet<Order> Orders {get; set;}
    }
}