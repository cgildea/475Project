using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bug2Bug;

namespace Bug2Bug.ProtectedContent
{
    public partial class guestbook : System.Web.UI.Page
    {
        // Entity Framework DbContext
        //BooksEntities dbcontext = new BooksEntities();

        //guestbook dbcontext = new guestbook();
        
       

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Time is " + DateTime.Now.ToString();

        }

        protected void Unnamed7_Click(object sender, EventArgs e)
        {

        }
    }
}