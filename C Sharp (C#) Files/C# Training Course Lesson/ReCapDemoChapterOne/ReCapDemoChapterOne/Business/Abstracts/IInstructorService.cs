﻿using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.Business.Abstracts
{
    public interface IInstructorService
    {
        void Add (Instructor instructor);
        void Delete (int id);
        void Update (Instructor instructor);
        void PrintAll(List<Instructor> instructors);
        void PrintCourse(Instructor instructor);
        Instructor GetById (int id);
        List<Instructor> GetAll();
    }
}
