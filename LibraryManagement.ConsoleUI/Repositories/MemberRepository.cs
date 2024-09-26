using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public ValueTask<Member> AddAsync(Member entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Member> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Member> Where(Expression<Func<Member, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
