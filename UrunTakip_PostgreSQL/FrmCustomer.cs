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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        sqlConnector connector = new sqlConnector();

        public int customerID;

        int totalCost = 0;

        void getCustomerInfo()
        {
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM public.""Customer"" where ""ID""=@p1", connector.myConnection());
            command.Parameters.AddWithValue("@p1", int.Parse(lblID.Text));
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblName.Text = dataReader[1].ToString();
                lblCity.Text = dataReader[2].ToString();
            }
            connector.myConnection().Close();
        }

        void getProductList()
        {
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT ""productID"" as ""ID"", ""productName"" as ""Product"", ""categoryName"" as ""Category"",""productSell"" as ""Price"" FROM ""productList""", connector.myConnection());
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridProduct.DataSource = dataSet.Tables[0];
            dataGridProduct.Columns[0].Width = 45;

        }

        void getComboBoxItem()
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(@"select * from ""categories""", connector.myConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryID";
            cmbCategory.DataSource = dataTable;
            connector.myConnection().Close();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            lblID.Text = customerID.ToString();

            getCustomerInfo();

            getProductList();

            getComboBoxItem();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPayment frmPayment = new FrmPayment();
                frmPayment.finalPrice = int.Parse(lblTotalCost.Text);
                frmPayment.productID = int.Parse(lblProductID.Text);
                frmPayment.customerID = int.Parse(lblID.Text);
                frmPayment.itemCount = int.Parse(numericUpDown.Value.ToString());
                frmPayment.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("No item in your cart!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedValue = dataGridProduct.SelectedCells[0].RowIndex;
                lblProductID.Visible = true;
                lblProductName.Visible = true;
                lblProductPrice.Visible = true;
                richTextBox.Visible = true;
                pictureProduct.Visible = true;
                lblDollar.Visible = true;
                lblProductID.Text = dataGridProduct.Rows[selectedValue].Cells[0].Value.ToString();
                lblProductName.Text = dataGridProduct.Rows[selectedValue].Cells[1].Value.ToString();
                lblProductPrice.Text = dataGridProduct.Rows[selectedValue].Cells[3].Value.ToString();

                NpgsqlCommand command = new NpgsqlCommand(@"Select ""Description"",""productImage"" FROM ""Product"" where ""productID""=@p1", connector.myConnection());
                command.Parameters.AddWithValue("@p1", int.Parse(lblProductID.Text));
                NpgsqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    richTextBox.Text = dataReader[0].ToString();
                    pictureProduct.ImageLocation = dataReader[1].ToString();
                }
                connector.myConnection().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("No item selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT ""productID"" as ""ID"", ""productName"" as ""Product"", ""categoryName"" as ""Category"",""productSell"" as ""Price"" FROM ""productList"" where ""categoryName""=@p1", connector.myConnection());
            command.Parameters.AddWithValue("@p1", cmbCategory.Text.ToString());
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridProduct.DataSource = dataSet.Tables[0];
            dataGridProduct.Columns[0].Width = 45;
            dataGridProduct.Columns[1].Width = 175;
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                totalCost = totalCost + int.Parse(lblProductPrice.Text) * int.Parse(numericUpDown.Value.ToString());
                lblTotalCost.Text = totalCost.ToString();
                lblCartDollar.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("No item selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCustomerPurchaseHistory purchaseHistory = new FrmCustomerPurchaseHistory();
            purchaseHistory.cutomerID = int.Parse(lblID.Text);
            purchaseHistory.Show();
        }
    }
}
