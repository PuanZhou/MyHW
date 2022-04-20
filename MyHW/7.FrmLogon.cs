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

                if (UsernameTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("請輸入會員名稱");
                    return;
                }
                else if (PasswordTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("請輸入密碼");
                    return;
                }


                using (SqlConnection conn = new SqlConnection(Settings.Default.MymemberDatabase))
                //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30
                //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MymemberDatabase.mdf;Integrated Security=True;Connect Timeout=30
                //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MymemberDatabase.mdf;Integrated Security=True;Connect Timeout=30
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
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("已存在會員名稱");
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
                
                if (UsernameTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("請輸入會員名稱");
                    return;
                }
                else if (PasswordTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("請輸入密碼");
                    return;
                }

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
                        Frmmain f = new Frmmain();
                        this.Hide();
                        f.ShowDialog();

                        System.Environment.Exit(0);
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
