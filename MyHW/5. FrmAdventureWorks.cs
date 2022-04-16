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
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();

            this.comboBox1.Text = "請選擇年份";

            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);
            this.bindingSource1.DataSource = this.awDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.pictureBox1.DataBindings.Add("Image", this.bindingSource1, "LargePhoto", true);
            CreateYearToComboBox();

        }

        private void CreateYearToComboBox()
        {
            this.productPhoto1TableAdapter1.FillDateYear(this.awDataSet1.ProductPhoto1);
            foreach(DataRow row in awDataSet1.ProductPhoto1)
            {
                comboBox1.Items.Add(row[0]);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime T1 = dateTimePicker1.Value;
            DateTime T2 = dateTimePicker2.Value;
            productPhotoTableAdapter1.FillByTime(this.awDataSet1.ProductPhoto, T1, T2);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label4.Text = $"{this.bindingSource1.Position + 1}/{this.bindingSource1.Count}";
        }

        bool sort = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (sort)
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
            }
            sort = !sort;   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string year = comboBox.Text;
            productPhotoTableAdapter1.FillByYear(awDataSet1.ProductPhoto, year);
        }
    }
}
