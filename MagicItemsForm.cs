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
using System.Windows.Forms.VisualStyles;

namespace LootGenerator
{
    public partial class MagicItemsForm : Form
    {
        //fields
        /// <summary>
        /// DataSource für die DataGridView
        /// </summary>
        private DataTable miResultTable = new DataTable("MagicItems");

        //properties

        //constructor
        public MagicItemsForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        //methods
        /// <summary>
        /// Ändert Design der Oberfläche.
        /// Klappt alle Submenus ein.
        /// </summary>
        private void CustomizeDesign()
        {
            pArmorSubMenu.Visible = false;
            pRubrikSubMenu.Visible = false;
            pWeaponsSubMenu.Visible = false;
            pWondrousSubMenu.Visible = false;
        }

        /// <summary>
        /// "Klappt" die Kategorien unter den Bereichen Rubrik, Weapon, Armor und Wondrous "ein".
        /// </summary>
        private void HideSubMenu()
        {
            if (pArmorSubMenu.Visible) { pArmorSubMenu.Visible = false; }
            if (pRubrikSubMenu.Visible) { pRubrikSubMenu.Visible = false; }
            if (pWondrousSubMenu.Visible) { pWondrousSubMenu.Visible = false; }
            if (pWeaponsSubMenu.Visible) { pWeaponsSubMenu.Visible = false; }
        }

        /// <summary>
        /// "Klappt" Submenu aus/ein und alle anderen ein
        /// </summary>
        /// <param name="subMenu">Menu das aus/eingeklappt werden soll.</param>
        private void ToggleSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        /// <summary>
        /// Bestimmt zufällig ein Item und trägt dieses in den übergebenen DataTable an erster Stelle ein.
        /// Berücksichtigt werden Kriterien, die in der Oberfläche bestimmt wurden.
        /// </summary>
        /// <param name="fillTable">DataTable in den das Item eingetragen werden soll.</param>
        /// <param name="minP">Mindestpreis des Items.</param>
        /// <param name="maxP">Maximalpreis des Items.</param>
        private void Generate_Item(DataTable fillTable, decimal minP, decimal maxP)
        {
            //füllen Stringliste um später nur in diesen Rubriken zu suchen
            var rubriks = new List<string>();
            if (cbConsumable.CheckState == CheckState.Checked)
                rubriks.Add("'Consumable'");
            if (cbCombat.CheckState == CheckState.Checked)
                rubriks.Add("'Combat'");
            if (cbNoncombat.CheckState == CheckState.Checked)
                rubriks.Add("'Noncombat'");
            if (cbSummoning.CheckState == CheckState.Checked)
                rubriks.Add("'Summoning'");

            //Anfang Select
            StringBuilder query = new StringBuilder(
                "SELECT l.Engl_Name, " +
                       "l.Price, " +
                       "l.Rubrik, " +
                       "l.Gamebreaking " +
                "FROM ( ");

            //erweitern Select um Weapons mit gewünschten Properties
            if (cbWeaponAll.CheckState != CheckState.Unchecked)
            {
                query.AppendLine(
                    "SELECT iwe.Engl_Name, " +
                           "iwe.Price, " +
                           "iwe.Rubrik, " +
                           "iwe.Gamebreaking " +
                    "FROM itemlist iwe " +
                    "JOIN weapons we on we.id = iwe.id " +
                    "WHERE 1<>1 ");
                if (cbSimple.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.simple = true ");
                if (cbMartial.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.martial = true ");
                if (cbMelee.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.melee = true ");
                if (cbRanged.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.ranged = true ");
                if (cbAmmunition.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.ammunition = true ");
                if (cbFinesse.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.finesse = true ");
                if (cbWHeavy.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.heavy = true ");
                if (cbWLight.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.light = true ");
                if (cbLoading.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.loading = true ");
                if (cbReach.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.reach = true ");
                if (cbSpecial.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.special = true ");
                if (cbTwoHanded.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.two_handed = true ");
                if (cbThrown.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.thrown = true ");
                if (cbVersatile.CheckState == CheckState.Checked)
                    query.AppendLine("OR we.versatile = true ");

                //falls noch aus Wondrous oder Armor gewählt werden soll
                if (cbArmorAll.CheckState != CheckState.Unchecked || cbWondrousAll.CheckState != CheckState.Unchecked)
                    query.AppendLine("UNION ");
            }

            //erweitern Select um Armors mit gewünschten Properties
            if (cbArmorAll.CheckState != CheckState.Unchecked)
            {
                query.AppendLine(
                    "SELECT ia.Engl_Name, " +
                           "ia.Price, " +
                           "ia.Rubrik, " +
                           "ia.Gamebreaking " +
                    "FROM itemlist ia " +
                    "JOIN armors a0 on a0.id = ia.id " +
                    "WHERE 1<>1 ");
                if (cbLight.CheckState == CheckState.Checked)
                    query.AppendLine("OR a0.light = true ");
                if (cbMedium.CheckState == CheckState.Checked)
                    query.AppendLine("OR a0.medium = true ");
                if (cbHeavy.CheckState == CheckState.Checked)
                    query.AppendLine("OR a0.heavy = true ");
                if (cbShield.CheckState == CheckState.Checked)
                    query.AppendLine("OR a0.shield = true ");

                //falls noch aus Wondrous gewählt werden soll
                if (cbWondrousAll.CheckState != CheckState.Unchecked)
                    query.AppendLine("UNION ");
            }

            //erweitern Select um Wondrous Items mit gewünschten Properties
            if (cbWondrousAll.CheckState != CheckState.Unchecked)
            {
                query.AppendLine(
                    "SELECT iw.Engl_Name, " +
                           "iw.Price, " +
                           "iw.Rubrik, " +
                           "iw.Gamebreaking " +
                    "FROM itemlist iw " +
                    "JOIN wondrous w0 on w0.id = iw.id " +
                    "WHERE 1<>1 ");
                if (cbAlchemy.CheckState == CheckState.Checked)
                    query.AppendLine("OR w0.alchemy = true ");
                if (cbClothing.CheckState == CheckState.Checked)
                    query.AppendLine("OR w0.clothing = true ");
                if (cbAccessorie.CheckState == CheckState.Checked)
                    query.AppendLine("OR w0.accessorie = true ");
                if (cbInstrument.CheckState == CheckState.Checked)
                    query.AppendLine("OR w0.instrument = true ");
                if (cbWand.CheckState == CheckState.Checked)
                    query.AppendLine("OR w0.wand = true ");
                if (cbRod.CheckState == CheckState.Checked)
                    query.AppendLine("OR w0.rod = true ");
                if (cbLiterature.CheckState == CheckState.Checked)
                    query.AppendLine("OR w0.literature = true ");
                if (cbMisc.CheckState == CheckState.Checked)
                    query.AppendLine("OR w0.misc = true ");
            }

            //schränken Select auf Preis und Rubriken ein
            //ordnen Ergebnis per Zufall und geben ersten Treffer zurück
            query.AppendLine(
                     ") l " +
                "WHERE l.Price is not NULL " +
                " AND l.Price >= " + minP +
                " AND l.Price <= " + maxP +
                " AND l.Rubrik IN (" + string.Join(", ", rubriks) + ") " +
                "ORDER BY RANDOM() " +
                "LIMIT 1 ");
            
            //nutzen Adapter um Select auszuführen und DataTable zu füllen
            SQLiteDataAdapter adapSQLite = new SQLiteDataAdapter(query.ToString(), FormMain.conSQLite);
            adapSQLite.Fill(fillTable);
        }

        /// <summary>
        /// Verdreht Reihenfolge der Zeilen in einem übergebenen DataTable.
        /// Erster wird Letzter und Letzter Erster etc.
        /// </summary>
        /// <param name="table">DataTable dessen Zeilen verdreht werden sollen.</param>
        /// <returns>DataTable mit Zeilen in umgekehrter Reihenfolge.</returns>
        private DataTable reverseTable(DataTable table)
        {
            DataTable revTable = table.Clone();
            //Durchschreiten Table in umgekehrter Reihenfolge und tragen werde in neuen Table ein
            for (int i = table.Rows.Count - 1; i >= 0; i--)
                revTable.ImportRow(table.Rows[i]);
            return revTable;
        }


        //event handler

        /// <summary>
        /// Klappt Submenu der Rubriken bei Klick ein/aus.
        /// </summary>
        private void btnRubrik_Click(object sender, EventArgs e)
        { ToggleSubMenu(pRubrikSubMenu); }
        /// <summary>
        /// Klappt Submenu der Weapon bei Klick ein/aus.
        /// </summary>
        private void btnWeapons_Click(object sender, EventArgs e)
        { ToggleSubMenu(pWeaponsSubMenu); }
        /// <summary>
        /// Klappt Submenu der Armor bei Klick ein/aus.
        /// </summary>
        private void btnArmor_Click(object sender, EventArgs e)
        { ToggleSubMenu(pArmorSubMenu); }
        /// <summary>
        /// Klappt Submenu der Wondrous bei Klick ein/aus.
        /// </summary>
        private void btnWondrous_Click(object sender, EventArgs e)
        { ToggleSubMenu(pWondrousSubMenu); }

        /// <summary>
        /// Legt beim Laden der Form den höchstmöglichen Maximalpreis der Items fest.
        /// </summary>
        private void MagicItemsForm_Load(object sender, EventArgs e)
        {
            //Select für höchsten Preis der Items
            StringBuilder query = new StringBuilder("SELECT MAX(price) FROM itemlist;");
            SQLiteDataAdapter adapSQLite = new SQLiteDataAdapter(query.ToString(), FormMain.conSQLite);
            DataTable tempTable = new DataTable("Temp_table");
            adapSQLite.Fill(tempTable);
            numMin.Maximum = Int32.Parse(tempTable.Rows[0][0].ToString());
            numMax.Maximum = numMin.Maximum;

            //leeren Stringbuilder um ihn später wiederverwenden zu können
            query.Clear();
            tempTable.Columns.Clear();
            tempTable.Clear();
        }

        /// <summary>
        /// Ändern des Maximalpreises ändert höchstmöglichen Minimalpreis.
        /// </summary>
        private void numMax_ValueChanged(object sender, EventArgs e)
        { numMin.Maximum = ((NumericUpDown)sender).Value; }

        /// <summary>
        /// Ändern des Checkstates einer Checkbox ändert den Checkstate aller anderen Checkboxes in selbem Steuerelement.
        /// Die CheckStates werden auf Checked oder Unchecked gestellt. Intermediate wird ignoriert.
        /// Dieser Eventhandler sollte nur den "All"-CheckBoxes der Submenus Rubrik, Weapons, Armor und Wondrous zugewiesen werden.
        /// </summary>
        /// <param name="sender">Checkbox deren CheckState geändert wird.</param>
        /// <param name="e">Änderung des CheckStates</param>
        private void AllCBCheckedStateChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Indeterminate) { return; }

            //schauen in Steuerelemente des ParentControls --> durchlaufen alle Steuerelemente auf selber Ebene wie sender
            foreach (CheckBox currCB in ((CheckBox)sender).Parent.Controls)
            {
                if (currCB.Text != "All")
                {
                    //entfernen Eventhandler des Steuerelements da dieser den Checkstate der "All"-CheckBox beeinflusst
                    currCB.CheckedChanged -= SubCBCheckedChanged;
                    currCB.CheckState = ((CheckBox)sender).CheckState;
                    currCB.CheckedChanged += SubCBCheckedChanged;
                }
            }
        }

        /// <summary>
        /// Ändert den CheckState der "All"-CheckBox in selbem Steuerelement.
        /// Der CheckState wird auf Checked gesetzt sollten alle anderen CheckBoxes checked sein. Das Gleiche gilt für Unchecked.
        /// Sollte eine Mischung aus checked und unchecked Boxes vorliegen wird CheckState auf Intermediate gesetzt.
        /// Dieser Eventhandler sollte nicht den "All"-CheckBoxes der Submenus Rubrik, Weapons, Armor und Wondrous zugewiesen werden, aber allen anderen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubCBCheckedChanged(object sender, EventArgs e)
        {
            //temporäre Variable um ständigem Casten vorzubeugen
            Control.ControlCollection tmpCol = ((CheckBox)sender).Parent.Controls;

            //merken uns "All"-CheckBox des entsprechenden Submenus
            CheckBox all = null;
            //CheckStates der 2 zuletzt geprüften CheckBoxes
            CheckState cb2last = CheckState.Indeterminate;
            CheckState cbLast = CheckState.Indeterminate;

            //durchlaufen Controls rückwärts, da "All"-CheckBox Letzte ist und diese erfasst werden muss
            for (int i = tmpCol.Count - 1; i > 0; i--)
            {
                if (tmpCol[i].Text != "All")
                {
                    cb2last = ((CheckBox)tmpCol[i]).CheckState;
                    cbLast = ((CheckBox)tmpCol[i - 1]).CheckState;

                    //sobald 2 CheckStates sich unterscheiden muss "All"-CheckBox auf intermediate gestellt werden
                    //--> Methode kann vorzeitig verlassen werden
                    if (((CheckBox)tmpCol[i]).CheckState != ((CheckBox)tmpCol[i - 1]).CheckState)
                    {
                        all.CheckState = CheckState.Indeterminate;
                        all.CheckStateChanged += AllCBCheckedStateChanged;  //Eventhandler wurde zuvor in dieser Methode entfernt
                        return; 
                    }
                }
                else
                {
                    //speichern Verweis auf "All"-CheckBox um diese nicht nochmal suchen zu müssen
                    all = (CheckBox)tmpCol[i];
                    //entfernen Eventhandler da dieser die CheckStates der anderen CheckBoxes beeinflusst
                    all.CheckStateChanged -= AllCBCheckedStateChanged;
                }
            }

            //Schleife wurde vollständig durchlaufen
            //--> Alle CheckBoxes haben den CheckState des Senders 
            //--> auch "All"-CheckBox erhält diesen
            all.CheckState = ((CheckBox)sender).CheckState;
            all.CheckStateChanged += AllCBCheckedStateChanged;  //Eventhandler wurde zuvor in dieser Methode entfernt
        }

        /// <summary>
        /// Bei Klick wird ein zufällig bestimmtes Item gewählt - entsprechend den bestimmten Kriterien - und in DataGridView an erster Stelle dargestellt.
        /// </summary>
        /// <param name="e">Click.</param>
        private void btnLoot_Click(object sender, EventArgs e)
        {
            Generate_Item(miResultTable, numMin.Value, numMax.Value);
            dgvResult.DataSource = reverseTable(miResultTable);
            dgvResult.Refresh();
        }

        /// <summary>
        /// Bei Klick wird eine zufällig bestimmte Itemsammlung gewählt - entsprechend den bestimmten Kriterien.
        /// Diese ersetzt alle bestehenden Einträge in DataGridView.
        /// Der Maxpreis bestimmt hier gleichzeitig den maximalen Preis jedes Items und den Gesamtwert der Itemsammlung.
        /// Bleibt ein Restbetrag wird dieser als Gold ausgegeben.
        /// </summary>
        /// <param name="e">Click.</param>
        private void btnMassloot_Click(object sender, EventArgs e)
        {
            miResultTable.Clear();

            decimal wholePrice = numMax.Value;
            int i = 0;
            int contrl = 1;

            //bestimmen einzeln zufällige Items bis Gesamtwert erreicht ist.
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
                    //Select gab keine Treffer zurück
                    //--> es gibt keine Items innerhalb gewünschter Preisspanne
                    //--> beenden Itemsuche
                    contrl = i;
                }

            }
            //offener Betrag wird in Gold umgewandelt und DataGridView hinzugefügt
            miResultTable.Rows.Add("Rest Gold", wholePrice, "Money", false);

            dgvResult.DataSource = reverseTable(miResultTable);
            dgvResult.Refresh();
        }
    }
}
