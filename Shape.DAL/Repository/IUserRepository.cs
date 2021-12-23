using Shape.DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.DAL.Repository
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<User> GetBooks();
        User GetBookByID(int bookId);
        void InsertBook(User book);
        void Save();
    }
}
