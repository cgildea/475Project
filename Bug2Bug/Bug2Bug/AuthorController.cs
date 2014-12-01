using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bug2Bug
{
    public class AuthorController : ApiController
    {
        static AuthorRepository repository = new AuthorRepository();

        public IEnumerable<string> GetAllAuthors()
        {
            var authors = repository.GetAllAuthors();
            return authors;
        }

        public AuthorModel GetAuthorById(int id)
        {
            var author = repository.GetAuthorById(id);
            return author;
        }
        public string AddUser(AuthorModel author)
        {
            var response = repository.AddAuthor(author);
            return response;
        }
        public void DeleteAuthor(int id)
        {
            repository.DeleteAuthor(id);
        }
    }
}