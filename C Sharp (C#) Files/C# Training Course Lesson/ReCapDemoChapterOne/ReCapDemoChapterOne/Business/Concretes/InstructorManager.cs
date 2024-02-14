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
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {      
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(int id)
        {
            _instructorDal.Delete(id);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.GetById(id);
        }

        public void PrintAll(List<Instructor> instructors)
        {
            _instructorDal.PrintAll(instructors);
        }

        public void PrintCourse(Instructor instructor)
        {
            _instructorDal.PrintInstructor(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}

