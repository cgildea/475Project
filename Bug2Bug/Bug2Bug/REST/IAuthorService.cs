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
    public interface IAuthorService
    {
         [OperationContract]
         [WebGet]
         List<Author> GetAuthorsList();
         [OperationContract]
         [WebGet(UriTemplate = "Author/{id}")]
         Author GetAuthorById(string id);
         [OperationContract]
         [WebInvoke(UriTemplate = "AddAuthor/{name}")]
         void AddAuthor(string fname, string lname);
         [OperationContract]
         [WebInvoke(UriTemplate = "UpdateAuthor/{id}/{name}")]
         void UpdateAuthor(string id, string fname, string lname);
         [OperationContract]
         [WebInvoke(UriTemplate = "DeleteAuthor/{id}")]
         void DeleteAuthor(string id);

    }
}
