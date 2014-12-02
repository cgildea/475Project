using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bug2Bug.ProtectedContent
{
    public partial class AuthorManage : System.Web.UI.Page
    {
        AuthorController authCtrl = new AuthorController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var auths = authCtrl.GetAllAuthors();
                AuthorsList_GridView.DataSource = auths;
                AuthorsList_GridView.DataBind();
            }
        }


        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            AuthorModel auth = new AuthorModel(fname.Text, lname.Text);

            authCtrl.AddAuthor(auth);
            var authors = authCtrl.GetAllAuthors();
            AuthorsList_GridView.DataSource = authors;
            AuthorsList_GridView.DataBind();

        }
        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            List<AuthorModel> x = new List<AuthorModel>();
            AuthorModel auth = authCtrl.GetAuthor(authorSearch.Text);
            x.Add(auth);
            AuthorsList_GridView.DataSource = x;
            AuthorsList_GridView.DataBind();
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            authCtrl.DeleteAuthor(authorDelete.Text);

            var auths = authCtrl.GetAllAuthors();
            AuthorsList_GridView.DataSource = auths;
            AuthorsList_GridView.DataBind();
        }
    }
}