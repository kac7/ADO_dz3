using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado_dz3
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;
        SqlDataAdapter da = null;
        DataSet set = null;
        SqlCommandBuilder cmdBldr = null;
        int CellIndex;
        Chek chek = null;

        string[] query = {
           "SELECT dbo.Product.ID AS 'ID',dbo.Seller.NameSeller AS 'Seller',dbo.Product.NameProduct AS 'Product'," +
                "dbo.Product.PriceProduct AS 'Price',dbo.Product.ColorProduct AS 'Color' FROM dbo.Product " +
                "JOIN Seller ON Product.IDSeller = Seller.ID",
            "SELECT * FROM Seller",
            "SELECT * FROM Buyer",
            "SELECT * FROM CheckSale",
            "SELECT * FROM Seller;SELECT * FROM Buyer;SELECT * FROM CheckSale;SELECT * FROM Product",
            "SELECT dbo.CheckSale.ID AS 'ID',dbo.Product.NameProduct AS 'Product',dbo.Product.PriceProduct AS 'Price'," +
                "dbo.Seller.NameSeller AS 'Seller',dbo.Product.ColorProduct AS 'Color',dbo.CheckSale.DateSale AS 'Data', " +
                "dbo.Buyer.NameBuyer AS 'Buyer' FROM dbo.CheckSale " +
                "JOIN dbo.Seller ON dbo.CheckSale.IDSeller = dbo.Seller.ID " +
                "JOIN dbo.Product ON Product.ID = dbo.CheckSale.IDProduct " +
                "JOIN dbo.Buyer ON dbo.CheckSale.IDBuyer = dbo.Buyer.ID"
        };
        public Form1()
        {
            InitializeComponent();
            btnShowBuyer.Click += BtnShowBuyer_Click;
            btnShowSeller.Click += BtnShowSeller_Click;
            btnShowProduct.Click += BtnShowProduct_Click;
            btnTakeCheck.Click += BtnTakeCheck_Click;
            SelectBuyer.SelectedIndexChanged += SelectBuyer_SelectedIndexChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;
            btnBuy.Click += BtnBuy_Click;

            SelectNewItem(query[2]);
            ShowTable(query[0]);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellIndex = e.RowIndex;
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            labelOnly.Visible = false;
            labelSelect.Visible = true;
            BuyProduct(query[4]);
            ShowTable(query[0]);
        }
        private void SelectBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectBuyer.SelectedIndex != -1)
            {
                btnBuy.Enabled = true;
            }
        }
        private void BtnTakeCheck_Click(object sender, EventArgs e)
        {
            labelOnly.Visible = true;
            labelSelect.Visible = false;
            SelectBuyer.Enabled = false;
            btnBuy.Enabled = false;
            ShowTable(query[5]);
        }

        private void BtnShowProduct_Click(object sender, EventArgs e)
        {
            if (SelectBuyer.SelectedIndex != -1)
            {
                btnBuy.Enabled = true;
            }
            labelOnly.Visible = false;
            labelSelect.Visible = true;
            SelectBuyer.Enabled = true;
            ShowTable(query[0]);
        }

        private void BtnShowSeller_Click(object sender, EventArgs e)
        {
            labelOnly.Visible = true;
            labelSelect.Visible = false;
            SelectBuyer.Enabled = false;
            btnBuy.Enabled = false;
            ShowTable(query[1]);
        }

        private void BtnShowBuyer_Click(object sender, EventArgs e)
        {
            labelOnly.Visible = true;
            labelSelect.Visible = false;
            SelectBuyer.Enabled = false;
            btnBuy.Enabled = false;
            ShowTable(query[2]);
        }

        private void ShowTable(string strQuery)
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            set = new DataSet();
            da = new SqlDataAdapter(strQuery, connection);
            cmdBldr = new SqlCommandBuilder(da);
            da.Fill(set);
            dataGridView1.DataSource = set.Tables[0];            
        }
        private void SelectNewItem(string strQuery)
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            set = new DataSet();
            da = new SqlDataAdapter(strQuery, connection);
            cmdBldr = new SqlCommandBuilder(da);
            da.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                SelectBuyer.Items.Add($"{set.Tables[0].Rows[i][1]}");
            }
        }
        private void BuyProduct(string strQuery)
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            set = new DataSet();
            da = new SqlDataAdapter(strQuery, connection);
            cmdBldr = new SqlCommandBuilder(da);
            da.Fill(set);
            SqlCommand comm = connection.CreateCommand();
            SqlTransaction tran = null;
            chek = new Chek();
            try
            {
                connection.Open();
                tran = connection.BeginTransaction();
                comm.Transaction = tran;

                DataGridViewRow dataGrid = dataGridView1.Rows[CellIndex];

                for (int j = 0; j < set.Tables[3].Rows.Count; j++)
                {
                    if ((int)dataGrid.Cells[0].Value == (int)set.Tables[3].Rows[j][0])
                    {
                        int a = Convert.ToInt32(set.Tables[3].Rows[j][1]) - 1;
                        chek.product = Convert.ToInt32(set.Tables[3].Rows[j][0]);
                        chek.sellor = Convert.ToInt32(set.Tables[0].Rows[a][0]);
                        chek.sumBuy = Convert.ToInt32(set.Tables[3].Rows[j][3]);
                        comm.CommandText = $"UPDATE Seller SET SumProduct={Convert.ToInt32(set.Tables[0].Rows[a][2]) + chek.sumBuy} WHERE ID={Convert.ToInt32(set.Tables[0].Rows[a][0])}";
                        comm.ExecuteNonQuery();
                        break;
                    }
                }
                for (int i = 0; i < set.Tables[1].Rows.Count; i++)
                {
                    if (set.Tables[1].Rows[i][1].ToString() == SelectBuyer.SelectedItem.ToString())
                    {
                        if (Convert.ToInt32(set.Tables[1].Rows[i][2]) > chek.sumBuy)
                        {
                            chek.buyer = Convert.ToInt32(set.Tables[1].Rows[i][0]);
                            comm.CommandText = $"UPDATE Buyer SET SumBuyer={Convert.ToInt32(set.Tables[1].Rows[i][2]) - chek.sumBuy} WHERE ID={Convert.ToInt32(set.Tables[1].Rows[i][0])}";
                            comm.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("У Вас нет столько денег!!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                DateTime thisDay = DateTime.Today;
                thisDay.ToString("yyyy-MM-dd");

                comm.CommandText = $"INSERT CheckSale VALUES ({chek.product}, {chek.sellor}, {chek.buyer}, '{thisDay.ToString("yyyy-MM-dd")}', {chek.sumBuy})";
                comm.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tran.Rollback();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
