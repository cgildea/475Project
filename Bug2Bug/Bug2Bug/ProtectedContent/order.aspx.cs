using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Bug2Bug;

namespace Bug2Bug.ProtectedContent
{
    public partial class order : System.Web.UI.Page
    {

        // Entity Framework DbContext
        BooksEntities dbcontext = new BooksEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            string userId = "tempuserid";

            if (Session[userId] == null)
            {
                List<string> intlist = new List<string>();
                intlist.Add("your cart is empty");
                shoppingCart.DataSource = intlist;
            }
            else 
            {
                List<string> titleList = Session[userId] as List<string>;
                dbcontext.Titles.Load();
                
                // query to get books for the selected ISBN.
                // Currently does not recognize quantity. Ignore?
                var titlesQuery =
                    from book in dbcontext.Titles.Local
                    where titleList.Contains(book.ISBN)
                    select new
                    {
                        Price = book.Price,
                        ISBN = book.ISBN,
                        Title = book.Title1
                    };

                shoppingCart.DataSource = titlesQuery;
            }

            shoppingCart.DataBind();

        }

    }
}