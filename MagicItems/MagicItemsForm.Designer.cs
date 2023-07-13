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
            btnMassloot = new Button();
            btnLoot = new Button();
            numSum = new NumericUpDown();
            pSum = new Panel();
            lSum = new Label();
            numMax = new NumericUpDown();
            pMax = new Panel();
            lMax = new Label();
            numMin = new NumericUpDown();
            pMin = new Panel();
            lMinimum = new Label();
            panel1 = new Panel();
            pWondrousSubMenu = new Panel();
            cbMisc = new CheckBox();
            cbLiterature = new CheckBox();
            cbRod = new CheckBox();
            cbWand = new CheckBox();
            cbInstrument = new CheckBox();
            cbAccessorie = new CheckBox();
            cbClothing = new CheckBox();
            cbAlchemy = new CheckBox();
            cbWondrousAll = new CheckBox();
            btnWondrous = new Button();
            pArmorSubMenu = new Panel();
            cbShield = new CheckBox();
            cbHeavy = new CheckBox();
            cbMedium = new CheckBox();
            cbLight = new CheckBox();
            cbArmorAll = new CheckBox();
            btnArmor = new Button();
            pWeaponsSubMenu = new Panel();
            cbVersatile = new CheckBox();
            cbThrown = new CheckBox();
            cbTwoHanded = new CheckBox();
            cbSpecial = new CheckBox();
            cbReach = new CheckBox();
            cbLoading = new CheckBox();
            cbWLight = new CheckBox();
            cbWHeavy = new CheckBox();
            cbFinesse = new CheckBox();
            cbAmmunition = new CheckBox();
            cbRanged = new CheckBox();
            cbMelee = new CheckBox();
            cbMartial = new CheckBox();
            cbSimple = new CheckBox();
            cbWeaponAll = new CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)numSum).BeginInit();
            pSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMax).BeginInit();
            pMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            pMin.SuspendLayout();
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
            pMiMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pMiMenu.BackColor = Color.FromArgb(44, 41, 51);
            pMiMenu.Controls.Add(btnMassloot);
            pMiMenu.Controls.Add(btnLoot);
            pMiMenu.Controls.Add(numSum);
            pMiMenu.Controls.Add(pSum);
            pMiMenu.Controls.Add(numMax);
            pMiMenu.Controls.Add(pMax);
            pMiMenu.Controls.Add(numMin);
            pMiMenu.Controls.Add(pMin);
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
            pMiMenu.Margin = new Padding(0);
            pMiMenu.Name = "pMiMenu";
            pMiMenu.Size = new Size(196, 600);
            pMiMenu.TabIndex = 1;
            // 
            // btnMassloot
            // 
            btnMassloot.Dock = DockStyle.Top;
            btnMassloot.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnMassloot.FlatStyle = FlatStyle.Flat;
            btnMassloot.ForeColor = Color.Gainsboro;
            btnMassloot.Location = new Point(0, 1239);
            btnMassloot.Name = "btnMassloot";
            btnMassloot.Padding = new Padding(10, 0, 0, 0);
            btnMassloot.Size = new Size(173, 35);
            btnMassloot.TabIndex = 14;
            btnMassloot.Text = "Massloot";
            btnMassloot.TextAlign = ContentAlignment.MiddleLeft;
            btnMassloot.UseVisualStyleBackColor = true;
            btnMassloot.Click += btnMassloot_Click;
            // 
            // btnLoot
            // 
            btnLoot.Dock = DockStyle.Top;
            btnLoot.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnLoot.FlatStyle = FlatStyle.Flat;
            btnLoot.ForeColor = Color.Gainsboro;
            btnLoot.Location = new Point(0, 1204);
            btnLoot.Name = "btnLoot";
            btnLoot.Padding = new Padding(10, 0, 0, 0);
            btnLoot.Size = new Size(173, 35);
            btnLoot.TabIndex = 15;
            btnLoot.Text = "Loot";
            btnLoot.TextAlign = ContentAlignment.MiddleLeft;
            btnLoot.UseVisualStyleBackColor = true;
            btnLoot.Click += btnLoot_Click;
            // 
            // numSum
            // 
            numSum.Dock = DockStyle.Top;
            numSum.Location = new Point(0, 1176);
            numSum.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numSum.Name = "numSum";
            numSum.Size = new Size(173, 28);
            numSum.TabIndex = 16;
            numSum.TextAlign = HorizontalAlignment.Right;
            // 
            // pSum
            // 
            pSum.Controls.Add(lSum);
            pSum.Dock = DockStyle.Top;
            pSum.Location = new Point(0, 1141);
            pSum.Name = "pSum";
            pSum.Size = new Size(173, 35);
            pSum.TabIndex = 17;
            // 
            // lSum
            // 
            lSum.AutoSize = true;
            lSum.ForeColor = Color.Gainsboro;
            lSum.Location = new Point(3, 7);
            lSum.Name = "lSum";
            lSum.Size = new Size(115, 21);
            lSum.TabIndex = 0;
            lSum.Text = "Gesamtpreis";
            lSum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numMax
            // 
            numMax.Dock = DockStyle.Top;
            numMax.Location = new Point(0, 1113);
            numMax.Name = "numMax";
            numMax.Size = new Size(173, 28);
            numMax.TabIndex = 12;
            numMax.TextAlign = HorizontalAlignment.Right;
            numMax.ValueChanged += numMax_ValueChanged;
            // 
            // pMax
            // 
            pMax.Controls.Add(lMax);
            pMax.Dock = DockStyle.Top;
            pMax.Location = new Point(0, 1078);
            pMax.Name = "pMax";
            pMax.Size = new Size(173, 35);
            pMax.TabIndex = 13;
            // 
            // lMax
            // 
            lMax.AutoSize = true;
            lMax.ForeColor = Color.Gainsboro;
            lMax.Location = new Point(3, 7);
            lMax.Name = "lMax";
            lMax.Size = new Size(135, 21);
            lMax.TabIndex = 0;
            lMax.Text = "maximaler Preis";
            lMax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numMin
            // 
            numMin.Dock = DockStyle.Top;
            numMin.Location = new Point(0, 1050);
            numMin.Name = "numMin";
            numMin.Size = new Size(173, 28);
            numMin.TabIndex = 10;
            numMin.TextAlign = HorizontalAlignment.Right;
            numMin.ValueChanged += numMin_ValueChanged;
            // 
            // pMin
            // 
            pMin.Controls.Add(lMinimum);
            pMin.Dock = DockStyle.Top;
            pMin.Location = new Point(0, 1015);
            pMin.Name = "pMin";
            pMin.Size = new Size(173, 35);
            pMin.TabIndex = 11;
            // 
            // lMinimum
            // 
            lMinimum.AutoSize = true;
            lMinimum.ForeColor = Color.Gainsboro;
            lMinimum.Location = new Point(3, 7);
            lMinimum.Name = "lMinimum";
            lMinimum.Size = new Size(128, 21);
            lMinimum.TabIndex = 0;
            lMinimum.Text = "minimaler Preis";
            lMinimum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 997);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 18);
            panel1.TabIndex = 14;
            // 
            // pWondrousSubMenu
            // 
            pWondrousSubMenu.BackColor = Color.FromArgb(50, 50, 50);
            pWondrousSubMenu.Controls.Add(cbMisc);
            pWondrousSubMenu.Controls.Add(cbLiterature);
            pWondrousSubMenu.Controls.Add(cbRod);
            pWondrousSubMenu.Controls.Add(cbWand);
            pWondrousSubMenu.Controls.Add(cbInstrument);
            pWondrousSubMenu.Controls.Add(cbAccessorie);
            pWondrousSubMenu.Controls.Add(cbClothing);
            pWondrousSubMenu.Controls.Add(cbAlchemy);
            pWondrousSubMenu.Controls.Add(cbWondrousAll);
            pWondrousSubMenu.Dock = DockStyle.Top;
            pWondrousSubMenu.Location = new Point(0, 772);
            pWondrousSubMenu.Name = "pWondrousSubMenu";
            pWondrousSubMenu.Size = new Size(173, 225);
            pWondrousSubMenu.TabIndex = 8;
            // 
            // cbMisc
            // 
            cbMisc.AutoSize = true;
            cbMisc.Checked = true;
            cbMisc.CheckState = CheckState.Checked;
            cbMisc.Dock = DockStyle.Top;
            cbMisc.ForeColor = Color.Gainsboro;
            cbMisc.Location = new Point(0, 200);
            cbMisc.Name = "cbMisc";
            cbMisc.Padding = new Padding(30, 0, 0, 0);
            cbMisc.Size = new Size(173, 25);
            cbMisc.TabIndex = 17;
            cbMisc.Text = "Misc";
            cbMisc.UseVisualStyleBackColor = true;
            cbMisc.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbLiterature
            // 
            cbLiterature.AutoSize = true;
            cbLiterature.Checked = true;
            cbLiterature.CheckState = CheckState.Checked;
            cbLiterature.Dock = DockStyle.Top;
            cbLiterature.ForeColor = Color.Gainsboro;
            cbLiterature.Location = new Point(0, 175);
            cbLiterature.Name = "cbLiterature";
            cbLiterature.Padding = new Padding(30, 0, 0, 0);
            cbLiterature.Size = new Size(173, 25);
            cbLiterature.TabIndex = 16;
            cbLiterature.Text = "Literature";
            cbLiterature.UseVisualStyleBackColor = true;
            cbLiterature.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbRod
            // 
            cbRod.AutoSize = true;
            cbRod.Checked = true;
            cbRod.CheckState = CheckState.Checked;
            cbRod.Dock = DockStyle.Top;
            cbRod.ForeColor = Color.Gainsboro;
            cbRod.Location = new Point(0, 150);
            cbRod.Name = "cbRod";
            cbRod.Padding = new Padding(30, 0, 0, 0);
            cbRod.Size = new Size(173, 25);
            cbRod.TabIndex = 15;
            cbRod.Text = "Rod";
            cbRod.UseVisualStyleBackColor = true;
            cbRod.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbWand
            // 
            cbWand.AutoSize = true;
            cbWand.Checked = true;
            cbWand.CheckState = CheckState.Checked;
            cbWand.Dock = DockStyle.Top;
            cbWand.ForeColor = Color.Gainsboro;
            cbWand.Location = new Point(0, 125);
            cbWand.Name = "cbWand";
            cbWand.Padding = new Padding(30, 0, 0, 0);
            cbWand.Size = new Size(173, 25);
            cbWand.TabIndex = 14;
            cbWand.Text = "Wand";
            cbWand.UseVisualStyleBackColor = true;
            cbWand.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbInstrument
            // 
            cbInstrument.AutoSize = true;
            cbInstrument.Checked = true;
            cbInstrument.CheckState = CheckState.Checked;
            cbInstrument.Dock = DockStyle.Top;
            cbInstrument.ForeColor = Color.Gainsboro;
            cbInstrument.Location = new Point(0, 100);
            cbInstrument.Name = "cbInstrument";
            cbInstrument.Padding = new Padding(30, 0, 0, 0);
            cbInstrument.Size = new Size(173, 25);
            cbInstrument.TabIndex = 13;
            cbInstrument.Text = "Instrument";
            cbInstrument.UseVisualStyleBackColor = true;
            cbInstrument.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbAccessorie
            // 
            cbAccessorie.AutoSize = true;
            cbAccessorie.Checked = true;
            cbAccessorie.CheckState = CheckState.Checked;
            cbAccessorie.Dock = DockStyle.Top;
            cbAccessorie.ForeColor = Color.Gainsboro;
            cbAccessorie.Location = new Point(0, 75);
            cbAccessorie.Name = "cbAccessorie";
            cbAccessorie.Padding = new Padding(30, 0, 0, 0);
            cbAccessorie.Size = new Size(173, 25);
            cbAccessorie.TabIndex = 12;
            cbAccessorie.Text = "Accessorie";
            cbAccessorie.UseVisualStyleBackColor = true;
            cbAccessorie.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbClothing
            // 
            cbClothing.AutoSize = true;
            cbClothing.Checked = true;
            cbClothing.CheckState = CheckState.Checked;
            cbClothing.Dock = DockStyle.Top;
            cbClothing.ForeColor = Color.Gainsboro;
            cbClothing.Location = new Point(0, 50);
            cbClothing.Name = "cbClothing";
            cbClothing.Padding = new Padding(30, 0, 0, 0);
            cbClothing.Size = new Size(173, 25);
            cbClothing.TabIndex = 11;
            cbClothing.Text = "Clothing";
            cbClothing.UseVisualStyleBackColor = true;
            cbClothing.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbAlchemy
            // 
            cbAlchemy.AutoSize = true;
            cbAlchemy.Checked = true;
            cbAlchemy.CheckState = CheckState.Checked;
            cbAlchemy.Dock = DockStyle.Top;
            cbAlchemy.ForeColor = Color.Gainsboro;
            cbAlchemy.Location = new Point(0, 25);
            cbAlchemy.Name = "cbAlchemy";
            cbAlchemy.Padding = new Padding(30, 0, 0, 0);
            cbAlchemy.Size = new Size(173, 25);
            cbAlchemy.TabIndex = 10;
            cbAlchemy.Text = "Alchemy";
            cbAlchemy.UseVisualStyleBackColor = true;
            cbAlchemy.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbWondrousAll
            // 
            cbWondrousAll.AutoSize = true;
            cbWondrousAll.Checked = true;
            cbWondrousAll.CheckState = CheckState.Checked;
            cbWondrousAll.Dock = DockStyle.Top;
            cbWondrousAll.ForeColor = Color.Gainsboro;
            cbWondrousAll.Location = new Point(0, 0);
            cbWondrousAll.Name = "cbWondrousAll";
            cbWondrousAll.Padding = new Padding(30, 0, 0, 0);
            cbWondrousAll.Size = new Size(173, 25);
            cbWondrousAll.TabIndex = 9;
            cbWondrousAll.Text = "All";
            cbWondrousAll.UseVisualStyleBackColor = true;
            cbWondrousAll.CheckStateChanged += AllCBCheckedStateChanged;
            // 
            // btnWondrous
            // 
            btnWondrous.Dock = DockStyle.Top;
            btnWondrous.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnWondrous.FlatStyle = FlatStyle.Flat;
            btnWondrous.ForeColor = Color.Gainsboro;
            btnWondrous.Location = new Point(0, 737);
            btnWondrous.Name = "btnWondrous";
            btnWondrous.Padding = new Padding(10, 0, 0, 0);
            btnWondrous.Size = new Size(173, 35);
            btnWondrous.TabIndex = 7;
            btnWondrous.Text = "Wondrous";
            btnWondrous.TextAlign = ContentAlignment.MiddleLeft;
            btnWondrous.UseVisualStyleBackColor = true;
            btnWondrous.Click += btnWondrous_Click;
            // 
            // pArmorSubMenu
            // 
            pArmorSubMenu.BackColor = Color.FromArgb(50, 50, 50);
            pArmorSubMenu.Controls.Add(cbShield);
            pArmorSubMenu.Controls.Add(cbHeavy);
            pArmorSubMenu.Controls.Add(cbMedium);
            pArmorSubMenu.Controls.Add(cbLight);
            pArmorSubMenu.Controls.Add(cbArmorAll);
            pArmorSubMenu.Dock = DockStyle.Top;
            pArmorSubMenu.Location = new Point(0, 607);
            pArmorSubMenu.Name = "pArmorSubMenu";
            pArmorSubMenu.Size = new Size(173, 130);
            pArmorSubMenu.TabIndex = 6;
            // 
            // cbShield
            // 
            cbShield.AutoSize = true;
            cbShield.Checked = true;
            cbShield.CheckState = CheckState.Checked;
            cbShield.Dock = DockStyle.Top;
            cbShield.ForeColor = Color.Gainsboro;
            cbShield.Location = new Point(0, 100);
            cbShield.Name = "cbShield";
            cbShield.Padding = new Padding(30, 0, 0, 0);
            cbShield.Size = new Size(173, 25);
            cbShield.TabIndex = 8;
            cbShield.Text = "shield";
            cbShield.UseVisualStyleBackColor = true;
            cbShield.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbHeavy
            // 
            cbHeavy.AutoSize = true;
            cbHeavy.Checked = true;
            cbHeavy.CheckState = CheckState.Checked;
            cbHeavy.Dock = DockStyle.Top;
            cbHeavy.ForeColor = Color.Gainsboro;
            cbHeavy.Location = new Point(0, 75);
            cbHeavy.Name = "cbHeavy";
            cbHeavy.Padding = new Padding(30, 0, 0, 0);
            cbHeavy.Size = new Size(173, 25);
            cbHeavy.TabIndex = 7;
            cbHeavy.Text = "Heavy";
            cbHeavy.UseVisualStyleBackColor = true;
            cbHeavy.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbMedium
            // 
            cbMedium.AutoSize = true;
            cbMedium.Checked = true;
            cbMedium.CheckState = CheckState.Checked;
            cbMedium.Dock = DockStyle.Top;
            cbMedium.ForeColor = Color.Gainsboro;
            cbMedium.Location = new Point(0, 50);
            cbMedium.Name = "cbMedium";
            cbMedium.Padding = new Padding(30, 0, 0, 0);
            cbMedium.Size = new Size(173, 25);
            cbMedium.TabIndex = 6;
            cbMedium.Text = "Medium";
            cbMedium.UseVisualStyleBackColor = true;
            cbMedium.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbLight
            // 
            cbLight.AutoSize = true;
            cbLight.Checked = true;
            cbLight.CheckState = CheckState.Checked;
            cbLight.Dock = DockStyle.Top;
            cbLight.ForeColor = Color.Gainsboro;
            cbLight.Location = new Point(0, 25);
            cbLight.Name = "cbLight";
            cbLight.Padding = new Padding(30, 0, 0, 0);
            cbLight.Size = new Size(173, 25);
            cbLight.TabIndex = 5;
            cbLight.Text = "Light";
            cbLight.UseVisualStyleBackColor = true;
            cbLight.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbArmorAll
            // 
            cbArmorAll.AutoSize = true;
            cbArmorAll.Checked = true;
            cbArmorAll.CheckState = CheckState.Checked;
            cbArmorAll.Dock = DockStyle.Top;
            cbArmorAll.ForeColor = Color.Gainsboro;
            cbArmorAll.Location = new Point(0, 0);
            cbArmorAll.Name = "cbArmorAll";
            cbArmorAll.Padding = new Padding(30, 0, 0, 0);
            cbArmorAll.Size = new Size(173, 25);
            cbArmorAll.TabIndex = 4;
            cbArmorAll.Text = "All";
            cbArmorAll.UseVisualStyleBackColor = true;
            cbArmorAll.CheckStateChanged += AllCBCheckedStateChanged;
            // 
            // btnArmor
            // 
            btnArmor.Dock = DockStyle.Top;
            btnArmor.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnArmor.FlatStyle = FlatStyle.Flat;
            btnArmor.ForeColor = Color.Gainsboro;
            btnArmor.Location = new Point(0, 572);
            btnArmor.Name = "btnArmor";
            btnArmor.Padding = new Padding(10, 0, 0, 0);
            btnArmor.Size = new Size(173, 35);
            btnArmor.TabIndex = 5;
            btnArmor.Text = "Armor";
            btnArmor.TextAlign = ContentAlignment.MiddleLeft;
            btnArmor.UseVisualStyleBackColor = true;
            btnArmor.Click += btnArmor_Click;
            // 
            // pWeaponsSubMenu
            // 
            pWeaponsSubMenu.BackColor = Color.FromArgb(50, 50, 50);
            pWeaponsSubMenu.Controls.Add(cbVersatile);
            pWeaponsSubMenu.Controls.Add(cbThrown);
            pWeaponsSubMenu.Controls.Add(cbTwoHanded);
            pWeaponsSubMenu.Controls.Add(cbSpecial);
            pWeaponsSubMenu.Controls.Add(cbReach);
            pWeaponsSubMenu.Controls.Add(cbLoading);
            pWeaponsSubMenu.Controls.Add(cbWLight);
            pWeaponsSubMenu.Controls.Add(cbWHeavy);
            pWeaponsSubMenu.Controls.Add(cbFinesse);
            pWeaponsSubMenu.Controls.Add(cbAmmunition);
            pWeaponsSubMenu.Controls.Add(cbRanged);
            pWeaponsSubMenu.Controls.Add(cbMelee);
            pWeaponsSubMenu.Controls.Add(cbMartial);
            pWeaponsSubMenu.Controls.Add(cbSimple);
            pWeaponsSubMenu.Controls.Add(cbWeaponAll);
            pWeaponsSubMenu.Dock = DockStyle.Top;
            pWeaponsSubMenu.Location = new Point(0, 195);
            pWeaponsSubMenu.Name = "pWeaponsSubMenu";
            pWeaponsSubMenu.Size = new Size(173, 377);
            pWeaponsSubMenu.TabIndex = 4;
            // 
            // cbVersatile
            // 
            cbVersatile.AutoSize = true;
            cbVersatile.Checked = true;
            cbVersatile.CheckState = CheckState.Checked;
            cbVersatile.Dock = DockStyle.Top;
            cbVersatile.ForeColor = Color.Gainsboro;
            cbVersatile.Location = new Point(0, 350);
            cbVersatile.Name = "cbVersatile";
            cbVersatile.Padding = new Padding(30, 0, 0, 0);
            cbVersatile.Size = new Size(173, 25);
            cbVersatile.TabIndex = 30;
            cbVersatile.Text = "Versatile";
            cbVersatile.UseVisualStyleBackColor = true;
            cbVersatile.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbThrown
            // 
            cbThrown.AutoSize = true;
            cbThrown.Checked = true;
            cbThrown.CheckState = CheckState.Checked;
            cbThrown.Dock = DockStyle.Top;
            cbThrown.ForeColor = Color.Gainsboro;
            cbThrown.Location = new Point(0, 325);
            cbThrown.Name = "cbThrown";
            cbThrown.Padding = new Padding(30, 0, 0, 0);
            cbThrown.Size = new Size(173, 25);
            cbThrown.TabIndex = 29;
            cbThrown.Text = "Thrown";
            cbThrown.UseVisualStyleBackColor = true;
            cbThrown.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbTwoHanded
            // 
            cbTwoHanded.AutoSize = true;
            cbTwoHanded.Checked = true;
            cbTwoHanded.CheckState = CheckState.Checked;
            cbTwoHanded.Dock = DockStyle.Top;
            cbTwoHanded.ForeColor = Color.Gainsboro;
            cbTwoHanded.Location = new Point(0, 300);
            cbTwoHanded.Name = "cbTwoHanded";
            cbTwoHanded.Padding = new Padding(30, 0, 0, 0);
            cbTwoHanded.Size = new Size(173, 25);
            cbTwoHanded.TabIndex = 28;
            cbTwoHanded.Text = "Two-Handed";
            cbTwoHanded.UseVisualStyleBackColor = true;
            cbTwoHanded.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbSpecial
            // 
            cbSpecial.AutoSize = true;
            cbSpecial.Checked = true;
            cbSpecial.CheckState = CheckState.Checked;
            cbSpecial.Dock = DockStyle.Top;
            cbSpecial.ForeColor = Color.Gainsboro;
            cbSpecial.Location = new Point(0, 275);
            cbSpecial.Name = "cbSpecial";
            cbSpecial.Padding = new Padding(30, 0, 0, 0);
            cbSpecial.Size = new Size(173, 25);
            cbSpecial.TabIndex = 27;
            cbSpecial.Text = "Special";
            cbSpecial.UseVisualStyleBackColor = true;
            cbSpecial.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbReach
            // 
            cbReach.AutoSize = true;
            cbReach.Checked = true;
            cbReach.CheckState = CheckState.Checked;
            cbReach.Dock = DockStyle.Top;
            cbReach.ForeColor = Color.Gainsboro;
            cbReach.Location = new Point(0, 250);
            cbReach.Name = "cbReach";
            cbReach.Padding = new Padding(30, 0, 0, 0);
            cbReach.Size = new Size(173, 25);
            cbReach.TabIndex = 26;
            cbReach.Text = "Reach";
            cbReach.UseVisualStyleBackColor = true;
            cbReach.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbLoading
            // 
            cbLoading.AutoSize = true;
            cbLoading.Checked = true;
            cbLoading.CheckState = CheckState.Checked;
            cbLoading.Dock = DockStyle.Top;
            cbLoading.ForeColor = Color.Gainsboro;
            cbLoading.Location = new Point(0, 225);
            cbLoading.Name = "cbLoading";
            cbLoading.Padding = new Padding(30, 0, 0, 0);
            cbLoading.Size = new Size(173, 25);
            cbLoading.TabIndex = 25;
            cbLoading.Text = "Loading";
            cbLoading.UseVisualStyleBackColor = true;
            cbLoading.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbWLight
            // 
            cbWLight.AutoSize = true;
            cbWLight.Checked = true;
            cbWLight.CheckState = CheckState.Checked;
            cbWLight.Dock = DockStyle.Top;
            cbWLight.ForeColor = Color.Gainsboro;
            cbWLight.Location = new Point(0, 200);
            cbWLight.Name = "cbWLight";
            cbWLight.Padding = new Padding(30, 0, 0, 0);
            cbWLight.Size = new Size(173, 25);
            cbWLight.TabIndex = 24;
            cbWLight.Text = "Light";
            cbWLight.UseVisualStyleBackColor = true;
            cbWLight.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbWHeavy
            // 
            cbWHeavy.AutoSize = true;
            cbWHeavy.Checked = true;
            cbWHeavy.CheckState = CheckState.Checked;
            cbWHeavy.Dock = DockStyle.Top;
            cbWHeavy.ForeColor = Color.Gainsboro;
            cbWHeavy.Location = new Point(0, 175);
            cbWHeavy.Name = "cbWHeavy";
            cbWHeavy.Padding = new Padding(30, 0, 0, 0);
            cbWHeavy.Size = new Size(173, 25);
            cbWHeavy.TabIndex = 23;
            cbWHeavy.Text = "Heavy";
            cbWHeavy.UseVisualStyleBackColor = true;
            cbWHeavy.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbFinesse
            // 
            cbFinesse.AutoSize = true;
            cbFinesse.Checked = true;
            cbFinesse.CheckState = CheckState.Checked;
            cbFinesse.Dock = DockStyle.Top;
            cbFinesse.ForeColor = Color.Gainsboro;
            cbFinesse.Location = new Point(0, 150);
            cbFinesse.Name = "cbFinesse";
            cbFinesse.Padding = new Padding(30, 0, 0, 0);
            cbFinesse.Size = new Size(173, 25);
            cbFinesse.TabIndex = 22;
            cbFinesse.Text = "Finesse";
            cbFinesse.UseVisualStyleBackColor = true;
            cbFinesse.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbAmmunition
            // 
            cbAmmunition.AutoSize = true;
            cbAmmunition.Checked = true;
            cbAmmunition.CheckState = CheckState.Checked;
            cbAmmunition.Dock = DockStyle.Top;
            cbAmmunition.ForeColor = Color.Gainsboro;
            cbAmmunition.Location = new Point(0, 125);
            cbAmmunition.Name = "cbAmmunition";
            cbAmmunition.Padding = new Padding(30, 0, 0, 0);
            cbAmmunition.Size = new Size(173, 25);
            cbAmmunition.TabIndex = 21;
            cbAmmunition.Text = "Ammunition";
            cbAmmunition.UseVisualStyleBackColor = true;
            cbAmmunition.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbRanged
            // 
            cbRanged.AutoSize = true;
            cbRanged.Checked = true;
            cbRanged.CheckState = CheckState.Checked;
            cbRanged.Dock = DockStyle.Top;
            cbRanged.ForeColor = Color.Gainsboro;
            cbRanged.Location = new Point(0, 100);
            cbRanged.Name = "cbRanged";
            cbRanged.Padding = new Padding(30, 0, 0, 0);
            cbRanged.Size = new Size(173, 25);
            cbRanged.TabIndex = 20;
            cbRanged.Text = "Ranged";
            cbRanged.UseVisualStyleBackColor = true;
            cbRanged.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbMelee
            // 
            cbMelee.AutoSize = true;
            cbMelee.Checked = true;
            cbMelee.CheckState = CheckState.Checked;
            cbMelee.Dock = DockStyle.Top;
            cbMelee.ForeColor = Color.Gainsboro;
            cbMelee.Location = new Point(0, 75);
            cbMelee.Name = "cbMelee";
            cbMelee.Padding = new Padding(30, 0, 0, 0);
            cbMelee.Size = new Size(173, 25);
            cbMelee.TabIndex = 19;
            cbMelee.Text = "Melee";
            cbMelee.UseVisualStyleBackColor = true;
            cbMelee.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbMartial
            // 
            cbMartial.AutoSize = true;
            cbMartial.Checked = true;
            cbMartial.CheckState = CheckState.Checked;
            cbMartial.Dock = DockStyle.Top;
            cbMartial.ForeColor = Color.Gainsboro;
            cbMartial.Location = new Point(0, 50);
            cbMartial.Name = "cbMartial";
            cbMartial.Padding = new Padding(30, 0, 0, 0);
            cbMartial.Size = new Size(173, 25);
            cbMartial.TabIndex = 18;
            cbMartial.Text = "Martial";
            cbMartial.UseVisualStyleBackColor = true;
            cbMartial.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbSimple
            // 
            cbSimple.AutoSize = true;
            cbSimple.Checked = true;
            cbSimple.CheckState = CheckState.Checked;
            cbSimple.Dock = DockStyle.Top;
            cbSimple.ForeColor = Color.Gainsboro;
            cbSimple.Location = new Point(0, 25);
            cbSimple.Name = "cbSimple";
            cbSimple.Padding = new Padding(30, 0, 0, 0);
            cbSimple.Size = new Size(173, 25);
            cbSimple.TabIndex = 3;
            cbSimple.Text = "Simple";
            cbSimple.UseVisualStyleBackColor = true;
            cbSimple.CheckedChanged += SubCBCheckedChanged;
            // 
            // cbWeaponAll
            // 
            cbWeaponAll.AutoSize = true;
            cbWeaponAll.Checked = true;
            cbWeaponAll.CheckState = CheckState.Checked;
            cbWeaponAll.Dock = DockStyle.Top;
            cbWeaponAll.ForeColor = Color.Gainsboro;
            cbWeaponAll.Location = new Point(0, 0);
            cbWeaponAll.Name = "cbWeaponAll";
            cbWeaponAll.Padding = new Padding(30, 0, 0, 0);
            cbWeaponAll.Size = new Size(173, 25);
            cbWeaponAll.TabIndex = 2;
            cbWeaponAll.Text = "All";
            cbWeaponAll.UseVisualStyleBackColor = true;
            cbWeaponAll.CheckStateChanged += AllCBCheckedStateChanged;
            // 
            // btnWeapons
            // 
            btnWeapons.Dock = DockStyle.Top;
            btnWeapons.FlatAppearance.BorderColor = Color.FromArgb(62, 120, 138);
            btnWeapons.FlatStyle = FlatStyle.Flat;
            btnWeapons.ForeColor = Color.Gainsboro;
            btnWeapons.Location = new Point(0, 160);
            btnWeapons.Name = "btnWeapons";
            btnWeapons.Padding = new Padding(10, 0, 0, 0);
            btnWeapons.Size = new Size(173, 35);
            btnWeapons.TabIndex = 3;
            btnWeapons.Text = "Weapon";
            btnWeapons.TextAlign = ContentAlignment.MiddleLeft;
            btnWeapons.UseVisualStyleBackColor = true;
            btnWeapons.Click += btnWeapons_Click;
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
            pRubrikSubMenu.Size = new Size(173, 125);
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
            cbSummoning.Size = new Size(173, 25);
            cbSummoning.TabIndex = 5;
            cbSummoning.Text = "Summoning";
            cbSummoning.UseVisualStyleBackColor = true;
            cbSummoning.CheckedChanged += SubCBCheckedChanged;
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
            cbConsumable.Size = new Size(173, 25);
            cbConsumable.TabIndex = 4;
            cbConsumable.Text = "Consumable";
            cbConsumable.UseVisualStyleBackColor = true;
            cbConsumable.CheckedChanged += SubCBCheckedChanged;
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
            cbNoncombat.Size = new Size(173, 25);
            cbNoncombat.TabIndex = 3;
            cbNoncombat.Text = "Noncombat";
            cbNoncombat.UseVisualStyleBackColor = true;
            cbNoncombat.CheckedChanged += SubCBCheckedChanged;
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
            cbCombat.Size = new Size(173, 25);
            cbCombat.TabIndex = 2;
            cbCombat.Text = "Combat";
            cbCombat.UseVisualStyleBackColor = true;
            cbCombat.CheckedChanged += SubCBCheckedChanged;
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
            cbRubrikAll.Size = new Size(173, 25);
            cbRubrikAll.TabIndex = 1;
            cbRubrikAll.Text = "All";
            cbRubrikAll.UseVisualStyleBackColor = true;
            cbRubrikAll.CheckStateChanged += AllCBCheckedStateChanged;
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
            btnRubrik.Size = new Size(173, 35);
            btnRubrik.TabIndex = 1;
            btnRubrik.Text = "Rubrik";
            btnRubrik.TextAlign = ContentAlignment.MiddleLeft;
            btnRubrik.UseVisualStyleBackColor = true;
            btnRubrik.Click += btnRubrik_Click;
            // 
            // pRightBorder
            // 
            pRightBorder.BackColor = Color.FromArgb(62, 120, 138);
            pRightBorder.Dock = DockStyle.Right;
            pRightBorder.Location = new Point(173, 0);
            pRightBorder.Margin = new Padding(0);
            pRightBorder.Name = "pRightBorder";
            pRightBorder.Size = new Size(2, 1274);
            pRightBorder.TabIndex = 10;
            // 
            // pGrid
            // 
            pGrid.Controls.Add(dgvResult);
            pGrid.Dock = DockStyle.Fill;
            pGrid.Location = new Point(196, 0);
            pGrid.Margin = new Padding(0);
            pGrid.Name = "pGrid";
            pGrid.Size = new Size(754, 600);
            pGrid.TabIndex = 2;
            // 
            // dgvResult
            // 
            dgvResult.AllowUserToAddRows = false;
            dgvResult.AllowUserToDeleteRows = false;
            dgvResult.AllowUserToResizeRows = false;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResult.BorderStyle = BorderStyle.None;
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
            dgvResult.Size = new Size(754, 600);
            dgvResult.TabIndex = 0;
            // 
            // MagicItemsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 41, 51);
            ClientSize = new Size(950, 600);
            Controls.Add(pGrid);
            Controls.Add(pMiMenu);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 600);
            Name = "MagicItemsForm";
            Text = "MagicItemsForm";
            Load += MagicItemsForm_Load;
            pMiMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSum).EndInit();
            pSum.ResumeLayout(false);
            pSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMax).EndInit();
            pMax.ResumeLayout(false);
            pMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            pMin.ResumeLayout(false);
            pMin.PerformLayout();
            pWondrousSubMenu.ResumeLayout(false);
            pWondrousSubMenu.PerformLayout();
            pArmorSubMenu.ResumeLayout(false);
            pArmorSubMenu.PerformLayout();
            pWeaponsSubMenu.ResumeLayout(false);
            pWeaponsSubMenu.PerformLayout();
            pRubrikSubMenu.ResumeLayout(false);
            pRubrikSubMenu.PerformLayout();
            pGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pMiMenu;
        private Panel pWondrousSubMenu;
        private Button btnWondrous;
        private Panel pArmorSubMenu;
        private Button btnArmor;
        private Panel pWeaponsSubMenu;
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
        private CheckBox cbSummoning;
        private CheckBox cbConsumable;
        private CheckBox cbNoncombat;
        private CheckBox cbCombat;
        private CheckBox cbRubrikAll;
        private Panel pRightBorder;
        private CheckBox cbShield;
        private CheckBox cbHeavy;
        private CheckBox cbMedium;
        private CheckBox cbLight;
        private CheckBox cbArmorAll;
        private CheckBox cbSimple;
        private CheckBox cbWeaponAll;
        private CheckBox cbInstrument;
        private CheckBox cbAccessorie;
        private CheckBox cbClothing;
        private CheckBox cbAlchemy;
        private CheckBox cbWondrousAll;
        private CheckBox cbMisc;
        private CheckBox cbLiterature;
        private CheckBox cbRod;
        private CheckBox cbWand;
        private Panel panel1;
        private CheckBox cbLoading;
        private CheckBox cbWLight;
        private CheckBox cbWHeavy;
        private CheckBox cbFinesse;
        private CheckBox cbAmmunition;
        private CheckBox cbRanged;
        private CheckBox cbMelee;
        private CheckBox cbMartial;
        private CheckBox cbVersatile;
        private CheckBox cbThrown;
        private CheckBox cbTwoHanded;
        private CheckBox cbSpecial;
        private CheckBox cbReach;
        private NumericUpDown numSum;
        private Panel pSum;
        private Label lSum;
    }
}