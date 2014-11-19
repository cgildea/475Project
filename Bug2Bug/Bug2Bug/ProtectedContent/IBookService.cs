using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug2Bug
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        [WebGet]
        List<Book> GetBooksList();
        [OperationContract]
        [WebGet(UriTemplate = "Book/{id}")]
        Book GetBookById(string id);
        [OperationContract]
        [WebInvoke(UriTemplate = "AddBook/{name}")]
        void AddBook(string name);
        [OperationContract]
        [WebInvoke(UriTemplate = "UpdateBook/{id}/{name}")]
        void UpdateBook(string id, string name);
    }
}
