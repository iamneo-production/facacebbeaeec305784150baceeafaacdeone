using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace dotnetmicroserviceone.Models
{
    public class OrderDbContext:DbContext
    {
       public OrderDbContext(DbContextOptions<OrderDbContext> options):base(options)

       {
        
       } 
       public DbSet<Order> Orders {get; set;}
    }
}