using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
namespace Bug2Bug
{
    [ServiceContract]
    public interface IAuthorController
    {
        [OperationContract]
        [WebGet]
        List<Author> GetAuthorsList();
        [OperationContract]
        [WebGet(UriTemplate = "GetAuthor/{lname}")]
        AuthorModel[] GetAuthorByName(string lname);
        [OperationContract]
        [WebGet(UriTemplate = "AddAuthor/{fname}/{lname}")]
        void AddAuthor(string fname, string lname);
    }
}
