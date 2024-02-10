using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data.Models
{
    public class StudentAddress
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Distric { get; set; }

        public string FullAddress { get; set; }

        public string Country { get; set; }


        //for one to one relationship property added 
        public virtual Student Student { get; set; }
    }
}
