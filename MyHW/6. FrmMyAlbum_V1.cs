using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            this.city1TableAdapter1.FillByCity(this.mytripDataSet1.City1);
            this.photo1TableAdapter1.FillByAll(this.mytripDataSet1.Photo1);
            this.bindingSource1.DataSource = this.mytripDataSet1.Photo1;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.pictureBox1.DataBindings.Add("Image", this.bindingSource1, "Photo", true);
            for (int i = 0; i < this.mytripDataSet1.City1.Rows.Count; i++)
            {
                LinkLabel linkLabel = new LinkLabel();

                linkLabel.Text = this.mytripDataSet1.City1[i].CityName;
                linkLabel.Left = 15;
                linkLabel.Top = 40 * i;
                linkLabel.Click += LinkLabel_Click;
                panel1.Controls.Add(linkLabel);
            }
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
            this.pictureBox1.DataBindings.Clear();
            LinkLabel linkLabel = (LinkLabel)sender;
            string cityname = linkLabel.Text;
            this.photo1TableAdapter1.FillByCityName(this.mytripDataSet1.Photo1,cityname);
            this.bindingSource1.DataSource = this.mytripDataSet1.Photo1;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.pictureBox1.DataBindings.Add("Image", this.bindingSource1, "Photo", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCRUD frmToolCRUD = new FrmCRUD();
            frmToolCRUD.Show();
        }
    }
}
