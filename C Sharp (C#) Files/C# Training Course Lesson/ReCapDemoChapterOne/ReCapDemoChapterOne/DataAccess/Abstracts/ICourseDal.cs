using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Delete(int id);
        void Update(Course course);
        void PrintCourse(Course course);
        public void PrintAll(List<Course> courses);
        Course GetById(int id);
        List<Course> GetAll();
    }
}

