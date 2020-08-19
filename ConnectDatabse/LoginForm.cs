using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDatabse
{
    public partial class LoginForm : Form
    {
        DatabaseForm databaseForm;
        DBConnect dB;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            dB = new DBConnect(textbox_username.Text, textbox_password.Text);

            if(dB.Initialize())
            {
                databaseForm = new DatabaseForm(dB);
                this.Hide();
                databaseForm.Show();
            }
        }
    }
}
