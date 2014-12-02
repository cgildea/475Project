using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bug2Bug
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AuthorModel(Author author)
        {
            Id = author.AuthorID;
            FirstName = author.FirstName;
            LastName = author.LastName;
        }
        public AuthorModel(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
    }
}