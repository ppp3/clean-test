﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template.Domain.Entities
{
    public class OrderBook
    {
        public int Id { get; set; }

        public Order Order { get; set; }

        public int OrderId { get; set; }
        
        public Book Book { get; set; }

        public int BookId { get; set; }

        
    }
}
