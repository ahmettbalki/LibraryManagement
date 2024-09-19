using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagement.ConsoleUI.Repositories
{
    public class CategoryRepository
    {
        List<Category> categories = new List<Category>()
        {
            new Category(1,"Dünya Klasikleri"),
            new Category(2,"Türk Klasikleri"),
            new Category(3,"Bilim Kurgu"),
        };



        public List<Category> GetAll()
        {
            return categories;
        }
        public Category? GetById(int id)
        {
            Category? category1 = null;
            foreach (Category category in categories)
            {
                if (category.Id == id)
                {
                    category1 = category;
                }
            }

            if (category1 == null)
            {
                return null;
            }

            return category1;
        }
        public Category Add(Category created)
        {
            categories.Add(created);
            return created;
        }
        public Category? Remove(int id)
        {
            Category? deletedCategory = GetById(id);

            if (deletedCategory is null)
            {
                return null;
            }
            categories.Remove(deletedCategory);
            return deletedCategory;
        }
    }
}
