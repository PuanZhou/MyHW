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
    public partial class FrmCRUD : Form
    {
        public FrmCRUD()
        {
            InitializeComponent();
        }

        private void photoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mytripDataSet);

        }

        private void FrmCRUD_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mytripDataSet.City' 資料表。您可以視需要進行移動或移除。
            this.cityTableAdapter.Fill(this.mytripDataSet.City);
            // TODO: 這行程式碼會將資料載入 'mytripDataSet.Photo' 資料表。您可以視需要進行移動或移除。
            this.photoTableAdapter.Fill(this.mytripDataSet.Photo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.photoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }
    }
}
