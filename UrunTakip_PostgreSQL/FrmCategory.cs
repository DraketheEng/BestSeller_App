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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        sqlConnector connector = new sqlConnector();

        void getCategoryList()
        {
            string query = @"select * from ""categories""";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connector.myConnection());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridCategory.DataSource = ds.Tables[0];
            dataGridCategory.Columns[0].Width = 45;
        }
        void clear()
        {
            txtID.Text = "";
            txtCategory.Text = "";
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            getCategoryList();
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

        private void dataGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedValue = dataGridCategory.SelectedCells[0].RowIndex;
            txtID.Text = dataGridCategory.Rows[selectedValue].Cells[0].Value.ToString();
            txtCategory.Text = dataGridCategory.Rows[selectedValue].Cells[1].Value.ToString();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(@"insert into ""categories"" (""categoryID"",""categoryName"") values (@p1,@p2)", connector.myConnection());
                command.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));
                command.Parameters.AddWithValue("@p2", txtCategory.Text);

                command.ExecuteNonQuery();
                connector.myConnection().Close();
                getCategoryList();
                MessageBox.Show("Category Added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Empty fields not allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(@"update ""categories"" set ""categoryName""=@p1 where ""categoryID""=@p2", connector.myConnection());
                command.Parameters.AddWithValue("@p1", txtCategory.Text);
                command.Parameters.AddWithValue("@p2", int.Parse(txtID.Text));

                command.ExecuteNonQuery();
                connector.myConnection().Close();
                getCategoryList();
                MessageBox.Show("Category Updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    NpgsqlCommand command = new NpgsqlCommand(@"DELETE FROM ""categories"" WHERE ""categoryID""=@p1", connector.myConnection());
                    command.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));

                    command.ExecuteNonQuery();
                    connector.myConnection().Close();
                    getCategoryList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Empty fields not allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand(@"Select * from ""categories"" where ""categoryName"" like '%" + txtCategory.Text + "%' ", connector.myConnection());
            DataSet dataSet = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(dataSet);

            dataGridCategory.DataSource = dataSet.Tables[0];
            dataGridCategory.Columns[0].Width = 45;
            connector.myConnection().Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            getCategoryList();
        }
    }
}
