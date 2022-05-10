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
    public partial class FrmProductInfo : Form
    {
        public FrmProductInfo()
        {
            InitializeComponent();
        }
        sqlConnector connector = new sqlConnector();

        void clear()
        {
            txtID.Text = "";
            txtProduct.Text = "";
            UpDownStock.Text = "";
            txtPurchase.Text = "";
            txtSell.Text = "";
            txtImage.Text = "";
            cmbCategory.Text = "";
            richTextBox.Text = "";
        }

        void getProductList()
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(@"select * from ""productList""",connector.myConnection());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridProduct.DataSource = dataSet.Tables[0];
            dataGridProduct.Columns[0].Width = 38;
            dataGridProduct.Columns[1].Width = 125;
            dataGridProduct.Columns[6].Width = 20;
            dataGridProduct.Columns[7].Width = 20;
        }

        private void FrmProductInfo_Load(object sender, EventArgs e)
        {
            getProductList();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(@"select * from ""categories""", connector.myConnection());
           DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryID";
            cmbCategory.DataSource = dataTable;
            connector.myConnection().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmManager frmManager = new FrmManager();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(@"Insert into ""Product"" (""productID"",""productName"",""productStock"",""productPurchase"",""productSell"",""productImage"",""Category"", ""Description"") values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connector.myConnection());
                command.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));
                command.Parameters.AddWithValue("@p2", txtProduct.Text);
                command.Parameters.AddWithValue("@p3", int.Parse(UpDownStock.Value.ToString()));
                command.Parameters.AddWithValue("@p4", double.Parse(txtPurchase.Text));
                command.Parameters.AddWithValue("@p5", double.Parse(txtSell.Text));
                command.Parameters.AddWithValue("@p6", txtImage.Text);
                command.Parameters.AddWithValue("@p7", int.Parse(cmbCategory.SelectedValue.ToString()));
                command.Parameters.AddWithValue("@p8", richTextBox.Text);


                command.ExecuteNonQuery();
                connector.myConnection().Close();
                getProductList();
                MessageBox.Show("Product has been added successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Empty fields not allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand(@"DELETE FROM ""Product"" WHERE ""productID"" = @p1", connector.myConnection());
                    command.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));

                    command.ExecuteNonQuery();
                    connector.myConnection().Close();
                    getProductList();
                }
                catch (Exception)
                {

                    MessageBox.Show("Empty fields not allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedValue = dataGridProduct.SelectedCells[0].RowIndex;
            txtID.Text = dataGridProduct.Rows[selectedValue].Cells[0].Value.ToString();
            txtProduct.Text = dataGridProduct.Rows[selectedValue].Cells[1].Value.ToString();
            UpDownStock.Value = decimal.Parse(dataGridProduct.Rows[selectedValue].Cells[2].Value.ToString());
            txtPurchase.Text = dataGridProduct.Rows[selectedValue].Cells[3].Value.ToString();
            txtSell.Text = dataGridProduct.Rows[selectedValue].Cells[4].Value.ToString();
            txtImage.Text = dataGridProduct.Rows[selectedValue].Cells[6].Value.ToString();
            cmbCategory.Text = dataGridProduct.Rows[selectedValue].Cells[5].Value.ToString();
            richTextBox.Text = dataGridProduct.Rows[selectedValue].Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(@"update ""Product"" set ""productName""=@p1, ""productStock""=@p2, ""productPurchase""=@p3, ""productSell""=@p4, ""productImage""=@p5, ""Category""=@p6, ""Description""=@p7 where ""productID""=@p8", connector.myConnection());
                command.Parameters.AddWithValue("@p1", txtProduct.Text);
                command.Parameters.AddWithValue("@p2", int.Parse(UpDownStock.Value.ToString()));
                command.Parameters.AddWithValue("@p3", double.Parse(txtPurchase.Text));
                command.Parameters.AddWithValue("@p4", double.Parse(txtSell.Text));
                command.Parameters.AddWithValue("@p5", txtImage.Text);
                command.Parameters.AddWithValue("@p6", int.Parse(cmbCategory.SelectedValue.ToString()));
                command.Parameters.AddWithValue("@p7", richTextBox.Text);
                command.Parameters.AddWithValue("@p8", int.Parse(txtID.Text));

                command.ExecuteNonQuery();
                connector.myConnection().Close();
                getProductList();
                MessageBox.Show("Product has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Empty fields not allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand(@"Select * from ""productList"" where ""productName"" like '%" + txtProduct.Text + "%' ", connector.myConnection());
            DataSet ds = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(ds);

            dataGridProduct.DataSource = ds.Tables[0];
            dataGridProduct.Columns[0].Width = 38;
            dataGridProduct.Columns[1].Width = 125;
            connector.myConnection().Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            getProductList();
        }
    }
}
