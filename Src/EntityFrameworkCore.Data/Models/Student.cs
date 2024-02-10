using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SureName { get; set; }

        public DateTime BirthDate { get; set; }




        //Bire Bir İlişki İçin Özellik Tanımlaması 
        public int AddressId { get; set; }
        public virtual StudentAddress Address { get; set; }

        //for one to many property configuration
        public ICollection<Book> Books { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
