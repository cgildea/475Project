using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug2Bug
{
    interface IAuthorRepository
    {
        IEnumerable<string> GetAllAuthors();
        string AddAuthor(AuthorModel author);
        string GetAuthorById(int id);
        void DeleteAuthor(int id);
    }
}
