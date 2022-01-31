using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerProductTrack
{
    public class CategoriesManager : ICategoryService
    {
        List<Category> _categories;
        public CategoriesManager()
        {
            _categories = new List<Category>()
            {
                new Category{CategoryId=1 , CategoryName="Gıda" },
                new Category{CategoryId=2 , CategoryName="Elektronik" },
                new Category{CategoryId=3 , CategoryName="Temizlik" },
            };
        }
        
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = new Category();
            foreach (var item in _categories)
            {
                if (item.CategoryName == category.CategoryName)
                {
                    categoryToDelete = item;
                    break;
                }
            }
            _categories.Remove(categoryToDelete);
        }

        public void Update(Category category)
        {
            Category categoryToUpdate;
            categoryToUpdate =  _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
            categoryToUpdate.CategoryId = category.CategoryId;
        }
    }
}
