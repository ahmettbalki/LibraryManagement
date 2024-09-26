using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Repositories
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
    }
}
