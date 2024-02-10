﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Name { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

    }
}
