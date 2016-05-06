using Domain;
using Domain.Tickets;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceTicket" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceTicket.svc o ServiceTicket.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceTicket : ServiceBase ,IServiceTicket
    {
        IRepositoryTicket _repository;
        IUnitOfWork _iUnitOfWork;
        public ServiceTicket(IRepositoryTicket repository, IUnitOfWork iUnitOfWork)
            : base (iUnitOfWork)
        {
            if (null == repository)
            {
                throw new ArgumentNullException("Repository Ticket");
            }
            if (null == iUnitOfWork)
            {
                throw new ArgumentNullException("iUnitofWork");
            }

            _repository = repository;
            _iUnitOfWork = iUnitOfWork;
        }

        public Ticket Add(Ticket ticket)
        {
            var ticketNew = _repository.Add(ticket);
            _iUnitOfWork.SaveChanges();
            return ticketNew;
        }

        public Ticket AddDetail(int idTicket, Detail detail)
        {

            var ticketDetail = Get(idTicket);
            ticketDetail.Details.Add(detail);
            _iUnitOfWork.SaveChanges();        
            return ticketDetail;
        }

        public Ticket Get(int id)
        {
            var ticketId = _repository.Get(id);
            return ticketId;
        }

        public void DeleteDetail(int idTicket, Detail detail)
        {
            var tickeDetail = Get(idTicket);
            tickeDetail.Details.Remove(detail);
            _iUnitOfWork.SaveChanges();
        }
    }
}
