﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ticket : EntityBase
    {
        public Ticket()
        {
            Details = new HashSet<Detail>();
        }

        public virtual ICollection<Detail> Details { get; set; }
        public DateTime Date { get; set; }
    }
}