using ReCapDemoChapterOne.DataAccess.Abstracts;
using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        public List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>() 
            {
            new Instructor { FirstName = "Engin", LastName = "Demiroğ", Description = "Senior Level Developer", Id=1},
            new Instructor { FirstName = "Ahmet Berkay", LastName = "Yılmaz", Description = "Junior Level Developer", Id=2}
            };

        }

        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(int id)
        {
            foreach (var c in instructors)
            {
                if (c.Id == id)
                {
                    instructors.Remove(c);
                }
            };
        }

        public List<Instructor> GetAll()
        {
            return instructors.ToList();
        }

        public Instructor GetById(int id)
        {
            foreach (var c in instructors)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }

            throw new Exception("Girilen Id değeri ile eşleşen bir eğitmen bulunamadı!");
        }

        public void PrintAll(List<Instructor> instructors)
        {
            foreach (var c in instructors)
            {
                PrintInstructor(c);
            }
        }

        public void PrintInstructor(Instructor c)
        {
            Console.WriteLine("Eğitmen Id: " + c.Id);
            Console.WriteLine("Eğitmen Adı: " + c.FirstName);
            Console.WriteLine("Eğitmen Soyadı: " + c.LastName);
            Console.WriteLine("");
        }

        public void Update(Instructor i)
        {
            var willUpdateInstructor = GetById(i.Id);
            willUpdateInstructor.FirstName = i.FirstName;
            willUpdateInstructor.LastName = i.LastName;
            willUpdateInstructor.Description = i.Description;
        }
    }
}

