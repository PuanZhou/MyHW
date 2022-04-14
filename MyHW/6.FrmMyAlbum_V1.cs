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
            cityTableAdapter1.Fill(mytripDataSet1.City);

            for(int i = 0;i<mytripDataSet1.City.Rows.Count;i++)
            {
                LinkLabel LB = new LinkLabel();

                LB.Text = mytripDataSet1.City[i][1].ToString();
                LB.Left = 0;
                LB.Top = i * 40;
                this.splitContainer1.Panel1.Controls.Add(LB);
                LB.Click += LB_Click;
            }

        }

        private void LB_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
