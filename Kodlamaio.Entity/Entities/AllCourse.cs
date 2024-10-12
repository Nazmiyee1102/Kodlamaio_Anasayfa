using Kodlamaio.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Entity.Entity
{
    public class AllCourse
    {
        public int CourseId { get; set; }

        public string CourseImage { get; set; }

        public string CourseName { get; set; }

        public string Description { get; set; }

        public int? InstructorId { get; set; }

        public string InstructorName { get; set; }

        public string InstructorImage { get; set; }

        public Instructor Instructor { get; set; }

        public List<Instructor> Instructors { get; set; }
    }
}
