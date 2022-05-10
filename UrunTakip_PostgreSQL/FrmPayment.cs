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
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }

        sqlConnector connector = new sqlConnector();

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true && txtName.Text != "" && mskCVC.Text.Length == 3 && mskMonth.Text.Length == 2 && mskYear.Text.Length == 4 && mskCardNo.Text.Length == 19)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        void purchase()
        {
            NpgsqlCommand command = new NpgsqlCommand(@"Insert into ""Sale"" (""customer"", ""product"", ""Date"", ""price"", ""profit"") values (@p1,@p2,@p3,@p4, @p5)", connector.myConnection());
            command.Parameters.AddWithValue("@p1", int.Parse(lblCustomerID.Text));
            command.Parameters.AddWithValue("@p2", int.Parse(lblProductID.Text));
            command.Parameters.AddWithValue("@p3", nowDate);
            command.Parameters.AddWithValue("@p4", int.Parse(lblPrice.Text));
            command.Parameters.AddWithValue("@p5", profit);

            command.ExecuteNonQuery();
            connector.myConnection().Close();
        }

        void updateStock()
        {
            NpgsqlCommand command = new NpgsqlCommand(@"UPDATE ""Product"" SET ""productStock"" = ""productStock"" - @p2 WHERE ""productID""=@p1", connector.myConnection());
            command.Parameters.AddWithValue("@p1", int.Parse(lblProductID.Text));
            command.Parameters.AddWithValue("@p2", int.Parse(lblCount.Text));

            command.ExecuteNonQuery();
            connector.myConnection().Close();
        }

        void calculateProfit() 
        {
            NpgsqlCommand command = new NpgsqlCommand(@"Select ""productSell"",""productPurchase"", ""productSell"" - ""productPurchase"" as ""Profit"" from ""Product"" where ""productID"" = @p1", connector.myConnection());
            command.Parameters.AddWithValue("@p1", int.Parse(lblProductID.Text));
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblProfit.Text = dataReader[2].ToString();
            }

            connector.myConnection().Close();
        }

        public int finalPrice, customerID, productID, itemCount;
        string nowDate = DateTime.Now.ToString("dd-MMM-yyyy");

        private void mskCardNo_TextChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true && txtName.Text != "" && mskCVC.Text.Length == 3 && mskMonth.Text.Length == 2 && mskYear.Text.Length == 4 && mskCardNo.Text.Length == 19)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true && txtName.Text != "" && mskCVC.Text.Length == 3 && mskMonth.Text.Length == 2 && mskYear.Text.Length == 4 && mskCardNo.Text.Length == 19)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void mskMonth_TextChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true && txtName.Text != "" && mskCVC.Text.Length == 3 && mskMonth.Text.Length == 2 && mskYear.Text.Length == 4 && mskCardNo.Text.Length == 19)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void mskYear_TextChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true && txtName.Text != "" && mskCVC.Text.Length == 3 && mskMonth.Text.Length == 2 && mskYear.Text.Length == 4 && mskCardNo.Text.Length == 19)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void mskCVC_TextChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true && txtName.Text != "" && mskCVC.Text.Length == 3 && mskMonth.Text.Length == 2 && mskYear.Text.Length == 4 && mskCardNo.Text.Length == 19)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        int profit;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            purchase();

            updateStock();

            MessageBox.Show("Transaction complete. Thank you for being our customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            lblPrice.Text = finalPrice.ToString();
            lblCustomerID.Text = customerID.ToString();
            lblProductID.Text = productID.ToString();
            lblCount.Text = itemCount.ToString();
            calculateProfit();
            profit = int.Parse(lblProfit.Text.ToString()) * int.Parse(lblCount.Text.ToString());

            NpgsqlCommand command = new NpgsqlCommand(@"Select * FROM ""Product"" where ""productID"" = @p1" ,connector.myConnection());
            command.Parameters.AddWithValue("@p1", int.Parse(lblProductID.Text));
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblProductName.Text = dataReader[1].ToString();
                pictureBox.ImageLocation = dataReader[5].ToString();
            }
            connector.myConnection().Close();
        }
    }
}
