using ReCapDemoChapterOne.DataAccess.Abstracts;
using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        public List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>() 
            {
                new Course { CourseName="C#",CourseId=1,CourseDescription="Senior Level Programlama Kampı",InstructorId=1,CategoryId=1,CoursePrice=0},
                new Course { CourseName="Java",CourseId=2,CourseDescription="Advanced Level Programlama Kampı",InstructorId=1,CategoryId=2, CoursePrice=0},
                new Course { CourseName="Python",CourseId=3,CourseDescription="Sıfırdan İleri Seviyeye Programlama Kampı",InstructorId=2,CategoryId=3, CoursePrice=15}
            };
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(int id)
        {
            var willDeleteCourse = GetById(id);
            courses.Remove(willDeleteCourse);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            foreach (var c in courses)
            {
                if (c.CourseId == id)
                {
                    return c;

                }
            }

            throw new Exception("Girilen Id değeri ile eşleşen bir kurs bulunamadı!");
        }

        public void PrintAll(List<Course> courses)
        {
            foreach (var c in courses)
            {
                PrintCourse(c);
            }
        }

        public void PrintCourse(Course c)
        {
            Console.WriteLine(">> Kurs Adı: " + c.CourseName);
            Console.WriteLine(">> Kurs Açıklama: " + c.CourseDescription);
            Console.WriteLine(">> Kurs Id: " + c.CourseId);
            Console.WriteLine(">> Kurs Kategori Id: " + c.CategoryId);
            Console.WriteLine(">> Kurs Eğitmen Id: " + c.InstructorId);
            Console.WriteLine(">> Kurs Fiyatı: " + c.CoursePrice);
            Console.WriteLine("");
        }

        public void Update(Course c)
        {
            var willUpdateCourse = GetById(c.CourseId);
            willUpdateCourse.CourseName = c.CourseName;
            willUpdateCourse.CourseDescription = c.CourseDescription;
            willUpdateCourse.CategoryId = c.CategoryId;
            willUpdateCourse.InstructorId = c.InstructorId;
            willUpdateCourse.CoursePrice = c.CoursePrice;
        }
    }
}

