using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRPTools.Models
{
    public class Order
    {
        public User UserID { get; set; }

        public int OrderID { get; set; }

        public IList<CupType> CupType { get; set; }

        public IList<Glitter> Glitter { get; set; }


    }
}
