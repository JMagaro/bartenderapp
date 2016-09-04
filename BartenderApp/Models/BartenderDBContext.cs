using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BartenderApp.Models
{
    public class BartenderDbContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}