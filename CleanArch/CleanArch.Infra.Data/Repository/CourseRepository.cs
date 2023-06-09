﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{

    public class CourseRepository : ICourseRepository
    {

        private UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext ctx)
        {
                
            _ctx = ctx;
        }
<<<<<<< Updated upstream
        public IEnumerable<Course> GetCourses()
=======

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
>>>>>>> Stashed changes
        {
            return _ctx.Courses;
        }
    }
}
