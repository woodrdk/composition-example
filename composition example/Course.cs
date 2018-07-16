using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition_example
{
    class Course
    {
        public Course()
        {
            // if we wanted the instructor to be set to  an instructor object by default we can do 
            // this here in the constructor Teacher = new Instructor();
        }

        public int CourseID { get; set; }

        public String Title { get; set; }

        public byte NumCredits { get; set; }

        public Instructor Teacher { get; set; }
    }
}
