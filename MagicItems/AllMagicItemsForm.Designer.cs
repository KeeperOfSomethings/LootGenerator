namespace LootGenerator.MagicItems
{
    partial class AllMagicItemsForm
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
            panel1 = new Panel();
            dgvAllItems = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllItems).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvAllItems);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 472);
            panel1.TabIndex = 0;
            // 
            // dgvAllItems
            // 
            dgvAllItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllItems.Dock = DockStyle.Fill;
            dgvAllItems.Location = new Point(0, 0);
            dgvAllItems.Name = "dgvAllItems";
            dgvAllItems.RowHeadersWidth = 51;
            dgvAllItems.RowTemplate.Height = 29;
            dgvAllItems.Size = new Size(1000, 472);
            dgvAllItems.TabIndex = 0;
            // 
            // AllMagicItemsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 41, 51);
            ClientSize = new Size(1000, 472);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AllMagicItemsForm";
            Text = "All Magic Items";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvAllItems;
    }
}