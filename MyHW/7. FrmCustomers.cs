using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            this.listView1.View = View.Details;

            CreateListViewColumns();
            LoadCountrytoComboBox();
        }

        private void LoadCountrytoComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select distinct Country from Customers";
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.comboBox1.Text = "Select a Country";
                    while (dataReader.Read())
                    {
                        comboBox1.Items.Add(dataReader["Country"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateListViewColumns()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from Customers";
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    DataTable table = dataReader.GetSchemaTable();

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }

                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string comboboxtxt = string.Empty;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            comboboxtxt = comboBox.Text;
            SelectCountry(comboboxtxt,"none");
        }

        private void SelectCountry(string Country, string Features)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    if (Country == "All Countries")
                    {
                        command.CommandText = "select * from Customers";
                    }
                    else
                    {
                        command.CommandText = $"select * from Customers where Country ='{Country}'";
                    }
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listView1.Items.Clear();

                    while (dataReader.Read())
                    {
                        ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

                        //this.listView1.Visible = false;
                        

                        if (lvi.Index % 2 == 0)
                        {
                            lvi.BackColor = Color.FromArgb(255, 248, 220);
                        }
                        else
                        {
                            lvi.BackColor = Color.FromArgb(162, 181, 205);
                        }

                        for (int i = 1; i < dataReader.FieldCount; i++)
                        {
                            if (dataReader.IsDBNull(i))
                            {
                                lvi.SubItems.Add("Null");
                            }
                            else
                            {
                                lvi.SubItems.Add(dataReader[i].ToString());
                            }
                           
                            string groupName = dataReader[8].ToString();

                            switch (groupName)
                            {
                                case "Argentina":
                                    lvi.ImageIndex = 0;
                                    break;
                                case "Austria":
                                    lvi.ImageIndex = 1;
                                    break;
                                case "Belgium":
                                    lvi.ImageIndex = 2;
                                    break;
                                case "Brazil":
                                    lvi.ImageIndex = 3;
                                    break;
                                case "Canada":
                                    lvi.ImageIndex = 4;
                                    break;
                                case "Denmark":
                                    lvi.ImageIndex = 5;
                                    break;
                                case "Finland":
                                    lvi.ImageIndex = 6;
                                    break;
                                case "France":
                                    lvi.ImageIndex = 7;
                                    break;
                                case "Germany":
                                    lvi.ImageIndex = 8;
                                    break;
                                case "Ireland":
                                    lvi.ImageIndex = 9;
                                    break;
                                case "Italy":
                                    lvi.ImageIndex = 10;
                                    break;
                                case "Mexico":
                                    lvi.ImageIndex = 11;
                                    break;
                                case "Norway":
                                    lvi.ImageIndex = 12;
                                    break;
                                case "Poland":
                                    lvi.ImageIndex = 13;
                                    break;
                                case "Portugal":
                                    lvi.ImageIndex = 14;
                                    break;
                                case "Spain":
                                    lvi.ImageIndex = 15;
                                    break;
                                case "Sweden":
                                    lvi.ImageIndex = 16;
                                    break;
                                case "Switzerland":
                                    lvi.ImageIndex = 17;
                                    break;
                                case "UK":
                                    lvi.ImageIndex = 18;
                                    break;
                                case "USA":
                                    lvi.ImageIndex = 19;
                                    break;
                                case "Venezuela":
                                    lvi.ImageIndex = 20;
                                    break;
                            }

                            if (Features == "Group")
                            {
                                if (dataReader[8].ToString() == groupName)
                                {
                                    if (this.listView1.Groups[groupName] == null)
                                    {
                                        ListViewGroup group = this.listView1.Groups.Add(groupName, groupName);
                                        group.Tag = 0;
                                        lvi.Group = group;
                                    }
                                    else
                                    {
                                        ListViewGroup group = this.listView1.Groups[groupName];
                                        lvi.Group = group;
                                    }
                                }
                            }
                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void detToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void customerIDAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void customerIdDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectCountry(comboboxtxt, "Group");
        }
    }
}
