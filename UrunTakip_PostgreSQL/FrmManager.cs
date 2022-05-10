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
    public partial class FrmManager : Form
    {
        public FrmManager()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
        }

        public int managerID;

        sqlConnector connector = new sqlConnector();

        void getManagerInfo()
        {
            NpgsqlCommand command = new NpgsqlCommand(@"Select ""managerName"" from ""Manager"" where ""ID""=@p1",connector.myConnection());
            command.Parameters.AddWithValue("@p1", int.Parse(lblManagerID.Text));
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblManager.Text = dataReader[0].ToString();
            }
            connector.myConnection().Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmProductInfo frmProductInfo = new FrmProductInfo();
            frmProductInfo.Show();
        }

        private void FrmManager_Load(object sender, EventArgs e)
        {
            lblManagerID.Text = managerID.ToString();

            getManagerInfo();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmSaleHistory frmHistory = new FrmSaleHistory();
            frmHistory.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
