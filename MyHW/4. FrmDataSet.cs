using MyHW.Properties;
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
    public partial class FrmDataSet : Form
    {
        public FrmDataSet()
        {
            InitializeComponent();
            this.listBox1.Font = Settings.Default.MyFont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);

            listBox1.Items.Clear();
            for (int i = 0; i < nwDataSet1.Tables.Count; i++)
            {
                DataTable table = this.nwDataSet1.Tables[i];
                listBox1.Items.Add(table.TableName);
                listBox1.Items.Add("===============================");
                string s = string.Empty;
                for (int column = 0; column < table.Columns.Count; column++)
                {
                    if (column== 0)
                    {
                        s += $"{table.Columns[column].ColumnName,-20}";
                    }
                    else
                    {
                        s += $"{table.Columns[column].ColumnName,-50}";
                    }
                }
                listBox1.Items.Add(s);
                for(int row = 0; row < table.Rows.Count; row++)
                {
                    string y = string.Empty;
                    for(int j=0; j < table.Columns.Count; j++)
                    {
                        if (j == 0)
                        {
                            y += $"{table.Rows[row][j],-20}";
                        }
                        else
                        {
                            y += $"{table.Rows[row][j],-50}";
                        }
                    }
                    listBox1.Items.Add(y);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.MyFont = this.listBox1.Font = this.fontDialog1.Font;
                Settings.Default.Save();
            }
        }
    }
}
