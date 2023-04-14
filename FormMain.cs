using System.Data.SQLite;

namespace LootGenerator
{
    public partial class FormMain : Form
    {
        //fields
        public static SQLiteConnection conSQLite;
        private MagicItemsForm _MagicItemsForm = new MagicItemsForm();

        //properties

        public FormMain()
        {
            InitializeComponent();

            //Verbindung zur lokalen Datenbank herstellen
            conSQLite = new SQLiteConnection("Datasource=" + System.IO.Directory.GetCurrentDirectory() + "\\Magic_Items.db");
            conSQLite.Open();

            OpenChildForm(_MagicItemsForm);
        }

        //methods
        private void OpenChildForm(Form childForm)
        {
            if (pSubWindow.Tag != null)
            {
                ((Form)pSubWindow.Tag).Hide();
                pSubWindow.Tag = null;
            }
            childForm.TopLevel = false;
            childForm.Size = pSubWindow.Size;
            childForm.Dock = DockStyle.Fill;
            pSubWindow.Controls.Add(childForm);
            pSubWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //event handler

        private void btnTabMagicItems_Click(object sender, EventArgs e)
        {
            panel1.BackColor = btnTabMagicItems.BackColor;
            OpenChildForm(_MagicItemsForm);
        }
    }
}