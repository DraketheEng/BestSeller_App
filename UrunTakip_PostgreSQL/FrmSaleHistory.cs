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
    public partial class FrmSaleHistory : Form
    {
        public FrmSaleHistory()
        {
            InitializeComponent();
        }

        sqlConnector connector = new sqlConnector();

        private void SaleHistory_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(@"select * from ""saleHistory""" ,connector.myConnection());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridSale.DataSource = dataSet.Tables[0];
            dataGridSale.Columns[0].Width = 38;
        }
    }
}
