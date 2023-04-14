using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LootGenerator
{
    public partial class MagicItemsForm : Form
    {
        //fields

        private DataTable miResultTable = new DataTable("MagicItems");

        //properties

        //constructor
        public MagicItemsForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        //methods

        private void CustomizeDesign()
        {
            pArmorSubMenu.Visible = false;
            pRubrikSubMenu.Visible = false;
            pWeaponsSubMenu.Visible = false;
            pWondrousSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pArmorSubMenu.Visible) { pArmorSubMenu.Visible = false; }
            if (pRubrikSubMenu.Visible) { pRubrikSubMenu.Visible = false; }
            if (pWondrousSubMenu.Visible) { pWondrousSubMenu.Visible = false; }
            if (pWeaponsSubMenu.Visible) { pWeaponsSubMenu.Visible = false; }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Generate_Item(DataTable fillTable, decimal minP, decimal maxP)
        {
            var rubriks = new List<string>();

            if (cbConsumable.CheckState == CheckState.Checked)
                rubriks.Add("'Consumable'");
            if (cbCombat.CheckState == CheckState.Checked)
                rubriks.Add("'Combat'");
            if (cbNoncombat.CheckState == CheckState.Checked)
                rubriks.Add("'Noncombat'");
            if (cbSummoning.CheckState == CheckState.Checked)
                rubriks.Add("'Summoning'");

            StringBuilder query = new StringBuilder(
                "SELECT Engl_Name, Price, Rubrik, Gamebreaking " +
                "FROM Itemlist " +
                "WHERE Price is not NULL " +
                " AND Price >= " + minP +
                " AND Price <= " + maxP +
                " AND Rubrik in (" + string.Join(", ", rubriks) + ")" +
                " ORDER BY RANDOM() " +
                " LIMIT 1 ");

            SQLiteDataAdapter adapSQLite = new SQLiteDataAdapter(query.ToString(), FormMain.conSQLite);
            adapSQLite.Fill(fillTable);
        }

        //nötig damit neuestes Item an der Spitze von Resulttable ist
        private DataTable reverseTable(DataTable table)
        {
            DataTable revTable = table.Clone();
            for (int i = table.Rows.Count - 1; i >= 0; i--)
                revTable.ImportRow(table.Rows[i]);
            return revTable;
        }


        //event handler

        private void btnRubrik_Click(object sender, EventArgs e)
        {
            showSubMenu(pRubrikSubMenu);
        }

        private void btnWeapons_Click(object sender, EventArgs e)
        {
            showSubMenu(pWeaponsSubMenu);
        }

        private void btnArmor_Click(object sender, EventArgs e)
        {
            showSubMenu(pArmorSubMenu);
        }

        private void btnWondrous_Click(object sender, EventArgs e)
        {
            showSubMenu(pWondrousSubMenu);
        }

        private void MagicItemsForm_Load(object sender, EventArgs e)
        {
            //Minimum und Maximum für Magic Items festlegen
            StringBuilder query = new StringBuilder("SELECT MAX(price) FROM itemlist;");
            SQLiteDataAdapter adapSQLite = new SQLiteDataAdapter(query.ToString(), FormMain.conSQLite);
            DataTable tempTable = new DataTable("Temp_table");
            adapSQLite.Fill(tempTable);
            numMin.Maximum = Int32.Parse(tempTable.Rows[0][0].ToString());
            numMax.Maximum = numMin.Maximum;
            query.Clear();
            tempTable.Columns.Clear();
            tempTable.Clear();
        }

        private void numMax_ValueChanged(object sender, EventArgs e)
        {
            numMin.Maximum = ((NumericUpDown)sender).Value;
        }

        private void cbRubrikAll_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbRubrikAll.CheckState == CheckState.Indeterminate) { return; }
            cbCombat.CheckedChanged -= cbsRubrik_CheckstateChanged;
            cbNoncombat.CheckedChanged -= cbsRubrik_CheckstateChanged;
            cbConsumable.CheckedChanged -= cbsRubrik_CheckstateChanged;
            cbSummoning.CheckedChanged -= cbsRubrik_CheckstateChanged;

            cbCombat.CheckState = cbRubrikAll.CheckState;
            cbConsumable.CheckState = cbRubrikAll.CheckState;
            cbNoncombat.CheckState = cbRubrikAll.CheckState;
            cbSummoning.CheckState = cbRubrikAll.CheckState;

            cbCombat.CheckedChanged += cbsRubrik_CheckstateChanged;
            cbNoncombat.CheckedChanged += cbsRubrik_CheckstateChanged;
            cbConsumable.CheckedChanged += cbsRubrik_CheckstateChanged;
            cbSummoning.CheckedChanged += cbsRubrik_CheckstateChanged;
        }

        private void cbsRubrik_CheckstateChanged(object sender, EventArgs e)
        {
            cbRubrikAll.CheckStateChanged -= cbRubrikAll_CheckStateChanged;

            if (cbCombat.Checked && cbNoncombat.Checked && cbSummoning.Checked && cbConsumable.Checked)
            { cbRubrikAll.CheckState = CheckState.Checked; }
            else if (!cbCombat.Checked && !cbNoncombat.Checked && !cbSummoning.Checked && !cbConsumable.Checked)
            { cbRubrikAll.CheckState = CheckState.Unchecked; }
            else
            { cbRubrikAll.CheckState = CheckState.Indeterminate; }

            cbRubrikAll.CheckStateChanged += cbRubrikAll_CheckStateChanged;
        }

        private void btnLoot_Click(object sender, EventArgs e)
        {
            Generate_Item(miResultTable, numMin.Value, numMax.Value);
            dgvResult.DataSource = reverseTable(miResultTable);
            dgvResult.Refresh();
        }

        //Füllt Loottable mit einer Sammlung an Items
        //Mindestpreis der einzelnen Items und Gesamtpreis muss angegeben sein
        //Bugg vorhanden: bei minNumbB.Value = 0 findet er immer wieder das eine Item mit GoldWert 0
        private void btnMassloot_Click(object sender, EventArgs e)
        {
            miResultTable.Clear();

            decimal wholePrice = numMax.Value;
            int i = 0;
            int contrl = 1;

            while (wholePrice >= numMin.Value && contrl != i)
            {
                try
                {
                    contrl = i;
                    Generate_Item(miResultTable, numMin.Value, wholePrice);

                    wholePrice = wholePrice - decimal.Parse(miResultTable.Rows[i][1].ToString());
                    i = miResultTable.Rows.Count;
                }
                catch (Exception ex)
                {
                    contrl = i;
                }

            }
            miResultTable.Rows.Add("Rest Gold", wholePrice, "Money", false);

            dgvResult.DataSource = reverseTable(miResultTable);
            dgvResult.Refresh();
        }
    }
}
