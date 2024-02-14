using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
        void PrintAll(List<Category> categories);
        void PrintCourse(Category category);
        Category GetById(int id);
        List<Category> GetAll();
    }
}

