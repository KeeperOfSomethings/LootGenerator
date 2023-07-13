using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootGenerator.MagicItems
{
    public partial class AllMagicItemsForm : Form
    {
        private DataTable itemDt = new DataTable("AllItems");
        private StringBuilder query = new StringBuilder();

        public AllMagicItemsForm()
        {
            InitializeComponent();

            query.Append("SELECT i.price, " +
                                "i.engl_name, " +
                                "i.rubrik, " +
                                "ty.type " +
                         "FROM itemlist i " +
                         "JOIN itemtype ty on i.type = ty.typeID " +
                         "ORDER BY i.engl_name, ty.type, i.rubrik, i.price");
            SQLiteDataAdapter adapSQLite = new SQLiteDataAdapter(query.ToString(), FormMain.conSQLite);
            adapSQLite.Fill(itemDt);

            dgvAllItems.DataSource = itemDt;
            dgvAllItems.Refresh();
        }
    }
}
