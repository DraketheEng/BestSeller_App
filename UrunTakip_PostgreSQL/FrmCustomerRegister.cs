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
    public partial class FrmCustomerRegister : Form
    {
        public FrmCustomerRegister()
        {
            InitializeComponent();
        }

        sqlConnector connector = new sqlConnector();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(@"Insert into ""Customer"" (""ID"", ""customerName"", ""customerCity"", ""customerPassword"", ""customerState"") values (@p1,@p2,@p3,@p4,@p5)", connector.myConnection());
                command.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));
                command.Parameters.AddWithValue("@p2", txtName.Text);
                command.Parameters.AddWithValue("@p3", cmbCity.Text);
                command.Parameters.AddWithValue("@p4", txtPassword.Text);
                command.Parameters.AddWithValue("@p5", true);

                command.ExecuteNonQuery();
                MessageBox.Show("Registration successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("No empty fields allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmHomeScreen homeScreen = new FrmHomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}
