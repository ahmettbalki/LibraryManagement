using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagement.ConsoleUI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        //List<Category> categories = new List<Category>()
        //{
        //    new Category(1,"Dünya Klasikleri"),
        //    new Category(2,"Türk Klasikleri"),
        //    new Category(3,"Bilim Kurgu"),
        //};



        //public List<Category> GetAll()
        //{
        //    return categories;
        //}
        //public Category? GetById(int id)
        //{
        //    Category? category1 = null;
        //    foreach (Category category in categories)
        //    {
        //        if (category.Id == id)
        //        {
        //            category1 = category;
        //        }
        //    }

        //    if (category1 == null)
        //    {
        //        return null;
        //    }

        //    return category1;
        //}
        //public Category Add(Category created)
        //{
        //    categories.Add(created);
        //    return created;
        //}
        //public Category? Remove(int id)
        //{
        //    Category? deletedCategory = GetById(id);

        //    if (deletedCategory is null)
        //    {
        //        return null;
        //    }
        //    categories.Remove(deletedCategory);
        //    return deletedCategory;
        //}

        IQueryable<Category> IRepository<Category, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        IQueryable<Category> IRepository<Category, int>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> Where(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Category> AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int entity)
        {
            throw new NotImplementedException();
        }
    }
}
