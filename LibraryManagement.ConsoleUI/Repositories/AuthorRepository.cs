using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagement.ConsoleUI.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        //List<Author> authors = new List<Author>()
        //{
        //    new Author(1,"Emile","Zola"),
        //    new Author(2,"Fyodor","Dostoyevksi"),
        //    new Author(3,"Recaizade Mahmut","Ekrem"),
        //    new Author(4,"Halide Edip","Adıvar"),
        //    new Author(5,"Ömer","Seyfettin"),
        //    new Author(6,"Ali","Koç"),
        //};

        //public List<Author> GetAll()
        //{
        //    return authors;
        //}
        //public Author? GetById(int id)
        //{
        //    Author? author1 = null;
        //    foreach (Author author in authors)
        //    {
        //        if (author.Id == id)
        //        {
        //            author1 = author;
        //        }
        //    }

        //    if (author1 == null)
        //    {
        //        return null;
        //    }

        //    return author1;
        //}
        //public Author Add(Author created)
        //{
        //    authors.Add(created);
        //    return created;
        //}
        //public Author? Remove(int id)
        //{
        //    Author? deletedAuthor = GetById(id);

        //    if (deletedAuthor is null)
        //    {
        //        return null;
        //    }
        //    authors.Remove(deletedAuthor);
        //    return deletedAuthor;
        //}

        IQueryable<Author> IRepository<Author, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        IQueryable<Author> IRepository<Author, int>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Author> Where(Expression<Func<Author, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Author> AddAsync(Author entity)
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
