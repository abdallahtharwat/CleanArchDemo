using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
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
<<<<<<< Updated upstream
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
=======
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _Bus;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler Bus, IMapper mapper)
>>>>>>> Stashed changes
        {

            _courseRepository = courseRepository;
<<<<<<< Updated upstream
=======
            _Bus = Bus;
            _mapper = mapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            //var CreateCourseCommand = new CreateCourseCommand
            //   (
            //    courseViewModel.Name,
            //    courseViewModel.Description,
            //    courseViewModel.ImageUrl
            //   );


            _Bus.SendCommand(_mapper.Map<CreateCourseCommand>(courseViewModel));
>>>>>>> Stashed changes
        }

        public IEnumerable< CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }
    }
}
