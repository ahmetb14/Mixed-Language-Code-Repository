using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.Business.Abstracts
{
    public interface ICourseService
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
        void PrintAll(List<Course> courses);
        void PrintCourse(Course course);
        Course GetById(int id);
        List<Course> GetAll();
    }
}

