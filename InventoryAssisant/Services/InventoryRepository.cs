using InventoryAssisant.DataBase;
using InventoryAssisant.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssisant.Services
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly AppDbContext _context;

        public InventoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool UpdateItem(Item item)
        {
            var originalItem = _context.Items.FirstOrDefault(i => i.Id == item.Id);
            if(originalItem != null)
            {
                originalItem.Name = item.Name;

                originalItem.Company=item.Company;

                originalItem.Price = item.Price;

                originalItem.Amount = item.Amount;

                originalItem.Category = item.Category;

                _context.Items.Update(originalItem);
                
                return true;
            }

            return false;
        }

        public void AddItem(Item item)
        {
            if(item == null) throw new ArgumentNullException(nameof(item));

            _context.Items.Add(item);
        }

        public async Task<List<Item>> GetAllItems()
        {
            return await _context.Items.Include(x=>x.Category).ToListAsync();
        }

        public async Task<List<ItemCategory>> GetAllCategoty()
        {
            return await _context.Categories.ToListAsync();
        }

        public void DeleteItem(Item item)
        {
            _context.Items.Remove(item);
        }

        public async Task<bool> SaveDbAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public async Task<bool> CreateItemAsync(Item item)
        {
            ItemCategory? itemCategory = await _context.Categories.FirstOrDefaultAsync(i=>i.Name==item.Category.Name);
            if(itemCategory == null)
            {
                return false;
            }
            else
            {
                item.Category = itemCategory;
                //item.Id = 1;
                await _context.Items.AddAsync(item);
                return true;
            }
        }

        public async Task<bool> UpdateItemCategoryAsync(ItemCategory newItemCategory)
        {
            var originalItemCategory = await _context.Categories.FirstOrDefaultAsync(c => c.Id == newItemCategory.Id);
            if(originalItemCategory!=null)
            {
                originalItemCategory.Name = newItemCategory.Name;
                _context.Categories.Update(originalItemCategory);
                return true;
            }
            return false;
        }

        public void DeleteItemCategory(ItemCategory itemCategory)
        {
            _context.Categories.Remove(itemCategory);
        }
    }
}
