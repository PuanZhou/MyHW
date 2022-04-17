using MyHW.Properties;
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
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Text;
                using (SqlConnection conn = new SqlConnection(Settings.Default.MymemberDatabase))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "InsertMember";
                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = username;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = password;

                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("註冊成功!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Text;

                using (SqlConnection conn=new SqlConnection(Settings.Default.MymemberDatabase))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Checkmember";
                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = username;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = password;

                    conn.Open();
                   SqlDataReader dataReader= command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("會員登入成功");
                    }
                    else
                    {
                        MessageBox.Show("會員登入失敗請確認帳號及密碼");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }
    }
}
