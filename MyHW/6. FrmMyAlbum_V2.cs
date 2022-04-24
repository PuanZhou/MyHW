using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmMyAlbum_V2 : Form
    {

        public FrmMyAlbum_V2()
        {
            InitializeComponent();
            LoadCityToComboBox();
            CreateLinkTable();
            LoadCityID();
            //================
            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.DragDrop += FlowLayoutPanel3_DragDrop;
            this.flowLayoutPanel3.DragEnter += FlowLayoutPanel3_DragEnter;
        }

        Dictionary<int, int> CityID = new Dictionary<int, int>();
        private void LoadCityID()
        {
            CityID.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MytripDatabaseConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from City";
                    command.Connection = conn;

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    int i = 0;
                    while (dataReader.Read())
                    {
                        CityID.Add(i, int.Parse(dataReader["CityID"].ToString()));
                        i++;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FlowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        private void FlowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxes.Clear();
            flowLayoutPanel3.Controls.Clear();
            label5.Visible = true;
            button3.Visible = true;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i < files.Length; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Tag = i;
                pic.Padding = new Padding(10);
                pic.Click += PicDragDrop_Click;
                pic.MouseMove += PictureBox_MouseMove;
                pic.MouseLeave += PictureBox_MouseLeave;
                pic.Size = new Size(280, 200);
                pictureBoxes.Add(pic);
                this.flowLayoutPanel3.Controls.Add(pic);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> filter;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxes.Clear();
                flowLayoutPanel3.Controls.Clear();
                label5.Visible = true;
                button3.Visible = true;

                filter = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*")
                    .Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("jpeg")
                    || file.ToLower().EndsWith("gif") || file.ToLower().EndsWith("png")
                    || file.ToLower().EndsWith("bmp")).ToList();

                for (int i = 0; i < filter.Count; i++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(filter[i]);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Tag = i;
                    pic.Padding = new Padding(10);
                    pic.Click += PicDragDrop_Click;
                    pic.MouseMove += PictureBox_MouseMove;
                    pic.MouseLeave += PictureBox_MouseLeave;
                    pic.Size = new Size(280, 200);
                    pictureBoxes.Add(pic);
                    this.flowLayoutPanel3.Controls.Add(pic);
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select a City")
            {
                MessageBox.Show("請選擇一個城市!");
                return;
            }
            DialogResult result = MessageBox.Show("您確認要將相片全部存入相簿嗎?", "確認儲存?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MytripDatabaseConnectionString))
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "Insert into Photo (CityID,Photo) values (@CityID,@Photo)";
                        command.Connection = conn;
                        conn.Open();

                        for (int i = 0; i < flowLayoutPanel3.Controls.Count; i++)
                        {
                            command.Parameters.Clear();
                            MemoryStream ms = new System.IO.MemoryStream();
                            pictureBoxes[i].Image.Save(ms, ImageFormat.Jpeg);
                            byte[] bytes = ms.GetBuffer();
                            command.Parameters.Add("@CityID", SqlDbType.Int).Value = CityID[comboBox1.SelectedIndex];
                            command.Parameters.Add("@Photo", SqlDbType.Image).Value = bytes;
                            command.ExecuteNonQuery();
                        }
                    }
                    this.photoTableAdapter.Fill(mytripDataSet.Photo);
                    MessageBox.Show("相片新增完成!");
                    ReFillData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }
        private void PicDragDrop_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBoxes.RemoveAt(this.flowLayoutPanel3.Controls.IndexOf(pictureBox));
            this.flowLayoutPanel3.Controls.RemoveAt(this.flowLayoutPanel3.Controls.IndexOf(pictureBox));
            if (this.flowLayoutPanel3.Controls.Count == 0)
            {
                button3.Visible = false;
            }
        }

        private void CreateLinkTable()
        {
            this.flowLayoutPanel2.Controls.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MytripDatabaseConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from City";
                    command.Connection = conn;

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    int i = 0;
                    while (dataReader.Read())
                    {
                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = dataReader["CityName"].ToString();
                        linkLabel.Click += LinkLabel_Click;
                        linkLabel.Tag = i;
                        i++;
                        linkLabel.AutoSize = true;
                        linkLabel.Margin = new Padding(10);
                        this.flowLayoutPanel2.Controls.Add(linkLabel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;

            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MytripDatabaseConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from Photo where CityID='{CityID[int.Parse(linkLabel.Tag.ToString())]}'";
                    command.Connection = conn;

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();


                    this.flowLayoutPanel1.Controls.Clear();
                    while (dataReader.Read())
                    {
                        byte[] bytes = (byte[])dataReader["Photo"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(ms);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Padding = new Padding(10);
                        pictureBox.Click += PictureBox_Click;
                        pictureBox.MouseMove += PictureBox_MouseMove;
                        pictureBox.MouseLeave += PictureBox_MouseLeave;
                        pictureBox.Size = new Size(280, 200);
                        this.flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.Transparent;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.LightSkyBlue;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            new FrmPhotoViwer
            {
               Potoindex = this.flowLayoutPanel1.Controls.IndexOf((PictureBox)sender)
            }.ShowDialog();
        }

        private void LoadCityToComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MytripDatabaseConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from City";
                    command.Connection = conn;

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    this.comboBox1.Items.Clear();

                    while (dataReader.Read())
                    {
                        this.comboBox1.Items.Add(dataReader["CityName"]);
                    }
                    this.comboBox1.Text = "Select a City";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ComboBox combobox;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox = (ComboBox)sender;
            ReFillData();
        }

        private void ReFillData()
        {
            label5.Visible = false;
            button3.Visible = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MytripDatabaseConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from Photo where CityID ='{CityID[combobox.SelectedIndex]}'";
                    command.Connection = conn;

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();


                    this.flowLayoutPanel3.Controls.Clear();
                    while (dataReader.Read())
                    {
                        byte[] bytes = (byte[])dataReader["Photo"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        PictureBox pictureBoxdrag = new PictureBox();
                        pictureBoxdrag.Image = Image.FromStream(ms);
                        pictureBoxdrag.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxdrag.Padding = new Padding(10);
                        pictureBoxdrag.MouseMove += PictureBox_MouseMove;
                        pictureBoxdrag.MouseLeave += PictureBox_MouseLeave;
                        pictureBoxdrag.Size = new Size(280, 200);
                        this.flowLayoutPanel3.Controls.Add(pictureBoxdrag);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmMyAlbum_V2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mytripDataSet.Photo' 資料表。您可以視需要進行移動或移除。
            this.photoTableAdapter.Fill(this.mytripDataSet.Photo);
            // TODO: 這行程式碼會將資料載入 'mytripDataSet.Photo' 資料表。您可以視需要進行移動或移除。
            this.photoTableAdapter.Fill(this.mytripDataSet.Photo);
            // TODO: 這行程式碼會將資料載入 'mytripDataSet.City' 資料表。您可以視需要進行移動或移除。
            this.cityTableAdapter.Fill(this.mytripDataSet.City);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.photoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mytripDataSet);
            LoadCityToComboBox();
            LoadCityID();
            CreateLinkTable();
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mytripDataSet);
            comboBox1.Text = "Select a City";
            this.flowLayoutPanel3.Controls.Clear();
        }
    }
}
