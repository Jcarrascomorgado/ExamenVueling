using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tickets
{
    public interface IRepositoryTicket
    {
        Ticket Add(Ticket ticket);
        Ticket AddDetail(int idTicket, Detail detail);
        Ticket Get(int id);
        void DeleteDetail(int idTicket, Detail detail);
    }
}
