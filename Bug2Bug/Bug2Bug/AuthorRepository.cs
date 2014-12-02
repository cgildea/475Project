﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bug2Bug
{
    public class AuthorRepository
    {
        BooksEntities dbcontext = new BooksEntities();

        public IEnumerable<string> GetAllAuthors()
        {
            dbcontext.Authors.Load();
            var authorsQuery =
               from author in dbcontext.Authors.Local
               orderby author.LastName, author.FirstName
               select new
               {
                   Name = author.LastName + ", " + author.FirstName,
                   author.AuthorID
               };
            string[] authorList = authorsQuery.Cast<object>().Select(x => x.ToString()).ToArray();
            return authorList;
        }

        public AuthorModel GetAuthorById(int id)
        {
            try
            {
                int authorId = id;
                using (BooksEntities entities = new BooksEntities())
                {
                    return new AuthorModel(entities.Authors.FirstOrDefault(author => author.AuthorID == authorId));
                }
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
        public AuthorModel GetAuthor(string lname)
        {
            try
            {
                using (BooksEntities entities = new BooksEntities())
                {
                    return new AuthorModel(entities.Authors.FirstOrDefault(author => author.LastName == lname));
                }
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
        public string AddAuthor(AuthorModel auth)
        {
            using (BooksEntities entities = new BooksEntities())
            {
                Author author = new Author { FirstName = auth.FirstName, LastName = auth.LastName };
                entities.Authors.Add(author);
                entities.SaveChanges();
                return "SUCESS";
            }
        }

        public string UpdateAuthor(AuthorModel auth)
        {
            try
            {
                int authorId = Convert.ToInt32(auth.Id);
                using (BooksEntities entities = new BooksEntities())
                {
                    Author author = entities.Authors.SingleOrDefault(a => a.AuthorID == authorId);
                    author.FirstName = auth.FirstName;
                    author.LastName = auth.LastName;
                    entities.SaveChanges();
                    return "SUCESS";
                }
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
        public void DeleteAuthor(string lname)
        {
            try
            {
                using (BooksEntities entities = new BooksEntities())
                {
                    Author author = entities.Authors.SingleOrDefault(a => a.LastName == lname);
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