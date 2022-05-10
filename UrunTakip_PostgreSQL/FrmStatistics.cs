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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        sqlConnector connector = new sqlConnector();

        void graphData() {
            NpgsqlCommand graphCommand = new NpgsqlCommand(@"Select ""categoryName"",Count (*) From ""productList"" Group By ""categoryName""", connector.myConnection());
            NpgsqlDataReader DataReader = graphCommand.ExecuteReader();
            while (DataReader.Read())
            {
                chart1.Series["Categories"].Points.AddXY(DataReader[0], DataReader[1]);
            }
            connector.myConnection().Close();
        }

        void categoryCount()
        {
            NpgsqlCommand Command = new NpgsqlCommand(@"Select Count (*) From ""categories""", connector.myConnection());
            NpgsqlDataReader dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                lblCategory.Text = dataReader[0].ToString();
            }
            connector.myConnection().Close();
        }

        void stockCount()
        {
            NpgsqlCommand Command = new NpgsqlCommand(@"SELECT SUM(""productStock"") FROM ""Product""", connector.myConnection());
            NpgsqlDataReader dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                lblStock.Text = dataReader[0].ToString();
            }
            connector.myConnection().Close();
        }

        void cheapestToExpensive()
        {
            NpgsqlCommand Command = new NpgsqlCommand(@"SELECT MAX(""productPurchase"") FROM ""Product""", connector.myConnection());
            NpgsqlDataReader dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                lblExpensive.Text = dataReader[0].ToString() + " $";
            }
            connector.myConnection().Close();

            NpgsqlCommand Command2 = new NpgsqlCommand(@"SELECT MIN(""productPurchase"") FROM ""Product""", connector.myConnection());
            NpgsqlDataReader dataReader2 = Command2.ExecuteReader();
            while (dataReader2.Read())
            {
                LblCheap.Text = dataReader2[0].ToString() + " $";
            }
            connector.myConnection().Close();
        }

        void productCount()
        {
            NpgsqlCommand Command = new NpgsqlCommand(@"Select Count (*) From ""Product""", connector.myConnection());
            NpgsqlDataReader dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                lblProduct.Text = dataReader[0].ToString();
            }
            connector.myConnection().Close();
        }

        void countCustomerCities()
        {
            NpgsqlCommand Command = new NpgsqlCommand(@"SELECT Count(DISTINCT(""customerCity"")) FROM ""Customer""", connector.myConnection());
            NpgsqlDataReader dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                lblCustomerCity.Text = dataReader[0].ToString();
            }
            connector.myConnection().Close();
        }

        void customerCount()
        {
            NpgsqlCommand Command = new NpgsqlCommand(@"SELECT Count(*) FROM ""Customer""", connector.myConnection());
            NpgsqlDataReader dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                lblCustomerCount.Text = dataReader[0].ToString();
            }
            connector.myConnection().Close();
        }

        void calculateTotalMoney()
        {
            NpgsqlCommand Command = new NpgsqlCommand(@"SELECT SUM(""price"") FROM ""Sale""", connector.myConnection());
            NpgsqlDataReader dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                lblTotalMoney.Text = dataReader[0].ToString() + " $";
            }
            connector.myConnection().Close();
        }

        void mostProfit()
        {
            NpgsqlCommand Command = new NpgsqlCommand(@"SELECT MAX(""profit"") FROM ""Sale""", connector.myConnection());
            NpgsqlDataReader dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                lblMostProfit.Text = dataReader[0].ToString() + " $";
            }
            connector.myConnection().Close();
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            graphData();

            categoryCount();

            productCount();

            stockCount();

            cheapestToExpensive();

            countCustomerCities();

            customerCount();

            calculateTotalMoney();

            mostProfit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmManager manager = new FrmManager();
            this.Hide();
        }
    }
}
