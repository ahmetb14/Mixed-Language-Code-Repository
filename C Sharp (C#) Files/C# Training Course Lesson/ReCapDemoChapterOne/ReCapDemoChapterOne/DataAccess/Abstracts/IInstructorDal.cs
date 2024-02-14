using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(int id);
        void Update(Instructor instructor);
        void PrintAll(List<Instructor> instructors);
        void PrintInstructor(Instructor instructor);
        Instructor GetById(int id);
        List<Instructor> GetAll();
    }
}

