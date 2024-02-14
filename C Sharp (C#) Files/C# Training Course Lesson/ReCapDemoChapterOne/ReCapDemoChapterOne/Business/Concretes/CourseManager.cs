using ReCapDemoChapterOne.Business.Abstracts;
using ReCapDemoChapterOne.DataAccess.Abstracts;
using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {   
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void PrintAll(List<Course> courses)
        {
            _courseDal.PrintAll(courses);
        }

        public void PrintCourse(Course course)
        {
            _courseDal.PrintCourse(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}

