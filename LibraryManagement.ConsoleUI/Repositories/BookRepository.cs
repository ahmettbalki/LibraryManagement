using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagement.ConsoleUI.Repositories
{
    public class BookRepository : IBookRepository
    {
        //List<Book> books = new List<Book>()
        //{
        //    new Book(1,1,1,"Germinal","Kömür Madeni",341,"2012 Mayıs","9781234567897"),
        //    new Book(2,1,1,"Suç ve Ceza","Raskolnikov un hayatı",315,"2010 Haziran","9781234567891"),
        //    new Book(3,1,2,"Kumarbaz","Bir Öğretmenin hayatı",210,"2009 Ocak","9781234567892"),
        //    new Book(4,2,2, "Araba Sevdası","Arabayla alakası olmayan Kitap",180,"1999 Ocak","9781234567838"),
        //    new Book(5,2,3,"Ateşten Gömlek","Kurtulu savaşını anlatan kitap",120,"2001 Eylül","9781234567834"),
        //    new Book(6,2,3,"Kaşağı","Okunmaması gereken bir kitap",95,"1993 Ocak","9781234567845"),
        //    new Book(7,3,4,"28 Şampiyonluk","Hayal ürünüdür",350,"1907 Ocak ","9781234567807"),
        //    new Book(8,3,1,"16 Yıl Şampiyonluk","Hayal ürünüdür.",255,"10 Eylül","9781234567800"),
        //    new Book(9,3,4,"Ali Arı","Uyanık Ceo nun hikayesi",551,"20 Haziran","9781234567800")
        //};

        //List<Category> categories = new List<Category>()
        //{
        //    new Category(1,"Dünya Klasikleri"),
        //    new Category(2,"Türk Klasikleri"),
        //    new Category(3,"Bilim Kurgu"),
        //};

        //List<Author> authors = new List<Author>()
        //{
        //    new Author(1,"Emile","Zola"),
        //    new Author(2,"Fyodor","Dostoyevksi"),
        //    new Author(3,"Recaizade Mahmut","Ekrem"),
        //    new Author(4,"Halide Edip","Adıvar"),
        //    new Author(5,"Ömer","Seyfettin"),
        //    new Author(6,"Ali","Koç"),
        //};
        //public List<Book> GetAll()
        //{
        //    return books;
        //}
        //public Book? GetById(int id)
        //{
        //    Book? book1 = null;
        //    foreach (Book book in books)
        //    {
        //        if (book.Id == id)
        //        {
        //            book1 = book;
        //        }
        //    }

        //    if (book1 == null)
        //    {
        //        return null;
        //    }

        //    return book1;
        //}
        //public Book Add(Book created)
        //{
        //    books.Add(created);
        //    return created;
        //}
        //public Book? Remove(int id)
        //{
        //    Book? deletedBook = GetById(id);

        //    if (deletedBook is null)
        //    {
        //        return null;
        //    }
        //    books.Remove(deletedBook);
        //    return deletedBook;
        //}
        //public List<Book> GetAllBooksByPageSizeFilter(int min, int max)
        //{
        //    //Linq FindAll yöntemi
        //    List<Book> result = books.FindAll(b => b.PageSize <= max && b.PageSize > min);
        //    return result;

        //    //Linq Where yöntemi
        //    //List<Book> result = books.Where(b => b.PageSize <= max && b.PageSize > min).ToList();
        //    //return result;



        //    //LinQ geleneksel yöntem
        //    //List<Book> result = (from b in books
        //    //                    where b.PageSize <= max && b.PageSize >= min
        //    //                    select b).ToList();
        //    //return result;

        //    //Geleneksel Yöntem
        //    //List<Book> filteredBooks = new List<Book>();

        //    //foreach (Book book in books)
        //    //{
        //    //    if (book.PageSize <= max && book.PageSize >= min)
        //    //    {
        //    //        filteredBooks.Add(book);
        //    //    }
        //    //}
        //    //return filteredBooks;
        //}
        //public double PageSizeTotalCalculator()
        //{
        //    double total = books.Sum(x => x.PageSize);
        //    return total;
        //}
        //public List<Book> GetAllBooksByTitleContains(string text)
        //{
        //    List<Book> book = books.Where(x => x.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase)).ToList();
        //    return book;

        //    //List<Book> filteredBooks = new List<Book>();
        //    //foreach (Book book in books)
        //    //{
        //    //    if (book.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase))
        //    //    {
        //    //        filteredBooks.Add(book);
        //    //    }
        //    //}
        //    //return filteredBooks;
        //}
        //public Book? GetBookByISBN(string isbn)
        //{
        //    //Book book1 = null;
        //    //foreach (Book item in books)
        //    //{
        //    //    if (item.ISBN == isbn)
        //    //    {
        //    //        book1 = item;
        //    //    }
        //    //}
        //    //if (book1 == null)
        //    //{
        //    //    return null;
        //    //}
        //    //return book1;

        //    //Book? book = books.Where(b => b.ISBN == isbn).FirstOrDefault();
        //    //return book;

        //    Book? book = books.SingleOrDefault(b  => b.ISBN == isbn);
        //    return book;

        //    //Book? book = (from b in books where b.ISBN == isbn select b).FirstOrDefault();
        //    //return book;
        //}

        //public List<Book> GetAllBookOrderByTitle()
        //{
        //    List<Book> orderedBooks = books.OrderBy(x => x.Title).ToList();
        //    return orderedBooks;
        //}
        //public List<Book> GetAllBookOrderByDescendingTitle()
        //{
        //    List<Book> orderedBooks = books.OrderByDescending(x => x.Title).ToList();
        //    return orderedBooks;
        //}

        //public Book GetBookMaxPageSize()
        //{
        //    Book? book = books.OrderBy(x =>x.PageSize).LastOrDefault();
        //    return book;
            
        //}
        //public Book GetBookMinPageSize()
        //{
        //    Book? book = books.OrderBy(x => x.PageSize).FirstOrDefault();
        //    return book;
        //}

        //public List<BookDetailDto> GetDetails()
        //{
        //    var result =
        //         from b in books
        //         join c in categories
        //         on b.CategoryId equals c.Id
        //         select new BookDetailDto(
        //             Id: b.Id,
        //             CategoryName: c.Name,
        //             AuthorName: "",
        //             Title: b.Title,
        //             Description: b.Description,
        //             PageSize: b.PageSize,
        //             PublishDate: b.PublishDate,
        //             ISBN: b.ISBN);
        //    return result.ToList();
        //}

        //public List<BookDetailDto> GetDetailsV2()
        //{
        //    List<BookDetailDto> details =
        //        books.Join(categories,
        //        b => b.CategoryId,
        //        c => c.Id,
        //        (book,category) => new BookDetailDto(
        //             Id: book.Id,
        //             CategoryName: category.Name,
        //             AuthorName: "",
        //             Title: book.Title,
        //             Description: book.Description,
        //             PageSize: book.PageSize,
        //             PublishDate: book.PublishDate,
        //             ISBN: book.ISBN))
        //        .ToList();
        //    return details;
        //}

        //public List<BookDetailDto> GetAllAuthorAndBookDetails()
        //{
        //    var result =
        //        from b in books
        //        join c in categories on b.CategoryId equals c.Id
        //        join a in authors on b.AuthorId equals a.Id
        //        select new BookDetailDto(
        //            Id: b.Id,
        //            Title: b.Title,
        //            CategoryName: c.Name,
        //            AuthorName: $"{a.Name} {a.Surname}",
        //            Description: b.Description,
        //            PageSize: b.PageSize,
        //            PublishDate: b.PublishDate,
        //            ISBN: b.ISBN);
        //    return result.ToList();
        //}
        //public List<BookDetailDto> GetAllDetailsByCategoryId(int categoryId)
        //{
        //    var result =
        //        from b in books
        //        where b.CategoryId == categoryId
        //        join c in categories on b.CategoryId equals c.Id
        //        join a in authors on b.AuthorId equals a.Id
        //        select new BookDetailDto(
        //            Id: b.Id,
        //            Title: b.Title,
        //            CategoryName: c.Name,
        //            AuthorName: $"{a.Name} {a.Surname}",
        //            Description: b.Description,
        //            PageSize: b.PageSize,
        //            PublishDate: b.PublishDate,
        //            ISBN: b.ISBN);
        //    return result.ToList();
        //}

        IQueryable<Book> IRepository<Book, Guid>.GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Book> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Book> Where(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Book> AddAsync(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid entity)
        {
            throw new NotImplementedException();
        }
    }
}
