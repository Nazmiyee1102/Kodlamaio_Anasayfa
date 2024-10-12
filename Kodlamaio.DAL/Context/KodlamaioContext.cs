using Kodlamaio.Entity.Entities;
using Kodlamaio.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DAL.Context
{
    public class KodlamaioContext : DbContext
    {
        public KodlamaioContext(DbContextOptions<KodlamaioContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<AllCourse> AllCourses { get; set; }

        public DbSet<Career> Careers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }


}
