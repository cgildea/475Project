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
        //GuestbookEntities dbcontext = new GuestbookEntities();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Time is " + DateTime.Now.ToString();

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            // new entry to add
            GuestbookEntry newEntry = new GuestbookEntry();
            newEntry.name = "Angel M";
            newEntry.email = "angelm@marquez.com";
            newEntry.message = "BLUE DYNAMO!";

            using (var dbCtx = new GuestbookEntities())
            {
                dbCtx.GuestbookEntries.Add(newEntry);
                dbCtx.SaveChanges();
            }
        }
    }
}