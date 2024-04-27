using InventoryAssisant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssisant.Services
{
    public interface IInventoryRepository
    {
        Task<List<Item>> GetAllItems();

        /// <summary>
        /// 用item更新与item.Id相匹配的项
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool UpdateItem(Item item);

        void AddItem(Item item);

        Task<List<ItemCategory>> GetAllCategoty();
        void DeleteItem(Item item);

        Task<bool> SaveDbAsync();
        Task<bool> CreateItemAsync(Item item);
        Task<bool> UpdateItemCategoryAsync(ItemCategory newItemCategory);
        void DeleteItemCategory(ItemCategory itemCategory);
    }
}
