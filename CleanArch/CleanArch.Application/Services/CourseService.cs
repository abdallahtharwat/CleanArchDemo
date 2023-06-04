using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _Bus;
        public CourseService(ICourseRepository courseRepository , IMediatorHandler Bus )
        {
                 
            _courseRepository = courseRepository;
            _Bus = Bus; 
        }

        public void Craeate(CourseViewModel courseViewModel)
        {
            var CreateCourseCommand = new CreateCourseCommand
                (
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageUrl
                );
            _Bus.SendCommand(CreateCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
