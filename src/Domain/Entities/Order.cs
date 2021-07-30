using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public DateTime Date { get; set; }

        public IList<OrderPosition> OrderPosition { get; private set; } = new List<OrderPosition>(); 
 
    }
}
