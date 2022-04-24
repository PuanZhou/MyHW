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
    public partial class FrmPhotoViwer : Form
    {
        internal int Potoindex;
        private FrmMyAlbum_V2 FrmMyAlbum_V2;
        public FrmPhotoViwer()
        {

            InitializeComponent();

        }
        private void FrmPhotoViwer_Load(object sender, EventArgs e)
        {
            this.FrmMyAlbum_V2 = (FrmMyAlbum_V2)Application.OpenForms["FrmMyAlbum_V2"];
            this.pictureBox1.Image = ((PictureBox)FrmMyAlbum_V2.flowLayoutPanel1.Controls[Potoindex]).Image;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Potoindex > 0)
            {
                Potoindex--;
                this.pictureBox1.Image = ((PictureBox)FrmMyAlbum_V2.flowLayoutPanel1.Controls[Potoindex]).Image;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Potoindex < FrmMyAlbum_V2.flowLayoutPanel1.Controls.Count-1)
            {
                Potoindex++;
                this.pictureBox1.Image = ((PictureBox)FrmMyAlbum_V2.flowLayoutPanel1.Controls[Potoindex]).Image;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Potoindex == FrmMyAlbum_V2.flowLayoutPanel1.Controls.Count - 1)
            {
                Potoindex = 0;
                this.pictureBox1.Image = ((PictureBox)FrmMyAlbum_V2.flowLayoutPanel1.Controls[Potoindex]).Image;
            }
            else
            {
                Potoindex++;
                this.pictureBox1.Image = ((PictureBox)FrmMyAlbum_V2.flowLayoutPanel1.Controls[Potoindex]).Image;
            }
        }

        bool autoplay = false;
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            autoplay = !autoplay;
            if (autoplay)
            {
                this.timer1.Enabled = true;
            }
            else
            {
                this.timer1.Enabled = false;
            }
        }

        private void FrmPhotoViwer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Enabled = false;
        }
    }
}
