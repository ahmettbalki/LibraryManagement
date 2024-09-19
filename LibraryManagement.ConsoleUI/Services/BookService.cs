using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Services
{
    public class BookService
    {

        BookRepository bookRepository = new BookRepository();

        public void GetAll()
        {
            List<Book> books = bookRepository.GetAll();

            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
        public void GetById(int id)
        {
            Book? book = bookRepository.GetById(id);
            if (book is null)
            {
                Console.WriteLine($"Aradığınız Id ye göre Kitap bulunamadı : {id}");
                return;
            }

            Console.WriteLine(book);

        }
        public void Add(Book book)
        {
            bookRepository.Add(book);
        }
        public void Remove(int id)
        {
            Book? deletedBook = bookRepository.Remove(id);
            if (deletedBook is null)
            {
                Console.WriteLine("Aradığınız kitap bulunamadı(Zaten Yok)");
                return;
            }
            Console.WriteLine(deletedBook);
        }
        public void GetBookByISBN(string isbn)
        {
            Book? book = bookRepository.GetBookByISBN(isbn);
            if (book is null)
            {
                Console.WriteLine($"Aradığınız ISBN numarasına göre kitap bulunamadı. {isbn}");
                return;
            }

            Console.WriteLine(book);
        }
        public void GetAllBooksByPageSizeFilter(int min, int max)
        {
            List<Book> filteredBook = bookRepository.GetAllBooksByPageSizeFilter(min, max);
        }
        public void PageSizeTotalCalculator()
        {
            double totalPageSize = bookRepository.PageSizeTotalCalculator();
        }
        public void GetAllBooksByTitleContains(string text)
        {
            List<Book> books = bookRepository.GetAllBooksByTitleContains(text);
        }
    }
}
