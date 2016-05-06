using Domain;
using Domain.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RepositoryTicket : RepositoryBase<Ticket>, IRepositoryTicket
    {

        public RepositoryTicket(IDbContext context) : base(context)
        {

        }

        public Ticket Add(Ticket ticket)
        {
            return Entity.Add(ticket);
        }

        public Ticket AddDetail(int idTicket, Detail detail)
        {
            var ticketDetail = Get(idTicket);
            ticketDetail.Details.Add(detail);
            return ticketDetail;
        }

        public Ticket Get(int id)
        {
            return Entity.Where(c=>c.Id==id).FirstOrDefault();
        }

        public void DeleteDetail(int idTicket, Detail detail)
        {
            var tickeDetail = Get(idTicket);
            tickeDetail.Details.Remove(detail);
        }
    }
}
