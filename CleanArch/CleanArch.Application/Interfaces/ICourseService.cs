﻿using CleanArch.Application.ViewModel;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
<<<<<<< Updated upstream
        CourseViewModel GetCourses();
=======
        IEnumerable<CourseViewModel> GetCourses();
        void Create(CourseViewModel courseViewModel);

>>>>>>> Stashed changes
    }
}
