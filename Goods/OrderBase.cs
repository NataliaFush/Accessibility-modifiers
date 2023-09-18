using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    public abstract class OrderBase
    {
        public int id;
        public List<ItemBase> Items { get; set; }
        public long Price { get 
            {
                if (Items != null && Items.Any())
                {
                    return Items.Sum(x => x.Price);
                }
                else
                {
                    return 0;
                }
            } }
        public int quantity;



        protected OrderBase()
        {
        }


    }
}
