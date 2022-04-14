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

            SqlDataAdapter dataAdapter = new SqlDataAdapter("select  CategoryName  from Categories", conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                comboBoxDisconnected.Items.Add(row[0]);
            }
        }

        string categoryName;
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            categoryName = comboBox.Text;
            SelectCategory();
        }

        internal void SelectCategory()
        {
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();

                SqlCommand command = new SqlCommand($"select *, CategoryName  from Products p join Categories c on p.CategoryID = c.CategoryID where c.CategoryName = '{categoryName}'", conn);

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

        string discategoryName;
        private void comboBoxDisconnected_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            discategoryName = combobox.Text;
            DisconnectedSelected();
        }

        internal void DisconnectedSelected()
        {
            SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True");
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select ProductName , CategoryName,UnitPrice from Products p join Categories c on p.CategoryID = c.CategoryID where c.CategoryName= '{discategoryName}'", conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            listBox1.Items.Clear();
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                DataTable table = ds.Tables[i];
                string CN = string.Empty;
                for (int column = 0; column < table.Columns.Count; column++)
                {
                    CN += $"{table.Columns[column].ColumnName,-40}";
                }

                listBox1.Items.Add(CN);

                
                for (int row = 0; row < table.Rows.Count; row++)
                {
                    string RN = string.Empty;
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        RN += $"{table.Rows[row][j],-40}";
                    }
                    listBox1.Items.Add(RN);
                }
            }
        }
    }
}
