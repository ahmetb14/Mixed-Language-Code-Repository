using ReCapDemoChapterOne.DataAccess.Abstracts;
using ReCapDemoChapterOne.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemoChapterOne.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        public List<Category> categories;
        public CategoryDal()
        {
                categories =
                new List<Category>() 
                {
                new Category { CategoryName="C#,",CategoryId=1,CategoryDescription="Yazılım Geliştirici Yetiştirme Kampı C#"},
                new Category { CategoryName="Java,",CategoryId=2,CategoryDescription="Yazılım Geliştirici Yetiştirme Kampı Java"},
                new Category { CategoryName="Python,",CategoryId=3,CategoryDescription="Yazılım Geliştirici Yetiştirme Kampı Python"}
                };
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(int id)
        {
            foreach (var c in categories)
            {
                if (c.CategoryId == id)
                {
                    categories.Remove(c);
                }
            }
        }

        public List<Category> GetAll()
        {
            return categories.ToList();
        }

        public Category GetById(int id)
        {
            foreach (var c in categories)
            {
                if (c.CategoryId == id)
                {
                    return c;
                }
            }

            throw new Exception("Girilen Id değeri ile eşleşen bir katagori bulunamadı!");
        }

        public void PrintAll(List<Category> categories)
        {
            foreach (var c in categories)
            {
                PrintCategory(c);
            }
        }

        public void PrintCategory(Category c)
        {
            Console.WriteLine("Kategori Id: " + c.CategoryId);
            Console.WriteLine("Kategori Adı: " + c.CategoryName);
            Console.WriteLine("Kategori Açıklama: " + c.CategoryDescription);
            Console.WriteLine("");
        }

        public void Update(Category c)
        {
            var willUpdateCategory = GetById(c.CategoryId);
            willUpdateCategory.CategoryName = c.CategoryName;
            willUpdateCategory.CategoryDescription = c.CategoryDescription;
        }
    }
}

