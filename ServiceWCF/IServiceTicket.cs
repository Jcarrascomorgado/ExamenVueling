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
    [ServiceContract]
    public interface IServiceTicket
    {
        //No es necesario heredar de IUnitOfWork porque la clase que lo implemente heredará de ServiceBase.
        //Y ServiceBase implement IDisposible
        [OperationContract]
        [WebInvoke(UriTemplate = "Ticket/",
                    Method = "POST")]
        Ticket Add(Ticket ticket);

        [OperationContract]
        [WebInvoke(UriTemplate = "Ticket/{idTicket}/AddDetail/",
                    Method = "POST")]
        Ticket AddDetail(int idTicket, Detail detail);


        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Ticket/GetTicket")]
        Ticket Get(int id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Ticket/{idTicket}/DeleteDetal/{idDetail}",
                    Method = "DELETE")]
        void DeleteDetail(int idTicket, Detail detail);
        
    }
}
