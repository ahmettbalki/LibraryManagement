using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Models
{
    public class Book : Entity<Guid>
    {
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PageSize { get; set; }
        public string PublishDate { get; set; }
        public string ISBN { get; set; }

    }
}
