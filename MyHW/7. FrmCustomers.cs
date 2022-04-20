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

        bool groupby = false;
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
                    this.comboBox1.Items.Add("All Countries");
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
            if (groupby == true)
            {
                SelectCountry("Group");
            }
            else
            {
                SelectCountry("none");
            }
        }

        private void SelectCountry(string Features)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    if (comboBox1.Text == "All Countries")
                    {
                        command.CommandText = "select * from Customers";
                    }
                    else
                    {
                        command.CommandText = $"select * from Customers where Country ='{comboBox1.Text}'";
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

                        string groupName = dataReader[8].ToString();
                        int index = 0;
                        countryimage(groupName, out index);

                        lvi.ImageIndex = index;

                        if (Features == "Group")
                        {
                            if (this.listView1.Groups[groupName] == null)
                            {
                                ListViewGroup group = this.listView1.Groups.Add(groupName, groupName);
                                lvi.Group = group;
                            }
                            else
                            {
                                ListViewGroup group = this.listView1.Groups[groupName];
                                lvi.Group = group;
                            }

                            if (lvi.Group.Items.Count % 2 == 0)
                            {
                                lvi.BackColor = Color.FromArgb(255, 248, 220);
                            }
                            else
                            {
                                lvi.BackColor = Color.FromArgb(162, 181, 205);
                            }


                            lvi.Group.Header = $"{groupName}({lvi.Group.Items.Count})";
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void countryimage(string Country, out int Index)
        {
            Index = 0;
            switch (Country)
            {
                case "Argentina":
                    Index = 0;
                    break;
                case "Austria":
                    Index = 1;
                    break;
                case "Belgium":
                    Index = 2;
                    break;
                case "Brazil":
                    Index = 3;
                    break;
                case "Canada":
                    Index = 4;
                    break;
                case "Denmark":
                    Index = 5;
                    break;
                case "Finland":
                    Index = 6;
                    break;
                case "France":
                    Index = 7;
                    break;
                case "Germany":
                    Index = 8;
                    break;
                case "Ireland":
                    Index = 9;
                    break;
                case "Italy":
                    Index = 10;
                    break;
                case "Mexico":
                    Index = 11;
                    break;
                case "Norway":
                    Index = 12;
                    break;
                case "Poland":
                    Index = 13;
                    break;
                case "Portugal":
                    Index = 14;
                    break;
                case "Spain":
                    Index = 15;
                    break;
                case "Sweden":
                    Index = 16;
                    break;
                case "Switzerland":
                    Index = 17;
                    break;
                case "UK":
                    Index = 18;
                    break;
                case "USA":
                    Index = 19;
                    break;
                case "Venezuela":
                    Index = 20;
                    break;
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
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
        }

        private void customerIdDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectCountry("Group");
            groupby = !groupby;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.Groups.Clear();
            groupby = !groupby;
        }
    }
}
