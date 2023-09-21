using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public class IDelivery
    {
        public int Id { get; set; }
        public string Name { get; }
        public int Price { get; set; }
    }
}
