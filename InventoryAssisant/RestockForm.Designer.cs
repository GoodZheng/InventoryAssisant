namespace InventoryAssisant
{
    partial class RestockForm
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
            lblRestock = new Label();
            cmbItem = new ComboBox();
            lblItemAmount = new Label();
            nudAmount = new NumericUpDown();
            btnRestock = new Button();
            lblTips = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // lblRestock
            // 
            lblRestock.AutoSize = true;
            lblRestock.Location = new Point(74, 64);
            lblRestock.Name = "lblRestock";
            lblRestock.Size = new Size(163, 31);
            lblRestock.TabIndex = 0;
            lblRestock.Text = "Restock Item";
            // 
            // cmbItem
            // 
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(37, 132);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(300, 39);
            cmbItem.TabIndex = 1;
            cmbItem.SelectedIndexChanged += cmbItem_SelectedIndexChanged;
            // 
            // lblItemAmount
            // 
            lblItemAmount.AutoSize = true;
            lblItemAmount.Location = new Point(411, 140);
            lblItemAmount.Name = "lblItemAmount";
            lblItemAmount.Size = new Size(28, 31);
            lblItemAmount.TabIndex = 2;
            lblItemAmount.Text = "0";
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(505, 132);
            nudAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(240, 38);
            nudAmount.TabIndex = 3;
            // 
            // btnRestock
            // 
            btnRestock.Location = new Point(304, 317);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(150, 46);
            btnRestock.TabIndex = 4;
            btnRestock.Text = "Restock";
            btnRestock.UseVisualStyleBackColor = true;
            btnRestock.Click += btnRestock_Click;
            // 
            // lblTips
            // 
            lblTips.AutoSize = true;
            lblTips.Location = new Point(625, 290);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(0, 31);
            lblTips.TabIndex = 5;
            // 
            // RestockForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTips);
            Controls.Add(btnRestock);
            Controls.Add(nudAmount);
            Controls.Add(lblItemAmount);
            Controls.Add(cmbItem);
            Controls.Add(lblRestock);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RestockForm";
            Text = "Restock";
            Load += RestockForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRestock;
        private ComboBox cmbItem;
        private Label lblItemAmount;
        private NumericUpDown nudAmount;
        private Button btnRestock;
        private Label lblTips;
    }
}