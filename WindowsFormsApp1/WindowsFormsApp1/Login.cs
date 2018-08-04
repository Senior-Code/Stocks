using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBoxuser.Text = "";
            textBoxpassword.Clear();
            textBoxuser.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxuser;
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
  FROM [dbo].[Login] Where Username = '" + textBoxuser.Text + "' and Password = '" + textBoxpassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                StockMain main = new StockMain();
                main.Show();
            }
            else
            {
                MessageBox.Show ("Incorrect Username/Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonclear_Click(sender, e);
            }
        }

        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonlogin.PerformClick();
            }
        }
    }
}
