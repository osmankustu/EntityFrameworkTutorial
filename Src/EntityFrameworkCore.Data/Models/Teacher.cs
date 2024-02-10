using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SureName { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
