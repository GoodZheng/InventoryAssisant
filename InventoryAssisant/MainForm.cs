using InventoryAssisant.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryAssisant
{
    public partial class MainForm : Form
    {
        public MainForm(IInventoryRepository inventoryRepository)
        {
            InitializeComponent();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            //Form f = new RestockForm(_inventoryRepository);
            var f = Program.ServiceProvider.GetRequiredService<RestockForm>();
            f.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Form f = new RemoveForm(_inventoryRepository);
            var f = Program.ServiceProvider.GetRequiredService<RemoveForm>();
            f.ShowDialog();
        }

        private void btnEditItems_Click(object sender, EventArgs e)
        {
            //Form f = new EditItemsForm(_inventoryRepository);
            var f = Program.ServiceProvider.GetRequiredService<EditItemsForm>();
            f.ShowDialog();
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            //Form f = new CreateItemForm(_inventoryRepository);
            var f = Program.ServiceProvider.GetRequiredService<CreateItemForm>();
            f.ShowDialog();
        }

        private void btnEditCategories_Click(object sender, EventArgs e)
        {
            var f = Program.ServiceProvider.GetRequiredService<EditCategoriesForm>();
            f.ShowDialog();
        }
    }
}
