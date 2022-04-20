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
    public partial class FrmMyAlbum_V2 : Form
    {
        public FrmMyAlbum_V2()
        {
            InitializeComponent();
            LoadCityToComboBox();
            CreateLinkTable();
        }

        private void CreateLinkTable()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MytripDatabaseConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from City";
                    command.Connection = conn;

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = dataReader["CityName"].ToString();
                        linkLabel.Click += LinkLabel_Click;
                        linkLabel.Margin = new Padding(10);
                        this.flowLayoutPanel2.Controls.Add(linkLabel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MytripDatabaseConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from Photo where ";
                    command.Connection = conn;

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = dataReader["CityName"].ToString();
                        linkLabel.Click += LinkLabel_Click;
                        linkLabel.Margin = new Padding(10);
                        linkLabel.AutoSize = false;
                        this.flowLayoutPanel2.Controls.Add(linkLabel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCityToComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MytripDatabaseConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from City";
                    command.Connection = conn;

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    this.comboBox1.Items.Clear();

                    while (dataReader.Read())
                    {
                        this.comboBox1.Items.Add(dataReader["CityName"]);
                    }
                    this.comboBox1.Text = "Select a City";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
