using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Delete(int id);
        void Update(Category category);
        void PrintCategory(Category category);
        public void PrintAll(List<Category> categories);
        public Category GetById(int id);
        public List<Category> GetAll();
    }
}

