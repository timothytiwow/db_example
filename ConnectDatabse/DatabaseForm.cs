using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConnectDatabse
{
    public partial class DatabaseForm : Form
    {
        DBConnect dB;
        int datagrid_main_selectedrow;
        public DatabaseForm(DBConnect dB)
        {
            InitializeComponent();
            this.dB = dB;
            SetupDataGrid();
            this.datagrid_main_selectedrow = -1;
        }

        void SetupDataGrid()
        {
            this.datagrid_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_main.MultiSelect = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_refreshget_Click(object sender, EventArgs e)
        {
            this.datagrid_main.Rows.Clear();

            List<string>[] data = dB.Select();

            for (int i = 0; i < data[0].Count; i++)
            {
                this.datagrid_main.Rows.Add(new string[]{data[0][i], data[1][i]});
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            dB.Insert(textbox_name.Text, int.Parse(textbox_age.Text));

            button_refreshget_Click(null, null);
        }

        private void button_deleteselected_Click(object sender, EventArgs e)
        {
            string name = datagrid_main.Rows[this.datagrid_main_selectedrow].Cells[0].Value.ToString();
            string age = datagrid_main.Rows[this.datagrid_main_selectedrow].Cells[1].Value.ToString();

            dB.Delete(name, int.Parse(age));

            button_refreshget_Click(null, null);
        }

        private void datagrid_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.datagrid_main_selectedrow = e.RowIndex;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
