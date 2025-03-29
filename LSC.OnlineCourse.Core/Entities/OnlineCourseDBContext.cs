using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LSC.OnlineCourse.Core.Entities;

public partial class OnlineCourseDBContext : DbContext
{
    public OnlineCourseDBContext(){

    }
    public OnlineCourseDBContext(DbContextOptions<OnlineCourseDBContext> options):base(options){

    }
    public virtual DbSet<Course> Courses{get; set;}
        public virtual DbSet<CourseCategory> CourseCategories{get; set;}
    public virtual DbSet<Envirollment> Envirollments{get; set;}
    public virtual DbSet<Instructor> Instructors{get; set;}
    public virtual DbSet<Payment> Payments{get; set;}
    public virtual DbSet<Course> Courses{get; set;}

}
