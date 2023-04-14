namespace LootGenerator
{
    partial class MagicItemsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pMiMenu = new Panel();
            btnLoot = new Button();
            btnMassloot = new Button();
            pMax = new Panel();
            lMax = new Label();
            numMax = new NumericUpDown();
            pMin = new Panel();
            lMinimum = new Label();
            numMin = new NumericUpDown();
            panel1 = new Panel();
            pWondrousSubMenu = new Panel();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            btnWondrous = new Button();
            pArmorSubMenu = new Panel();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            btnArmor = new Button();
            pWeaponsSubMenu = new Panel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            btnWeapons = new Button();
            pRubrikSubMenu = new Panel();
            cbSummoning = new CheckBox();
            cbConsumable = new CheckBox();
            cbNoncombat = new CheckBox();
            cbCombat = new CheckBox();
            cbRubrikAll = new CheckBox();
            btnRubrik = new Button();
            pRightBorder = new Panel();
            pGrid = new Panel();
            dgvResult = new DataGridView();
            pMiMenu.SuspendLayout();
            pMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMax).BeginInit();
            pMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            pWondrousSubMenu.SuspendLayout();
            pArmorSubMenu.SuspendLayout();
            pWeaponsSubMenu.SuspendLayout();
            pRubrikSubMenu.SuspendLayout();
            pGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // pMiMenu
            // 
            pMiMenu.AutoScroll = true;
            pMiMenu.BackColor = Color.FromArgb(44, 41, 51);
            pMiMenu.Controls.Add(btnLoot);
            pMiMenu.Controls.Add(btnMassloot);
            pMiMenu.Controls.Add(pMax);
            pMiMenu.Controls.Add(numMax);
            pMiMenu.Controls.Add(pMin);
            pMiMenu.Controls.Add(numMin);
            pMiMenu.Controls.Add(panel1);
            pMiMenu.Controls.Add(pWondrousSubMenu);
            pMiMenu.Controls.Add(btnWondrous);
            pMiMenu.Controls.Add(pArmorSubMenu);
            pMiMenu.Controls.Add(btnArmor);
            pMiMenu.Controls.Add(pWeaponsSubMenu);
            pMiMenu.Controls.Add(btnWeapons);
            pMiMenu.Controls.Add(pRubrikSubMenu);
            pMiMenu.Controls.Add(btnRubrik);
            pMiMenu.Controls.Add(pRightBorder);
            pMiMenu.Dock = DockStyle.Left;
            pMiMenu.Location = new Point(0, 0);
            pMiMenu.Name = "pMiMenu";
            pMiMenu.Size = new Size(196, 845);
            pMiMenu.TabIndex = 1;
            // 
            // btnLoot
            // 
            btnLoot.Dock = DockStyle.Top;
            btnLoot.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnLoot.FlatStyle = FlatStyle.Flat;
            btnLoot.ForeColor = Color.Gainsboro;
            btnLoot.Location = new Point(0, 896);
            btnLoot.Name = "btnLoot";
            btnLoot.Padding = new Padding(10, 0, 0, 0);
            btnLoot.Size = new Size(174, 35);
            btnLoot.TabIndex = 15;
            btnLoot.Text = "Loot";
            btnLoot.TextAlign = ContentAlignment.MiddleLeft;
            btnLoot.UseVisualStyleBackColor = true;
            btnLoot.Click += btnLoot_Click;
            // 
            // btnMassloot
            // 
            btnMassloot.Dock = DockStyle.Top;
            btnMassloot.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnMassloot.FlatStyle = FlatStyle.Flat;
            btnMassloot.ForeColor = Color.Gainsboro;
            btnMassloot.Location = new Point(0, 861);
            btnMassloot.Name = "btnMassloot";
            btnMassloot.Padding = new Padding(10, 0, 0, 0);
            btnMassloot.Size = new Size(174, 35);
            btnMassloot.TabIndex = 14;
            btnMassloot.Text = "Massloot";
            btnMassloot.TextAlign = ContentAlignment.MiddleLeft;
            btnMassloot.UseVisualStyleBackColor = true;
            btnMassloot.Click += btnMassloot_Click;
            // 
            // pMax
            // 
            pMax.Controls.Add(lMax);
            pMax.Dock = DockStyle.Top;
            pMax.Location = new Point(0, 826);
            pMax.Name = "pMax";
            pMax.Size = new Size(174, 35);
            pMax.TabIndex = 13;
            // 
            // lMax
            // 
            lMax.AutoSize = true;
            lMax.Dock = DockStyle.Fill;
            lMax.ForeColor = Color.Gainsboro;
            lMax.Location = new Point(0, 0);
            lMax.Name = "lMax";
            lMax.Size = new Size(90, 21);
            lMax.TabIndex = 0;
            lMax.Text = "Maximum";
            lMax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numMax
            // 
            numMax.Dock = DockStyle.Top;
            numMax.Location = new Point(0, 798);
            numMax.Name = "numMax";
            numMax.Size = new Size(174, 28);
            numMax.TabIndex = 12;
            numMax.TextAlign = HorizontalAlignment.Right;
            numMax.ValueChanged += numMax_ValueChanged;
            // 
            // pMin
            // 
            pMin.Controls.Add(lMinimum);
            pMin.Dock = DockStyle.Top;
            pMin.Location = new Point(0, 763);
            pMin.Name = "pMin";
            pMin.Size = new Size(174, 35);
            pMin.TabIndex = 11;
            // 
            // lMinimum
            // 
            lMinimum.AutoSize = true;
            lMinimum.Dock = DockStyle.Fill;
            lMinimum.ForeColor = Color.Gainsboro;
            lMinimum.Location = new Point(0, 0);
            lMinimum.Name = "lMinimum";
            lMinimum.Size = new Size(83, 21);
            lMinimum.TabIndex = 0;
            lMinimum.Text = "Minimum";
            lMinimum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numMin
            // 
            numMin.Dock = DockStyle.Top;
            numMin.Location = new Point(0, 735);
            numMin.Name = "numMin";
            numMin.Size = new Size(174, 28);
            numMin.TabIndex = 10;
            numMin.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 715);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 20);
            panel1.TabIndex = 9;
            // 
            // pWondrousSubMenu
            // 
            pWondrousSubMenu.BackColor = Color.FromArgb(50, 50, 50);
            pWondrousSubMenu.Controls.Add(button19);
            pWondrousSubMenu.Controls.Add(button20);
            pWondrousSubMenu.Controls.Add(button21);
            pWondrousSubMenu.Controls.Add(button22);
            pWondrousSubMenu.Controls.Add(button23);
            pWondrousSubMenu.Dock = DockStyle.Top;
            pWondrousSubMenu.Location = new Point(0, 565);
            pWondrousSubMenu.Name = "pWondrousSubMenu";
            pWondrousSubMenu.Size = new Size(174, 150);
            pWondrousSubMenu.TabIndex = 8;
            // 
            // button19
            // 
            button19.Dock = DockStyle.Top;
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ForeColor = Color.Gainsboro;
            button19.Location = new Point(0, 120);
            button19.Name = "button19";
            button19.Padding = new Padding(35, 0, 0, 0);
            button19.Size = new Size(174, 30);
            button19.TabIndex = 4;
            button19.Text = "button19";
            button19.TextAlign = ContentAlignment.MiddleLeft;
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Dock = DockStyle.Top;
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.ForeColor = Color.Gainsboro;
            button20.Location = new Point(0, 90);
            button20.Name = "button20";
            button20.Padding = new Padding(35, 0, 0, 0);
            button20.Size = new Size(174, 30);
            button20.TabIndex = 3;
            button20.Text = "button20";
            button20.TextAlign = ContentAlignment.MiddleLeft;
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Dock = DockStyle.Top;
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.ForeColor = Color.Gainsboro;
            button21.Location = new Point(0, 60);
            button21.Name = "button21";
            button21.Padding = new Padding(35, 0, 0, 0);
            button21.Size = new Size(174, 30);
            button21.TabIndex = 2;
            button21.Text = "button21";
            button21.TextAlign = ContentAlignment.MiddleLeft;
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Dock = DockStyle.Top;
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatStyle = FlatStyle.Flat;
            button22.ForeColor = Color.Gainsboro;
            button22.Location = new Point(0, 30);
            button22.Name = "button22";
            button22.Padding = new Padding(35, 0, 0, 0);
            button22.Size = new Size(174, 30);
            button22.TabIndex = 1;
            button22.Text = "button22";
            button22.TextAlign = ContentAlignment.MiddleLeft;
            button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Dock = DockStyle.Top;
            button23.FlatAppearance.BorderSize = 0;
            button23.FlatStyle = FlatStyle.Flat;
            button23.ForeColor = Color.Gainsboro;
            button23.Location = new Point(0, 0);
            button23.Name = "button23";
            button23.Padding = new Padding(35, 0, 0, 0);
            button23.Size = new Size(174, 30);
            button23.TabIndex = 0;
            button23.Text = "button23";
            button23.TextAlign = ContentAlignment.MiddleLeft;
            button23.UseVisualStyleBackColor = true;
            // 
            // btnWondrous
            // 
            btnWondrous.Dock = DockStyle.Top;
            btnWondrous.Enabled = false;
            btnWondrous.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnWondrous.FlatStyle = FlatStyle.Flat;
            btnWondrous.ForeColor = Color.Gainsboro;
            btnWondrous.Location = new Point(0, 530);
            btnWondrous.Name = "btnWondrous";
            btnWondrous.Padding = new Padding(10, 0, 0, 0);
            btnWondrous.Size = new Size(174, 35);
            btnWondrous.TabIndex = 7;
            btnWondrous.Text = "Wondrous";
            btnWondrous.TextAlign = ContentAlignment.MiddleLeft;
            btnWondrous.UseVisualStyleBackColor = true;
            // 
            // pArmorSubMenu
            // 
            pArmorSubMenu.BackColor = Color.FromArgb(50, 50, 50);
            pArmorSubMenu.Controls.Add(button13);
            pArmorSubMenu.Controls.Add(button14);
            pArmorSubMenu.Controls.Add(button15);
            pArmorSubMenu.Controls.Add(button16);
            pArmorSubMenu.Controls.Add(button17);
            pArmorSubMenu.Dock = DockStyle.Top;
            pArmorSubMenu.Location = new Point(0, 380);
            pArmorSubMenu.Name = "pArmorSubMenu";
            pArmorSubMenu.Size = new Size(174, 150);
            pArmorSubMenu.TabIndex = 6;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Top;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = Color.Gainsboro;
            button13.Location = new Point(0, 120);
            button13.Name = "button13";
            button13.Padding = new Padding(35, 0, 0, 0);
            button13.Size = new Size(174, 30);
            button13.TabIndex = 4;
            button13.Text = "button13";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Top;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.Gainsboro;
            button14.Location = new Point(0, 90);
            button14.Name = "button14";
            button14.Padding = new Padding(35, 0, 0, 0);
            button14.Size = new Size(174, 30);
            button14.TabIndex = 3;
            button14.Text = "button14";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Top;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = Color.Gainsboro;
            button15.Location = new Point(0, 60);
            button15.Name = "button15";
            button15.Padding = new Padding(35, 0, 0, 0);
            button15.Size = new Size(174, 30);
            button15.TabIndex = 2;
            button15.Text = "button15";
            button15.TextAlign = ContentAlignment.MiddleLeft;
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Top;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = Color.Gainsboro;
            button16.Location = new Point(0, 30);
            button16.Name = "button16";
            button16.Padding = new Padding(35, 0, 0, 0);
            button16.Size = new Size(174, 30);
            button16.TabIndex = 1;
            button16.Text = "button16";
            button16.TextAlign = ContentAlignment.MiddleLeft;
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Dock = DockStyle.Top;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.ForeColor = Color.Gainsboro;
            button17.Location = new Point(0, 0);
            button17.Name = "button17";
            button17.Padding = new Padding(35, 0, 0, 0);
            button17.Size = new Size(174, 30);
            button17.TabIndex = 0;
            button17.Text = "button17";
            button17.TextAlign = ContentAlignment.MiddleLeft;
            button17.UseVisualStyleBackColor = true;
            // 
            // btnArmor
            // 
            btnArmor.Dock = DockStyle.Top;
            btnArmor.Enabled = false;
            btnArmor.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnArmor.FlatStyle = FlatStyle.Flat;
            btnArmor.ForeColor = Color.Gainsboro;
            btnArmor.Location = new Point(0, 345);
            btnArmor.Name = "btnArmor";
            btnArmor.Padding = new Padding(10, 0, 0, 0);
            btnArmor.Size = new Size(174, 35);
            btnArmor.TabIndex = 5;
            btnArmor.Text = "Armor";
            btnArmor.TextAlign = ContentAlignment.MiddleLeft;
            btnArmor.UseVisualStyleBackColor = true;
            // 
            // pWeaponsSubMenu
            // 
            pWeaponsSubMenu.BackColor = Color.FromArgb(50, 50, 50);
            pWeaponsSubMenu.Controls.Add(button7);
            pWeaponsSubMenu.Controls.Add(button8);
            pWeaponsSubMenu.Controls.Add(button9);
            pWeaponsSubMenu.Controls.Add(button10);
            pWeaponsSubMenu.Controls.Add(button11);
            pWeaponsSubMenu.Dock = DockStyle.Top;
            pWeaponsSubMenu.Location = new Point(0, 195);
            pWeaponsSubMenu.Name = "pWeaponsSubMenu";
            pWeaponsSubMenu.Size = new Size(174, 150);
            pWeaponsSubMenu.TabIndex = 4;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Gainsboro;
            button7.Location = new Point(0, 120);
            button7.Name = "button7";
            button7.Padding = new Padding(35, 0, 0, 0);
            button7.Size = new Size(174, 30);
            button7.TabIndex = 4;
            button7.Text = "button7";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Gainsboro;
            button8.Location = new Point(0, 90);
            button8.Name = "button8";
            button8.Padding = new Padding(35, 0, 0, 0);
            button8.Size = new Size(174, 30);
            button8.TabIndex = 3;
            button8.Text = "button8";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.Gainsboro;
            button9.Location = new Point(0, 60);
            button9.Name = "button9";
            button9.Padding = new Padding(35, 0, 0, 0);
            button9.Size = new Size(174, 30);
            button9.TabIndex = 2;
            button9.Text = "button9";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.Gainsboro;
            button10.Location = new Point(0, 30);
            button10.Name = "button10";
            button10.Padding = new Padding(35, 0, 0, 0);
            button10.Size = new Size(174, 30);
            button10.TabIndex = 1;
            button10.Text = "button10";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Top;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = Color.Gainsboro;
            button11.Location = new Point(0, 0);
            button11.Name = "button11";
            button11.Padding = new Padding(35, 0, 0, 0);
            button11.Size = new Size(174, 30);
            button11.TabIndex = 0;
            button11.Text = "button11";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = true;
            // 
            // btnWeapons
            // 
            btnWeapons.Dock = DockStyle.Top;
            btnWeapons.Enabled = false;
            btnWeapons.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnWeapons.FlatStyle = FlatStyle.Flat;
            btnWeapons.ForeColor = Color.Gainsboro;
            btnWeapons.Location = new Point(0, 160);
            btnWeapons.Name = "btnWeapons";
            btnWeapons.Padding = new Padding(10, 0, 0, 0);
            btnWeapons.Size = new Size(174, 35);
            btnWeapons.TabIndex = 3;
            btnWeapons.Text = "Weapons";
            btnWeapons.TextAlign = ContentAlignment.MiddleLeft;
            btnWeapons.UseVisualStyleBackColor = true;
            // 
            // pRubrikSubMenu
            // 
            pRubrikSubMenu.BackColor = Color.FromArgb(50, 50, 50);
            pRubrikSubMenu.Controls.Add(cbSummoning);
            pRubrikSubMenu.Controls.Add(cbConsumable);
            pRubrikSubMenu.Controls.Add(cbNoncombat);
            pRubrikSubMenu.Controls.Add(cbCombat);
            pRubrikSubMenu.Controls.Add(cbRubrikAll);
            pRubrikSubMenu.Dock = DockStyle.Top;
            pRubrikSubMenu.Location = new Point(0, 35);
            pRubrikSubMenu.Name = "pRubrikSubMenu";
            pRubrikSubMenu.Size = new Size(174, 125);
            pRubrikSubMenu.TabIndex = 2;
            // 
            // cbSummoning
            // 
            cbSummoning.AutoSize = true;
            cbSummoning.Checked = true;
            cbSummoning.CheckState = CheckState.Checked;
            cbSummoning.Dock = DockStyle.Top;
            cbSummoning.ForeColor = Color.Gainsboro;
            cbSummoning.Location = new Point(0, 100);
            cbSummoning.Name = "cbSummoning";
            cbSummoning.Padding = new Padding(30, 0, 0, 0);
            cbSummoning.Size = new Size(174, 25);
            cbSummoning.TabIndex = 5;
            cbSummoning.Text = "Summoning";
            cbSummoning.UseVisualStyleBackColor = true;
            cbSummoning.CheckedChanged += cbsRubrik_CheckstateChanged;
            // 
            // cbConsumable
            // 
            cbConsumable.AutoSize = true;
            cbConsumable.Checked = true;
            cbConsumable.CheckState = CheckState.Checked;
            cbConsumable.Dock = DockStyle.Top;
            cbConsumable.ForeColor = Color.Gainsboro;
            cbConsumable.Location = new Point(0, 75);
            cbConsumable.Name = "cbConsumable";
            cbConsumable.Padding = new Padding(30, 0, 0, 0);
            cbConsumable.Size = new Size(174, 25);
            cbConsumable.TabIndex = 4;
            cbConsumable.Text = "Consumable";
            cbConsumable.UseVisualStyleBackColor = true;
            cbConsumable.CheckedChanged += cbsRubrik_CheckstateChanged;
            // 
            // cbNoncombat
            // 
            cbNoncombat.AutoSize = true;
            cbNoncombat.Checked = true;
            cbNoncombat.CheckState = CheckState.Checked;
            cbNoncombat.Dock = DockStyle.Top;
            cbNoncombat.ForeColor = Color.Gainsboro;
            cbNoncombat.Location = new Point(0, 50);
            cbNoncombat.Name = "cbNoncombat";
            cbNoncombat.Padding = new Padding(30, 0, 0, 0);
            cbNoncombat.Size = new Size(174, 25);
            cbNoncombat.TabIndex = 3;
            cbNoncombat.Text = "Noncombat";
            cbNoncombat.UseVisualStyleBackColor = true;
            cbNoncombat.CheckedChanged += cbsRubrik_CheckstateChanged;
            // 
            // cbCombat
            // 
            cbCombat.AutoSize = true;
            cbCombat.Checked = true;
            cbCombat.CheckState = CheckState.Checked;
            cbCombat.Dock = DockStyle.Top;
            cbCombat.ForeColor = Color.Gainsboro;
            cbCombat.Location = new Point(0, 25);
            cbCombat.Name = "cbCombat";
            cbCombat.Padding = new Padding(30, 0, 0, 0);
            cbCombat.Size = new Size(174, 25);
            cbCombat.TabIndex = 2;
            cbCombat.Text = "Combat";
            cbCombat.UseVisualStyleBackColor = true;
            cbCombat.CheckedChanged += cbsRubrik_CheckstateChanged;
            // 
            // cbRubrikAll
            // 
            cbRubrikAll.AutoSize = true;
            cbRubrikAll.Checked = true;
            cbRubrikAll.CheckState = CheckState.Checked;
            cbRubrikAll.Dock = DockStyle.Top;
            cbRubrikAll.ForeColor = Color.Gainsboro;
            cbRubrikAll.Location = new Point(0, 0);
            cbRubrikAll.Name = "cbRubrikAll";
            cbRubrikAll.Padding = new Padding(30, 0, 0, 0);
            cbRubrikAll.Size = new Size(174, 25);
            cbRubrikAll.TabIndex = 1;
            cbRubrikAll.Text = "All";
            cbRubrikAll.UseVisualStyleBackColor = true;
            cbRubrikAll.CheckStateChanged += cbRubrikAll_CheckStateChanged;
            // 
            // btnRubrik
            // 
            btnRubrik.Dock = DockStyle.Top;
            btnRubrik.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnRubrik.FlatStyle = FlatStyle.Flat;
            btnRubrik.ForeColor = Color.Gainsboro;
            btnRubrik.Location = new Point(0, 0);
            btnRubrik.Name = "btnRubrik";
            btnRubrik.Padding = new Padding(10, 0, 0, 0);
            btnRubrik.Size = new Size(174, 35);
            btnRubrik.TabIndex = 1;
            btnRubrik.Text = "Rubrik";
            btnRubrik.TextAlign = ContentAlignment.MiddleLeft;
            btnRubrik.UseVisualStyleBackColor = true;
            btnRubrik.Click += btnRubrik_Click;
            // 
            // pRightBorder
            // 
            pRightBorder.BackColor = Color.FromArgb(255, 255, 128);
            pRightBorder.Dock = DockStyle.Right;
            pRightBorder.Location = new Point(174, 0);
            pRightBorder.Name = "pRightBorder";
            pRightBorder.Size = new Size(1, 931);
            pRightBorder.TabIndex = 10;
            // 
            // pGrid
            // 
            pGrid.Controls.Add(dgvResult);
            pGrid.Dock = DockStyle.Fill;
            pGrid.Location = new Point(196, 0);
            pGrid.Name = "pGrid";
            pGrid.Size = new Size(754, 845);
            pGrid.TabIndex = 2;
            // 
            // dgvResult
            // 
            dgvResult.AllowUserToAddRows = false;
            dgvResult.AllowUserToDeleteRows = false;
            dgvResult.AllowUserToResizeRows = false;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvResult.DefaultCellStyle = dataGridViewCellStyle1;
            dgvResult.Dock = DockStyle.Fill;
            dgvResult.Location = new Point(0, 0);
            dgvResult.Name = "dgvResult";
            dgvResult.ReadOnly = true;
            dgvResult.RowHeadersVisible = false;
            dgvResult.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvResult.RowTemplate.Height = 29;
            dgvResult.Size = new Size(754, 845);
            dgvResult.TabIndex = 0;
            // 
            // MagicItemsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 41, 51);
            ClientSize = new Size(950, 845);
            Controls.Add(pGrid);
            Controls.Add(pMiMenu);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 600);
            Name = "MagicItemsForm";
            Text = "MagicItemsForm";
            Load += MagicItemsForm_Load;
            pMiMenu.ResumeLayout(false);
            pMax.ResumeLayout(false);
            pMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMax).EndInit();
            pMin.ResumeLayout(false);
            pMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            pWondrousSubMenu.ResumeLayout(false);
            pArmorSubMenu.ResumeLayout(false);
            pWeaponsSubMenu.ResumeLayout(false);
            pRubrikSubMenu.ResumeLayout(false);
            pRubrikSubMenu.PerformLayout();
            pGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pMiMenu;
        private Panel pWondrousSubMenu;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button btnWondrous;
        private Panel pArmorSubMenu;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button btnArmor;
        private Panel pWeaponsSubMenu;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button btnWeapons;
        private Panel pRubrikSubMenu;
        private Button btnRubrik;
        private Panel pGrid;
        private DataGridView dgvResult;
        private Button btnLoot;
        private Button btnMassloot;
        private Panel pMax;
        private Label lMax;
        private NumericUpDown numMax;
        private Panel pMin;
        private Label lMinimum;
        private NumericUpDown numMin;
        private Panel panel1;
        private CheckBox cbSummoning;
        private CheckBox cbConsumable;
        private CheckBox cbNoncombat;
        private CheckBox cbCombat;
        private CheckBox cbRubrikAll;
        private Panel pRightBorder;
    }
}