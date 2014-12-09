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
            String result = await client.GetStringAsync(new Uri("http://localhost:52430/ServiceHandler.svc/GetAuthor/" + searchlname.Text));
            XDocument xmlResult = XDocument.Parse(result, LoadOptions.PreserveWhitespace);

            serverResponse.Text = null;
            if (!xmlResult.Root.Elements().Any())
            {
                serverResponse.Text = "No author with that name";
            }
            else
            {
                foreach (XElement element in xmlResult.Root.Elements())
                {
                    serverResponse.Text += element.Value + "\r\n";

                }
            }
        }
        public static string GetAttributeValue(XElement element, XName name)
        {
            var attribute = element.Attribute(name);
            return attribute != null ? attribute.Value : null;
        }

        protected async void addAuthorButton_Click(object obj, EventArgs e)
        {
            if (addfname.Text != string.Empty && addlname.Text != string.Empty)
            {
                serverResponse.Text = null;
                HttpResponseMessage response = await client.GetAsync(new Uri("http://localhost:52430/ServiceHandler.svc/AddAuthor/" + addfname.Text + "/" + addlname.Text));
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    serverResponse.Text = addfname.Text + " " + addlname.Text + " added!";
                }
            }


        }
    }
}