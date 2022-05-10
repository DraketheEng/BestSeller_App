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
    public partial class FrmCustomerPurchaseHistory : Form
    {
        public FrmCustomerPurchaseHistory()
        {
            InitializeComponent();
        }

        sqlConnector connector = new sqlConnector();

        public int cutomerID;

        private void FrmCustomerPurchaseHistory_Load(object sender, EventArgs e)
        {
            lblCustomerID.Text = cutomerID.ToString();
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT ""customer"", ""customerName"", ""productName"", ""Date"", ""price"" FROM ""Sale"" INNER JOIN ""Customer"" on ""Sale"".""customer"" = ""Customer"".""ID""
              INNER JOIN ""Product"" on ""Sale"".""product"" = ""Product"".""productID"" where ""customer"" = @p1", connector.myConnection());
            command.Parameters.AddWithValue("@p1", int.Parse(lblCustomerID.Text.ToString()));
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
           
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridPurchaseHistory.DataSource = dataSet.Tables[0];
            dataGridPurchaseHistory.Columns[0].Width = 38;
        }
    }
}
