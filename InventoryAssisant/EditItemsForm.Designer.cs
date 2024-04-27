namespace InventoryAssisant
{
    partial class EditItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstbItems = new ListBox();
            cmbCategory = new ComboBox();
            panel1 = new Panel();
            btnCreateNewItem = new Button();
            btnRemoveSelected = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPrice = new TextBox();
            btnSaveChanges = new Button();
            txtCompany = new TextBox();
            txtName = new TextBox();
            lblItemName = new Label();
            lblEditItem = new Label();
            pnlItems = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            pnlItems.SuspendLayout();
            SuspendLayout();
            // 
            // lstbItems
            // 
            lstbItems.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lstbItems.FormattingEnabled = true;
            lstbItems.ItemHeight = 41;
            lstbItems.Location = new Point(16, 87);
            lstbItems.Margin = new Padding(5);
            lstbItems.Name = "lstbItems";
            lstbItems.Size = new Size(448, 988);
            lstbItems.TabIndex = 0;
            lstbItems.SelectedIndexChanged += lstbItems_SelectedIndexChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(234, 323);
            cmbCategory.Margin = new Padding(5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(376, 56);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCreateNewItem);
            panel1.Controls.Add(btnRemoveSelected);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(btnSaveChanges);
            panel1.Controls.Add(txtCompany);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblItemName);
            panel1.Controls.Add(lblEditItem);
            panel1.Controls.Add(cmbCategory);
            panel1.Location = new Point(509, 33);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 1089);
            panel1.TabIndex = 2;
            // 
            // btnCreateNewItem
            // 
            btnCreateNewItem.Location = new Point(17, 962);
            btnCreateNewItem.Margin = new Padding(5);
            btnCreateNewItem.Name = "btnCreateNewItem";
            btnCreateNewItem.Size = new Size(591, 93);
            btnCreateNewItem.TabIndex = 12;
            btnCreateNewItem.Text = "Create New Item";
            btnCreateNewItem.UseVisualStyleBackColor = true;
            btnCreateNewItem.Click += btnCreateNewItem_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(19, 851);
            btnRemoveSelected.Margin = new Padding(5);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(591, 93);
            btnRemoveSelected.TabIndex = 11;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 192, 128);
            label5.Location = new Point(51, 647);
            label5.Name = "label5";
            label5.Size = new Size(125, 50);
            label5.TabIndex = 10;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 192, 128);
            label4.Location = new Point(17, 488);
            label4.Name = "label4";
            label4.Size = new Size(209, 50);
            label4.TabIndex = 9;
            label4.Text = "Company:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 192, 128);
            label3.Location = new Point(19, 325);
            label3.Name = "label3";
            label3.Size = new Size(202, 50);
            label3.TabIndex = 8;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 192, 128);
            label2.Location = new Point(51, 164);
            label2.Name = "label2";
            label2.Size = new Size(143, 50);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(234, 643);
            txtPrice.Margin = new Padding(5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(376, 54);
            txtPrice.TabIndex = 6;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(19, 740);
            btnSaveChanges.Margin = new Padding(5);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(591, 93);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(234, 484);
            txtCompany.Margin = new Padding(5);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(376, 54);
            txtCompany.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(234, 164);
            txtName.Margin = new Padding(5);
            txtName.Name = "txtName";
            txtName.Size = new Size(376, 54);
            txtName.TabIndex = 4;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(177, 87);
            lblItemName.Margin = new Padding(5, 0, 5, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(264, 48);
            lblItemName.TabIndex = 3;
            lblItemName.Text = "<item name>";
            // 
            // lblEditItem
            // 
            lblEditItem.AutoSize = true;
            lblEditItem.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblEditItem.ForeColor = Color.FromArgb(128, 128, 255);
            lblEditItem.Location = new Point(207, 14);
            lblEditItem.Margin = new Padding(5, 0, 5, 0);
            lblEditItem.Name = "lblEditItem";
            lblEditItem.Size = new Size(222, 57);
            lblEditItem.TabIndex = 2;
            lblEditItem.Text = "Edit Item";
            // 
            // pnlItems
            // 
            pnlItems.Controls.Add(label1);
            pnlItems.Controls.Add(lstbItems);
            pnlItems.Location = new Point(23, 33);
            pnlItems.Name = "pnlItems";
            pnlItems.Size = new Size(478, 1089);
            pnlItems.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(34, 14);
            label1.Name = "label1";
            label1.Size = new Size(145, 57);
            label1.TabIndex = 1;
            label1.Text = "Items";
            // 
            // EditItemsForm
            // 
            AutoScaleDimensions = new SizeF(22F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 1127);
            Controls.Add(pnlItems);
            Controls.Add(panel1);
            Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(5);
            Name = "EditItemsForm";
            Text = "EditItemsForm";
            Load += EditItemsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlItems.ResumeLayout(false);
            pnlItems.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstbItems;
        private ComboBox cmbCategory;
        private Panel panel1;
        private TextBox txtPrice;
        private TextBox txtCompany;
        private TextBox txtName;
        private Label lblItemName;
        private Label lblEditItem;
        private Button btnSaveChanges;
        private Label label3;
        private Label label2;
        private Panel pnlItems;
        private Label label1;
        private Button btnCreateNewItem;
        private Button btnRemoveSelected;
        private Label label5;
        private Label label4;
    }
}