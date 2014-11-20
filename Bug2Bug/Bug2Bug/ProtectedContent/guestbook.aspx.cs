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
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            // new entry to add
            GuestbookEntry newEntry = new GuestbookEntry();
            newEntry.name = GuestName.Text;
            newEntry.email = GuestEmail.Text;
            newEntry.message = Message.Text;

            using (var dbCtx = new GuestbookEntities())
            {
                try
                {
                    dbCtx.GuestbookEntries.Add(newEntry);
                    dbCtx.SaveChanges();
                }
                catch
                {
                    Console.WriteLine(e);
                }
            }
            GridView1.DataBind();
        }
    }
}