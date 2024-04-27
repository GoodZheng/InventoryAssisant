using InventoryAssisant.Models;
using InventoryAssisant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAssisant
{
    public partial class EditCategoriesForm : Form
    {
        private readonly IInventoryRepository _inventoryRepository;
        public EditCategoriesForm(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
            InitializeComponent();
        }

        private void EditCategories_Load(object sender, EventArgs e)
        {
            WireUpList();
        }

        private async void WireUpList()
        {
            lstbCategories.DataSource = null;
            lstbCategories.DataSource = await _inventoryRepository.GetAllCategoty();
            lstbCategories.DisplayMember = "Name";

            //mainForm.UpdateCategoryList();
        }
        private void lstbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstbCategories.SelectedItem is ItemCategory category)
            {
                lblCategories.Text = category.Name;
                txtCategoryName.Text = category.Name;
            }
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(txtCategoryName.Text.Length>0 && lstbCategories.SelectedItem is ItemCategory itemCategory)
            {
                var newItemCategory = new ItemCategory()
                {
                    Id = itemCategory.Id,
                    Name = txtCategoryName.Text,
                };
                var res = await _inventoryRepository.UpdateItemCategoryAsync(newItemCategory);
                if(res == true)
                {
                    var res1 = await _inventoryRepository.SaveDbAsync();
                    if(res1 == true)
                    {
                        MessageBox.Show("Successfully!");
                        WireUpList(); //刷新一下显示
                        return;
                    }
                }
            }
            MessageBox.Show("Unsuccessfully!");
        }
        private async void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if(lstbCategories.SelectedItem is ItemCategory itemCategory)
            {
                var confirm = MessageBox.Show("Are you sure you want to remove the selected category? \n" +
                                         $"All items belonging to {itemCategory.Name} are also deleted.",
                                         "Delete category",
                                         MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _inventoryRepository.DeleteItemCategory(itemCategory);
                    var res = await _inventoryRepository.SaveDbAsync();
                    if(res == true)
                    {
                        MessageBox.Show("Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessfully!");
                    }
                    WireUpList();
                }
            }
        }
    }
}
