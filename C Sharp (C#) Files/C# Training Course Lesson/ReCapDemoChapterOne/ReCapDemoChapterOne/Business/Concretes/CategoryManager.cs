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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {   
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int id)
        {
            _categoryDal.Delete(id);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void PrintAll(List<Category> categories)
        {
            _categoryDal.PrintAll(categories);
        }

        public void PrintCourse(Category category)
        {
            _categoryDal.PrintCategory(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}

