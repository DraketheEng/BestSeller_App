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
    public partial class FrmHomeScreen : Form
    {
        public FrmHomeScreen()
        {
            InitializeComponent();
        }

        private void LLManagerLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmManagerLogin frmManagerLogin = new FrmManagerLogin();
            frmManagerLogin.Show();
            this.Hide();
        }

        sqlConnector connector = new sqlConnector();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(@"SELECT * from ""Customer"" where ""ID""=@p1 and ""customerPassword""=@p2", connector.myConnection());
                command.Parameters.AddWithValue("@p1", int.Parse(txtUserName.Text));
                command.Parameters.AddWithValue("@p2", txtPassword.Text);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    FrmCustomer frmCustomer = new FrmCustomer();
                    frmCustomer.customerID = int.Parse(txtUserName.Text);
                    frmCustomer.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connector.myConnection().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Username or Password is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LLRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCustomerRegister frmCustomerRegister = new FrmCustomerRegister();
            frmCustomerRegister.Show();
            this.Hide();
        }
    }
}
