namespace InventoryAssisant
{
    partial class RemoveForm
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
            btnRemove = new Button();
            nudAmount = new NumericUpDown();
            lblItemAmount = new Label();
            cmbItem = new ComboBox();
            lblRemove = new Label();
            lblTips = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(313, 329);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 46);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(514, 144);
            nudAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(240, 38);
            nudAmount.TabIndex = 8;
            // 
            // lblItemAmount
            // 
            lblItemAmount.AutoSize = true;
            lblItemAmount.Location = new Point(420, 152);
            lblItemAmount.Name = "lblItemAmount";
            lblItemAmount.Size = new Size(28, 31);
            lblItemAmount.TabIndex = 7;
            lblItemAmount.Text = "0";
            // 
            // cmbItem
            // 
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(46, 144);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(300, 39);
            cmbItem.TabIndex = 6;
            cmbItem.SelectedIndexChanged += cmbItem_SelectedIndexChanged;
            // 
            // lblRemove
            // 
            lblRemove.AutoSize = true;
            lblRemove.Location = new Point(83, 76);
            lblRemove.Name = "lblRemove";
            lblRemove.Size = new Size(167, 31);
            lblRemove.TabIndex = 5;
            lblRemove.Text = "Remove Item";
            // 
            // lblTips
            // 
            lblTips.AutoSize = true;
            lblTips.Location = new Point(597, 259);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(0, 31);
            lblTips.TabIndex = 10;
            // 
            // RemoveForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTips);
            Controls.Add(btnRemove);
            Controls.Add(nudAmount);
            Controls.Add(lblItemAmount);
            Controls.Add(cmbItem);
            Controls.Add(lblRemove);
            Name = "RemoveForm";
            Text = "RemoveForm";
            Load += RemoveForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemove;
        private NumericUpDown nudAmount;
        private Label lblItemAmount;
        private ComboBox cmbItem;
        private Label lblRemove;
        private Label lblTips;
    }
}