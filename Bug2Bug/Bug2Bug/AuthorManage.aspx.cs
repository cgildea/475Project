using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Bug2Bug
{
    public partial class AuthorManage : System.Web.UI.Page
    {
        private HttpClient client = new HttpClient();
        private XNamespace xmlNamespace = XNamespace.Get("http://schemas.datacontract.org/2004/07/Bug2Bug");

        protected async void getAuthorButton_Click(object obj, EventArgs e)
        {
            String result = await client.GetStringAsync(new Uri("http://localhost:52430/ServiceHandler.svc/GetAuthor/" + lname.Text));
            XDocument xmlResponse = XDocument.Parse(result);

            output.Text = null;
            if (!xmlResponse.Root.Elements().Any())
            {
                output.Text = "No author with that name";
            }
            else
            {
                foreach (XElement element in xmlResponse.Root.Elements())
                {
                    output.Text += element.Value + "\r\n";

                }
            }
        }

        protected async void addAuthorButton_Click(object obj, EventArgs e)
        {
            if (addfname.Text != string.Empty && addlname.Text != string.Empty)
            {
                String result = await client.GetStringAsync(new Uri("http://localhost:52430/ServiceHandler.svc/AddAuthor/" + addfname.Text + "/" + addlname.Text));
                output.Text = null;
                HttpResponseMessage response = await client.GetAsync(new Uri("http://localhost:52430/ServiceHandler.svc/AddAuthor/" + addfname.Text + "/" + addlname.Text));
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    output.Text = "Author " + addfname.Text + " " + addlname.Text + " successfully added";
                }
            }


        }
    }
}