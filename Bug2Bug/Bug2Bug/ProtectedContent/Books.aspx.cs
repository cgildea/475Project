﻿// Fig. 29.11: Books.aspx.cs
// Code-behind file for the password-protected Books page.
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using Bug2Bug;
using System.Web.UI.WebControls;

namespace Bug2Bug.ProtectedContent
{
   public partial class Books : System.Web.UI.Page
   {
      // Entity Framework DbContext
      BooksEntities dbcontext = new BooksEntities();

      // Load event handler for Books page
      protected void Page_Load(object sender, EventArgs e)
      {
         // if this is the first time the page is loading
         if (!IsPostBack)
         {
            dbcontext.Authors.Load(); // load Authors table into memory

            // LINQ query that populates authorsDropDownList
            var authorsQuery =
               from author in dbcontext.Authors.Local
               orderby author.LastName, author.FirstName
               select new
               {
                  Name = author.LastName + ", " + author.FirstName,
                  author.AuthorID
               };

            // specify the field used as the selected value
            authorsDropDownList.DataValueField = "AuthorID";

            // specify the field displayed in the DropDownList
            authorsDropDownList.DataTextField = "Name";

            // set authorsQuery as the authorsDropDownList's data source
            authorsDropDownList.DataSource = authorsQuery;

            authorsDropDownList.DataBind(); // displays query results
         } // end if
      } // end method Page_Load

      // display selected author's books
      protected void authorsDropDownList_SelectedIndexChanged(
         object sender, EventArgs e)
      {
          titlesGridView.SetPageIndex(0);
      } // end method authorsDropDownList_SelectedIndexChanged

       protected void add(object sender, EventArgs e)
      {
          string userId = "tempuserid";
          List<string> titlesList;
          if (Session[userId] == null)
          {
              titlesList = new List<string>();
          }
          else
          {
              titlesList = Session[userId] as List<string>;
          }

           titlesList.Add(titlesGridView.SelectedRow.Cells[1].Text);

          Session[userId] = titlesList;

          //Response.Redirect("~/ProtectedContent/order");
      }

       protected void titlesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
       {
           dbcontext.Authors.Load(); // load Authors table into memory
           titlesGridView.PageIndex = e.NewPageIndex;

           // use LINQ to get Author object for the selected author
           // Author selectedAuthor =
           var selectedAuthor =
           (from author in dbcontext.Authors.Local
            where author.AuthorID ==
            Convert.ToInt32(authorsDropDownList.SelectedValue)
            // select author).First();
            select author).First();
           // query to get books for the selected author
           var titlesQuery =
           from book in selectedAuthor.Titles
           orderby book.Title1
           select book;

           // set titlesQuery as the titlesGridView's data source
           titlesGridView.DataSource = titlesQuery.ToList();
           titlesGridView.DataBind(); // displays query results 
       } // end method authorsDropDownList_SelectedIndexChanged
   } // end class Books
} // end namespace Bug2Bug.ProtectedContent


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
