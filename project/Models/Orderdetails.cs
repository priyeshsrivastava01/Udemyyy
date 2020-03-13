using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Orderdetails { 
    
        [Key]
        public int OrderDetailId { get; set; }
        
        public int CourseId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public courses course { get; set; }
       // public int OrderId { get; set; }
        //public Order Order { get; set; }
        public ICollection<Order> order { get; set; }
    }
}
