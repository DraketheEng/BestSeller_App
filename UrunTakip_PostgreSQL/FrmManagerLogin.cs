using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace UrunTakip_PostgreSQL
{
    public partial class FrmManagerLogin : Form
    {
        public FrmManagerLogin()
        {
            InitializeComponent();
        }

        sqlConnector connector = new sqlConnector();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHomeScreen frmHomeScreen = new FrmHomeScreen();
            frmHomeScreen.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(@"SELECT ""ID"",""managerPassword"" FROM public.""Manager""", connector.myConnection());
                NpgsqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    FrmManager frmManager = new FrmManager();
                    frmManager.managerID = int.Parse(txtID.Text);
                    frmManager.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect User ID or Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                connector.myConnection().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("User ID or Password is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    }
}
