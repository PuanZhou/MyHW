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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            this.productsTableAdapter1.Fill(nwDataSet1.Products);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.labelTableCount.Text = $"{this.bindingSource1.Position + 1}/{this.bindingSource1.Count}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checknum();
        }

        int UPL, UPH;
        internal void Checknum()
        {

            bool IsNUm;
            IsNUm = int.TryParse(textBoxUPL.Text, out UPL) && int.TryParse(textBoxUPH.Text, out UPH);
            if (IsNUm)
            {

            }
            else if(textBoxUPH.Text == string.Empty)
            {
                UPH = Int32.MaxValue;
            }
            else if (textBoxUPL.Text == string.Empty)
            {
                UPL=1;
            }
            else
            {
                MessageBox.Show("請輸入數字!");
                return;
            }
            
            Search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilterName();
        }

        internal void Search()
        {
            productsTableAdapter1.FillByPrice(this.nwDataSet1.Products, UPL, UPH);
            this.dataGridView1.DataSource = this.nwDataSet1.Products;
            this.labelrecords.Text = $"總共有:{this.bindingSource1.Count}筆";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(nwDataSet1.Products);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.textBoxUPL.Text = string.Empty;
            this.textBoxUPH.Text = string.Empty;
            this.textBoxProductName.Text = string.Empty;
            this.labelrecords.Text = string.Empty;
        }

        private void CheckNum(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        internal void FilterName()
        {
            productsTableAdapter1.FillByProductName(this.nwDataSet1.Products, textBoxProductName.Text);
            this.dataGridView1.DataSource = this.nwDataSet1.Products;
            this.labelrecords.Text = $"總共有:{this.bindingSource1.Count}筆";
        }
    }
}
