﻿using System;
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
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();
            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);
            this.bindingSource1.DataSource = this.awDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True");
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(" select  DISTINCT DATEPART(yyyy,ModifiedDate)as DateTime from Production.ProductPhoto", conn);
            //DataTable ds = new DataTable();
            //dataAdapter.Fill(ds);
            //this.comboBox1.DataSource = ds;
            //this.comboBox1.DisplayMember= "DateTime";
            this.comboBox1.DataSource = this.awDataSet1.ProductPhoto;
            this.comboBox1.DisplayMember = "ModifiedDate";
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[5], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}