using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ20.Net_Week6_Task.Inventory
{
    public static class InventoryAction
    {
        public static void InventorySet()
        {

            List<Items> itemlist = new List<Items>
            {
                new Items { ItemId = 1, ItemDes = "Bag" },
                new Items { ItemId = 2, ItemDes = "Pen" },
                new Items { ItemId = 3, ItemDes = "Book" },
                new Items { ItemId = 4, ItemDes = "Shoe" },
                new Items { ItemId = 5, ItemDes = "Pin" }
            };

            List<Sales> saleslist = new List<Sales>
            {
                new Sales{ InvNo=1, ItemId = 3, Qty = 10 },
                new Sales{ InvNo=2, ItemId = 2, Qty = 20 },
                new Sales{ InvNo=3, ItemId = 3, Qty = 500 },
                new Sales{ InvNo=4, ItemId = 4, Qty = 20 },
                new Sales{ InvNo=5, ItemId = 3, Qty = 100 },
                new Sales{ InvNo=6, ItemId = 1, Qty = 50 }
            };

            var query = from sale in saleslist
                join item in itemlist on sale.ItemId equals item.ItemId
                select new { item.ItemId, item.ItemDes, sale.Qty };

            Console.WriteLine("Item ID\tItem Name \tQuantity");
            Console.WriteLine("---------------------------------------");

            foreach (var result in query)
            {
                Console.WriteLine($"{result.ItemId}\t{result.ItemDes}      \t{result.Qty}");
                Console.WriteLine("\n\n");
            }
        }
    } 
    
}
