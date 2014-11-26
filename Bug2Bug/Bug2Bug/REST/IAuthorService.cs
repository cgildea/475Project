using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Object;
using System.Attribute;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Bug2Bug
{
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
         void AddAuthor(string name);
         [OperationContract]
         [WebInvoke(UriTemplate = "UpdateAuthor/{id}/{name}")]
         void UpdateAuthor(string id, string name);
         [OperationContract]
         [WebInvoke(UriTemplate = "DeleteAuthor/{id}")]
         void DeleteAuthor(string id);
    }
}
