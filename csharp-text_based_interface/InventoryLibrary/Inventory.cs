using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public string user_id { get; set; }
        public string item_id { get; set; }
        public int quantity { get; set; } = 1;

        public Inventory(string userId, string itemId)
        {
            this.user_id = userId;
            this.item_id = itemId;
        }
    }
}
