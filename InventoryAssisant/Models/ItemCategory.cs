using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssisant.Models
{
    public class ItemCategory
    {
        /// <summary>
        /// The ID of the item category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the item category.
        /// </summary>
        public string Name { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();
    }
}
