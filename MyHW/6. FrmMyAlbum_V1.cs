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
            mytripCityTableAdapter1.Fill(this.mytripDataSet1.City);
            mytripPhotoTableAdapter1.Fill(this.mytripDataSet1.Photo);
            this.bindingSource1.DataSource = this.mytripDataSet1.Photo;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.pictureBox1.DataBindings.Add("Image", this.bindingSource1, "Photo", true);
            for (int i = 0; i < mytripDataSet1.City.Rows.Count; i++)
            {
                LinkLabel linkLabel = new LinkLabel();

                linkLabel.Text = mytripDataSet1.City[i].CityName;
                linkLabel.Left = 15;
                linkLabel.Top = 40 * i;
                linkLabel.Click += LinkLabel_Click;
                panel1.Controls.Add(linkLabel);
            }
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmToolCRUD frmToolCRUD = new FrmToolCRUD();
            frmToolCRUD.Show();
        }
    }
}
