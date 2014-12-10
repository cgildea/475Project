using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bug2Bug
{
    public class AuthorController : IAuthorController
    {
        public List<Author> GetAuthorsList()
        {
            using (BooksEntities entities = new BooksEntities())
            {
                return entities.Authors.ToList();
            }
        }
        public string[] GetAuthorByName(string lname)
        {
            using (BooksEntities tmp = new BooksEntities())
            {
                var matchingEntries = from Author in tmp.Authors where lname == Author.LastName select new AuthorModel {FirstName = Author.FirstName,  LastName = Author.LastName };
                return matchingEntries.ToArray().Select(i=>i.ToString()).ToArray();
            }
        }
        public void AddAuthor(string fname, string lname)
        {
            using (BooksEntities entities = new BooksEntities())
            {
                Author Author = new Author { FirstName = fname, LastName = lname };
                entities.Authors.Add(Author);
                entities.SaveChanges();
            }
        }
    }
}