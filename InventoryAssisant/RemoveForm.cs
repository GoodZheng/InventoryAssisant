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
    public partial class RemoveForm : Form
    {
        private readonly IInventoryRepository _inventoryRepository;

        public RemoveForm(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
            InitializeComponent();
        }

        private void RemoveForm_Load(object sender, EventArgs e)
        {
            WireUpList();
        }

        private async void WireUpList()
        {
            cmbItem.DataSource = null;
            cmbItem.DataSource = await _inventoryRepository.GetAllItems();
            cmbItem.DisplayMember = "Name"; //只显示item的Name属性即可
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = cmbItem.SelectedItem as Item;
            lblItemAmount.Text = item?.Amount.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var item = cmbItem.SelectedItem as Item;
            int amount = (int)nudAmount.Value; //要减少的数量

            if (item != null && amount > 0)
            {
                if(amount>item.Amount)
                {
                    MessageBox.Show("The quantity to be reduced exceeds the inventory quantity.");
                    return;
                }
                RemoveAmountForItem(item, amount);
            }
        }

        private async void RemoveAmountForItem(Item item, int amount)
        {
            item.Amount -= amount;

            _inventoryRepository.UpdateItem(item);

            var res = await _inventoryRepository.SaveDbAsync();
            if (res == true)
            {
                lblTips.Text = "update successfully!";
                lblItemAmount.Text = item.Amount.ToString();
            }
            else
            {
                lblTips.Text = "Update failure!";
            }
        }
    }
}
