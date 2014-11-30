using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bug2Bug.REST
{
    public class AuthorService : IAuthorService
    {
        public List<Author> GetAuthorsList()
        {
            using (BooksEntities entities = new BooksEntities())
            {
                return entities.Authors.ToList();
            }
        }
        public Author GetAuthorById(string id)
        {
            try
            {
                int authorId = Convert.ToInt32(id);
                using (BooksEntities entities = new BooksEntities())
                {
                    return entities.Authors.SingleOrDefault(author => author.AuthorID == authorId);
                }
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
        public void AddAuthor(string fname, string lname)
        {
            using (BooksEntities entities = new BooksEntities())
            {
                Author author = new Author { FirstName = fname, LastName = lname };
                entities.Authors.Add(author);
                entities.SaveChanges();
            }
        }
        public void UpdateAuthor(string id, string fname, string lname)
        {
            try
            {
                int authorId = Convert.ToInt32(id);
                using (BooksEntities entities = new BooksEntities())
                {
                    Author author = entities.Authors.SingleOrDefault(a => a.AuthorID == authorId);
                    author.FirstName = fname;
                    author.LastName = lname;
                    entities.SaveChanges();
                }
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
        public void DeleteAuthor(string id)
        {
            try
            {
                int authorId = Convert.ToInt32(id);
                using (BooksEntities entities = new BooksEntities())
                {
                    Author author = entities.Authors.SingleOrDefault(a => a.AuthorID == authorId);
                    entities.Authors.Remove(author);
                    entities.SaveChanges();
                }
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}