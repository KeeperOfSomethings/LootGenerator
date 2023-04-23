namespace LootGenerator
{
    partial class FormMain
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
            pAllTabs = new Panel();
            btnTabBooks = new Button();
            btnTabMagicItems = new Button();
            pSubWindow = new Panel();
            panel1 = new Panel();
            pAllTabs.SuspendLayout();
            SuspendLayout();
            // 
            // pAllTabs
            // 
            pAllTabs.Controls.Add(btnTabBooks);
            pAllTabs.Controls.Add(btnTabMagicItems);
            pAllTabs.Dock = DockStyle.Top;
            pAllTabs.Location = new Point(0, 0);
            pAllTabs.Name = "pAllTabs";
            pAllTabs.Size = new Size(932, 43);
            pAllTabs.TabIndex = 0;
            // 
            // btnTabBooks
            // 
            btnTabBooks.BackColor = Color.FromArgb(255, 128, 128);
            btnTabBooks.Dock = DockStyle.Left;
            btnTabBooks.Enabled = false;
            btnTabBooks.FlatStyle = FlatStyle.Popup;
            btnTabBooks.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnTabBooks.ForeColor = Color.Black;
            btnTabBooks.Location = new Point(126, 0);
            btnTabBooks.Name = "btnTabBooks";
            btnTabBooks.Size = new Size(126, 43);
            btnTabBooks.TabIndex = 1;
            btnTabBooks.Text = "Books";
            btnTabBooks.UseVisualStyleBackColor = false;
            btnTabBooks.Visible = false;
            // 
            // btnTabMagicItems
            // 
            btnTabMagicItems.BackColor = Color.FromArgb(62, 120, 138);
            btnTabMagicItems.Dock = DockStyle.Left;
            btnTabMagicItems.FlatAppearance.BorderSize = 0;
            btnTabMagicItems.FlatStyle = FlatStyle.Flat;
            btnTabMagicItems.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnTabMagicItems.ForeColor = Color.Black;
            btnTabMagicItems.Location = new Point(0, 0);
            btnTabMagicItems.Margin = new Padding(0);
            btnTabMagicItems.Name = "btnTabMagicItems";
            btnTabMagicItems.Size = new Size(126, 43);
            btnTabMagicItems.TabIndex = 0;
            btnTabMagicItems.Text = "Magic Items";
            btnTabMagicItems.UseVisualStyleBackColor = false;
            btnTabMagicItems.Click += btnTabMagicItems_Click;
            // 
            // pSubWindow
            // 
            pSubWindow.Dock = DockStyle.Fill;
            pSubWindow.Location = new Point(0, 43);
            pSubWindow.Name = "pSubWindow";
            pSubWindow.Size = new Size(932, 510);
            pSubWindow.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 120, 138);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 2);
            panel1.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 41, 51);
            ClientSize = new Size(932, 553);
            Controls.Add(panel1);
            Controls.Add(pSubWindow);
            Controls.Add(pAllTabs);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            MinimumSize = new Size(950, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lootgenerator";
            pAllTabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pAllTabs;
        private Button btnTabBooks;
        private Button btnTabMagicItems;
        private Panel pSubWindow;
        private Panel panel1;
    }
}