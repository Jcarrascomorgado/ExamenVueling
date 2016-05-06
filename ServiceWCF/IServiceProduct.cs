using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceProduct" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceProduct
    {
        //Adress: http://localhost:2934/ServiceProduct.svc/api/GetAll
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetAll")]
        IEnumerable<Product> GetAll();
    }
}
