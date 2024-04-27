namespace InventoryAssisant
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRestock = new Button();
            btnRemove = new Button();
            btnEditItems = new Button();
            btnCreateItem = new Button();
            btnEditCategories = new Button();
            SuspendLayout();
            // 
            // btnRestock
            // 
            btnRestock.Location = new Point(12, 12);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(130, 73);
            btnRestock.TabIndex = 0;
            btnRestock.Text = "Restock";
            btnRestock.UseVisualStyleBackColor = true;
            btnRestock.Click += btnRestock_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(158, 12);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(130, 73);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEditItems
            // 
            btnEditItems.Location = new Point(306, 12);
            btnEditItems.Name = "btnEditItems";
            btnEditItems.Size = new Size(180, 73);
            btnEditItems.TabIndex = 2;
            btnEditItems.Text = "EditItems";
            btnEditItems.UseVisualStyleBackColor = true;
            btnEditItems.Click += btnEditItems_Click;
            // 
            // btnCreateItem
            // 
            btnCreateItem.Location = new Point(502, 12);
            btnCreateItem.Name = "btnCreateItem";
            btnCreateItem.Size = new Size(180, 73);
            btnCreateItem.TabIndex = 3;
            btnCreateItem.Text = "CreateItem";
            btnCreateItem.UseVisualStyleBackColor = true;
            btnCreateItem.Click += btnCreateItem_Click;
            // 
            // btnEditCategories
            // 
            btnEditCategories.Location = new Point(697, 12);
            btnEditCategories.Name = "btnEditCategories";
            btnEditCategories.Size = new Size(180, 73);
            btnEditCategories.TabIndex = 4;
            btnEditCategories.Text = "Edit Categories";
            btnEditCategories.UseVisualStyleBackColor = true;
            btnEditCategories.Click += btnEditCategories_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 559);
            Controls.Add(btnEditCategories);
            Controls.Add(btnCreateItem);
            Controls.Add(btnEditItems);
            Controls.Add(btnRemove);
            Controls.Add(btnRestock);
            Font = new Font("Times New Roman", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Assisant";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRestock;
        private Button btnRemove;
        private Button btnEditItems;
        private Button btnCreateItem;
        private Button btnEditCategories;
    }
}
