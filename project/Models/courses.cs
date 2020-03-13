﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class courses
    {
        [Key]
        public int CourseId { get; set; }


        public string Name { get; set; }

        public decimal Price { get; set; }


        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public virtual Category Category { get; set; }

        public bool IsCourseOfTheWeek { get; set; }
      //  public int OrderId { get; set; }
    }
}
