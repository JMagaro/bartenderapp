using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BartenderApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual Drink Drink { get; set; }
    }
}