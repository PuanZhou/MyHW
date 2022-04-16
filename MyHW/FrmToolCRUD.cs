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
    public partial class FrmToolCRUD : Form
    {
        public FrmToolCRUD()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            this.mytripPhotoTableAdapter1.Fill(mytripDataSet1.Photo);
            this.bindingSource1.DataSource = this.mytripDataSet1.Photo;
            this.dataGridView1.DataSource = this.bindingSource1.DataSource;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.textBox1.DataBindings.Add("Text", this.bindingSource1, "PhotoId");
            this.textBox2.DataBindings.Add("Text", this.bindingSource1, "CityId");
            this.pictureBox1.DataBindings.Add("Image", this.bindingSource1, "Photo", true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource1.EndEdit();
            this.mytripPhototableAdapterManager1.UpdateAll(this.mytripDataSet1);
        }
    }
}
