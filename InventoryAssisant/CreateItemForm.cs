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
    public partial class CreateItemForm : Form
    {
        private readonly IInventoryRepository _inventoryRepository;
        public CreateItemForm(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
            InitializeComponent();
        }

        private async void btnCreateNewItem_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtPrice.Text.Length == 0 || cmbCategory.Text.Length == 0)
            {
                MessageBox.Show("Neither Name nor Price can be empty!");
                return;
            }

            var item = new Item
            {
                Name = txtName.Text,
                Category = new ItemCategory { Name = cmbCategory.Text },//    cmbCategory.SelectedItem as ItemCategory,
                Company = txtCompany.Text,
                Price = decimal.Parse(txtPrice.Text)
            };

            var res = await _inventoryRepository.CreateItemAsync(item);
            if (res == false)
            {
                MessageBox.Show("Creation failed! It may be that the category you added is not in the database, if necessary, create it first");
            }
            else
            {
                var res2 = await _inventoryRepository.SaveDbAsync();
                if (res2 == true)
                {
                    MessageBox.Show("Creation success!");
                }
                else
                {
                    MessageBox.Show("Creation failed!");
                }
            }
        }

        private void CreateItemForm_Load(object sender, EventArgs e)
        {
            WireUpLists();
        }
        private async void WireUpLists()
        {
            cmbCategory.DataSource = null;
            cmbCategory.DataSource = await _inventoryRepository.GetAllCategoty();
            cmbCategory.DisplayMember = "Name";
            //mainForm.UpdateItemList();
        }
    }
}
