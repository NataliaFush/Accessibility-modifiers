using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    public abstract class ItemBase
    {
        public string catagories;
        public int Id { get; set; }
        public uint Price { get; set; }
        public string ItemName { get; set; }
    }
}
