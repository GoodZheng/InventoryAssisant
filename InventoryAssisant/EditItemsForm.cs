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
    public partial class EditItemsForm : Form
    {
        private readonly IInventoryRepository _inventoryRepository;
        public EditItemsForm(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
            InitializeComponent();
        }



        private void EditItemsForm_Load(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private async void WireUpLists(Item itemToSelect = null)
        {
            var itemSelected = lstbItems.SelectedItem as Item;

            if (itemSelected != null)
            {
                var index = lstbItems.Items.IndexOf(itemSelected);
                lstbItems.SelectedItem = lstbItems.Items[index];
            }

            cmbCategory.DataSource = null;
            cmbCategory.DataSource = await _inventoryRepository.GetAllCategoty();
            cmbCategory.DisplayMember = "Name";

            lstbItems.DataSource = null;
            lstbItems.DataSource = await _inventoryRepository.GetAllItems();
            lstbItems.DisplayMember = "Name";

            //mainForm.UpdateItemList();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lstbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstbItems.SelectedItem as Item;
            if (item != null)
            {
                DisplayByItem(item);
            }
        }

        /// <summary>
        /// 将item显示在右侧操作区
        /// </summary>
        /// <param name="item"></param>
        private void DisplayByItem(Item? item)
        {
            if (item == null)
            {
                lblItemName.Text = "No Item";
                txtName.Text = "";
                txtCompany.Text = "";
                txtPrice.Text = "";
                cmbCategory.Text = "";
            }
            else
            {
                lblItemName.Text = item.Name;
                txtName.Text = item.Name;
                txtCompany.Text = item.Company;
                txtPrice.Text = item.Price.ToString();
                if (item.Category != null)
                {
                    cmbCategory.SelectedItem = item.Category;
                }
            }
        }

        /// <summary>
        /// 在操作之后要做的事情。包括显示操作结果提示框
        /// </summary>
        /// <param name="item"></param>
        private void DoAfterOperations(bool operationRes)
        {
            if (operationRes == false)
            {
                MessageBox.Show("Operation failure!");
            }
            else
            {
                MessageBox.Show("Operation success!");
            }
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtPrice.Text.Length == 0)
            {
                MessageBox.Show("Neither Name nor Price can be empty!");
                return;
            }
            if (lstbItems.SelectedItem is Item item)
            {
                var itemToEdit = new Item
                {
                    Id = item.Id,
                    Name = txtName.Text,
                    Category = cmbCategory.SelectedItem as ItemCategory,
                    Company = txtCompany.Text,
                    Price = decimal.Parse(txtPrice.Text)
                };

                _inventoryRepository.UpdateItem(itemToEdit);
                var res = await _inventoryRepository.SaveDbAsync();

                DoAfterOperations(res);
            }
        }

        private async void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lstbItems.SelectedItem is Item item)
            {
                var confirm = MessageBox.Show("Are you sure you want to remove the selected item? \n" +
                                          "This will permanently delete it from the database.",
                                          "Delete item",
                                          MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _inventoryRepository.DeleteItem(item);
                    var res = await _inventoryRepository.SaveDbAsync();

                    DoAfterOperations(res);
                    WireUpLists(); //重新读取数据库数据
                }
            }
        }

        private void btnCreateNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
