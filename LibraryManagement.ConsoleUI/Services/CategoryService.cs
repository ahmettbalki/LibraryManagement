using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Services
{
    public class CategoryService
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public void GetAll()
        {
            List<Category> categories = categoryRepository.GetAll();

            foreach (Category category in categories)
            {
                Console.WriteLine(category);
            }
        }
        public void GetById(int id)
        {
            Category? category = categoryRepository.GetById(id);
            if (category is null)
            {
                Console.WriteLine($"Aradığınız Id ye göre Kategori bulunamadı : {id}");
                return;
            }

            Console.WriteLine(category);

        }
        public void Add(Category category)
        {
            categoryRepository.Add(category);
        }
        public void Remove(int id)
        {
            Category? deletedCategory = categoryRepository.Remove(id);
            if (deletedCategory is null)
            {
                Console.WriteLine("Aradığınız kategori bulunamadı(Zaten Yok)");
                return;
            }
            Console.WriteLine(deletedCategory);
        }
    }
}
