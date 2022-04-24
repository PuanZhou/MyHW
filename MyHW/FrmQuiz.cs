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
    public partial class FrmQuiz : Form
    {
        public FrmQuiz()
        {
            InitializeComponent();
            LoadDataToTreeView();
        }

        TreeView treeView = new TreeView();
        List<string> CountryName = new List<string>();
        private void FrmQuiz_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;

            treeView.Dock = DockStyle.Fill;
            treeView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeView.AfterSelect += TreeView_AfterSelect;
            this.splitContainer1.Panel1.Controls.Add(treeView);
            this.label1.BackColor = Color.FromArgb(255, 245, 238);
            this.dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView treeView = (TreeView)sender;

            char[] remove = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '(', ')' };
            string newstring = treeView.SelectedNode.Text.TrimEnd(remove);

            if (!CountryName.Contains(newstring))
            {
                this.customersTableAdapter1.FillByCity(nwDataSet1.Customers, treeView.SelectedNode.Text);
                this.bindingSource1.DataSource = nwDataSet1.Customers;
                this.dataGridView1.DataSource = this.bindingSource1;
                this.label1.Text = $"{treeView.SelectedNode.Text}城市的客戶共有{this.bindingSource1.Count}個";
            }
        }

        private void LoadDataToTreeView()
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

                    this.treeView.Nodes.Clear();

                    while (dataReader.Read())
                    {
                        string Country = dataReader["Country"].ToString();
                        string City = dataReader["City"].ToString();

                        TreeNode treeNode;

                        if (this.treeView.Nodes[Country] == null)
                        {
                            CountryName.Add(Country);
                            treeNode = this.treeView.Nodes.Add(Country, Country);
                            treeNode.Tag = 0;
                        }
                        else
                        {
                            treeNode = this.treeView.Nodes[Country];
                            treeNode.Tag = int.Parse(treeNode.Tag.ToString()) + 1;
                        }

                        treeNode.Text = $"{Country}({int.Parse(treeNode.Tag.ToString()) + 1})";
                        if (treeNode.Nodes[City] == null)
                        {
                            treeNode.Nodes.Add(City, City);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
