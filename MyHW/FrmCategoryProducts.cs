using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyHW
{
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();

                SqlCommand command = new SqlCommand($"select   CategoryName from Categories ", conn);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    this.comboBoxCategory.Items.Add(dataReader["CategoryName"]);
                }
                labelConnect.Text = "Conected";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select  CategoryName  from Categories", conn);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            comboBoxDisconnected.DataSource = ds;
            comboBoxDisconnected.DisplayMember = "CategoryName";
        }

        int index;
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            index = comboBox.SelectedIndex;
            SelectCategory();
        }

        internal void SelectCategory()
        {
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();

                SqlCommand command = new SqlCommand($"select *, CategoryName  from Products p join Categories c on p.CategoryID = c.CategoryID where c.CategoryID = {index + 1}", conn);

                SqlDataReader dataReader = command.ExecuteReader();

                listBoxCategory.Items.Clear();

                while (dataReader.Read())
                {
                    string item = $"{dataReader["ProductID"],-3} - {dataReader["ProductName"],-35} - { dataReader["CategoryName"],-5} - {dataReader["UnitPrice"]:c2} ";
                    this.listBoxCategory.Items.Add(item);
                }

                labelConnect.Text = "Conected";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        int disindex;
        private void comboBoxDisconnected_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
             disindex = combobox.SelectedIndex;
            DisconnectedSelected();
        }

        internal void DisconnectedSelected()
        {
            SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True");
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select ProductName , CategoryName  from Products p join Categories c on p.CategoryID = c.CategoryID where c.CategoryID = {disindex + 1}", conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
