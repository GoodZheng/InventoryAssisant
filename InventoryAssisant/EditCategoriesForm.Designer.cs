namespace InventoryAssisant
{
    partial class EditCategoriesForm
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
            pnlItems = new Panel();
            label1 = new Label();
            lstbCategories = new ListBox();
            btnRemoveSelected = new Button();
            label2 = new Label();
            btnSaveChanges = new Button();
            txtCategoryName = new TextBox();
            lblCategories = new Label();
            lblEditCategories = new Label();
            pnlItems.SuspendLayout();
            SuspendLayout();
            // 
            // pnlItems
            // 
            pnlItems.Controls.Add(label1);
            pnlItems.Controls.Add(lstbCategories);
            pnlItems.Location = new Point(12, 12);
            pnlItems.Name = "pnlItems";
            pnlItems.Size = new Size(478, 852);
            pnlItems.TabIndex = 5;
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
            // lstbCategories
            // 
            lstbCategories.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lstbCategories.FormattingEnabled = true;
            lstbCategories.ItemHeight = 41;
            lstbCategories.Location = new Point(16, 87);
            lstbCategories.Margin = new Padding(5);
            lstbCategories.Name = "lstbCategories";
            lstbCategories.Size = new Size(448, 742);
            lstbCategories.TabIndex = 0;
            lstbCategories.SelectedIndexChanged += lstbCategories_SelectedIndexChanged;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(555, 567);
            btnRemoveSelected.Margin = new Padding(5);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(439, 93);
            btnRemoveSelected.TabIndex = 17;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += this.btnRemoveSelected_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 192, 128);
            label2.Location = new Point(496, 212);
            label2.Name = "label2";
            label2.Size = new Size(143, 50);
            label2.TabIndex = 16;
            label2.Text = "Name:";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(555, 456);
            btnSaveChanges.Margin = new Padding(5);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(439, 93);
            btnSaveChanges.TabIndex = 13;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(686, 224);
            txtCategoryName.Margin = new Padding(5);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(295, 38);
            txtCategoryName.TabIndex = 15;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(572, 128);
            lblCategories.Margin = new Padding(5, 0, 5, 0);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(172, 31);
            lblCategories.TabIndex = 14;
            lblCategories.Text = "<item name>";
            // 
            // lblEditCategories
            // 
            lblEditCategories.AutoSize = true;
            lblEditCategories.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblEditCategories.ForeColor = Color.FromArgb(128, 128, 255);
            lblEditCategories.Location = new Point(602, 55);
            lblEditCategories.Margin = new Padding(5, 0, 5, 0);
            lblEditCategories.Name = "lblEditCategories";
            lblEditCategories.Size = new Size(222, 57);
            lblEditCategories.TabIndex = 12;
            lblEditCategories.Text = "Edit Item";
            // 
            // EditCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 877);
            Controls.Add(btnRemoveSelected);
            Controls.Add(label2);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtCategoryName);
            Controls.Add(lblCategories);
            Controls.Add(lblEditCategories);
            Controls.Add(pnlItems);
            Name = "EditCategoriesForm";
            Text = "EditCategories";
            Load += EditCategories_Load;
            pnlItems.ResumeLayout(false);
            pnlItems.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlItems;
        private Label label1;
        private ListBox lstbCategories;
        private Button btnRemoveSelected;
        private Label label2;
        private Button btnSaveChanges;
        private TextBox txtCategoryName;
        private Label lblCategories;
        private Label lblEditCategories;
    }
}