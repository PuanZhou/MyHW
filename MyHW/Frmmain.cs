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
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();

            Createbutton();
        }

        private void Createbutton()
        {
            string[] buttonname = { "MyHWForm", "FrmCategoryProducts", "FrmProducts", "Frmdatasets", "FrmAdventureWorks", "FrmMyAlbum", "FrmCustomes", "FrmLogon" };

            for (int i = 0; i < 8; i++)
            {
                Button newbutton = new Button();

                newbutton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                newbutton.Text = buttonname[i];
                newbutton.Size = new Size(250, 40);
                newbutton.Left = 10;
                newbutton.Top = 60 * i;
                newbutton.Tag = i;
                newbutton.BackColor = Color.FromArgb(131, 139, 131);
                newbutton.Click += Newbutton_Click;
                newbutton.MouseMove += Newbutton_MouseMove;
                newbutton.MouseLeave += Newbutton_MouseLeave;
                this.splitContainer2.Panel1.Controls.Add(newbutton);
            }
        }

        private void Newbutton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Cursor = Cursors.Default;
            btn.BackColor = Color.FromArgb(131, 139, 131);
        }

        private void Newbutton_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Cursor = Cursors.Hand;
            btn.BackColor = Color.FromArgb(255, 114, 86);
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.splitContainer2.Panel2.Controls.Clear();
            int tag = int.Parse(btn.Tag.ToString());

            switch (tag)
            {
                case 0:
                    MyHWForm Form1 = new MyHWForm();
                    Form1.TopLevel = false;
                    Form1.Show();
                    this.splitContainer2.Panel2.Controls.Add(Form1);
                    break;

                case 1:
                    FrmCategoryProducts Form2 = new FrmCategoryProducts();
                    Form2.TopLevel = false;
                    Form2.Show();
                    this.splitContainer2.Panel2.Controls.Add(Form2);
                    break;

                case 2:
                    FrmProducts Form3 = new FrmProducts();
                    Form3.TopLevel = false;
                    Form3.Show();
                    splitContainer2.Panel2.Controls.Add(Form3);
                    break;

                case 3:
                    FrmDataSet Form4 = new FrmDataSet();
                    Form4.TopLevel = false;
                    Form4.Show();
                    this.splitContainer2.Panel2.Controls.Add(Form4);
                    break;

                case 4:
                    FrmAdventureWorks Form5 = new FrmAdventureWorks();
                    Form5.TopLevel = false;
                    Form5.Show();
                    this.splitContainer2.Panel2.Controls.Add(Form5);
                    break;

                case 5:
                    FrmMyAlbum_V1 Form6 = new FrmMyAlbum_V1();
                    Form6.TopLevel = false;
                    Form6.Show();
                    this.splitContainer2.Panel2.Controls.Add(Form6);
                    break;

                case 6:
                    FrmCustomers Form7 = new FrmCustomers();
                    Form7.TopLevel = false;
                    Form7.Show();
                    this.splitContainer2.Panel2.Controls.Add(Form7);
                    break;

                case 7:
                    FrmLogon Form8 = new FrmLogon();
                    Form8.TopLevel = false;
                    Form8.Show();
                    this.splitContainer2.Panel2.Controls.Add(Form8);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel1Collapsed = !this.splitContainer2.Panel1Collapsed;
        }
    }
}
