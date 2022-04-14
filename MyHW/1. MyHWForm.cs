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
    public partial class MyHWForm : Form
    {
        public MyHWForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oddorEven();
        }
        internal void oddorEven()
        {
            int num = 0;
            bool isNum = int.TryParse(txtNumber.Text, out num);
            if (isNum)
            {
                if (num % 2 == 0)
                {
                    MessageBox.Show(string.Format("{0}是偶數", num));
                }
                else
                {
                    MessageBox.Show(string.Format("{0}是奇數", num));
                }
            }
            else
            {
                MessageBox.Show("請輸入整數", "型別錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a = 55;
            int b = 150;
            int c = 10;
            largest(a, b, c);
        }
        internal void largest(int a, int b, int c)
        {

            if (a < b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            if (b < c)
            {
                int tmp = b;
                b = c;
                c = tmp;
            }
            if (a < b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            lblResult.Text = (string.Format("最大值為: {0}", a));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            multiTable();
        }
        internal void multiTable()
        {
            lblResult.Text = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    if (i * j < 10)
                    {
                        lblResult.Text += string.Format("{0} x {1} =  {2}  ", j, i, j * i);
                    }
                    else
                    {
                        lblResult.Text += string.Format("{0} x {1} ={2}  ", j, i, j * i);
                    }
                }
                lblResult.Text += "\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimalToBinary();
        }

        internal void decimalToBinary()
        {
            int number;
            number = 100;
            int binaryNum = 0;
            string result = "";
            lblResult.Text = string.Format("{0},的二進制為:", number);
            while (number > 0)
            {
                binaryNum = number % 2;
                number /= 2;
                result = binaryNum.ToString() + result;
            }
            lblResult.Text += string.Format("{0}", result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            arrayOddorEven(nums);
        }
        internal void arrayOddorEven(int[] nums)
        {
            lblResult.Text = "int[] nums = { 33, 4, 5, 11, 222, 34 }";
            int even = 0, odd = 0;
            foreach (int item in nums)
            {
                if (item % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            lblResult.Text += string.Format("\nint[] nums中偶數共有{0}個,奇數共有{1}個", even, odd);
        }

        string[] names = { "Heinrich", "Hermann", "Jörg", "Michelle", "Nicole", "Christian", "Jürgen", "Günther", "Catrin" };
        private void button6_Click(object sender, EventArgs e)
        {
            longestName(names);
        }
        internal void longestName(string[] names)
        {
            lblResult.Text = " string[] names = { Heinrich, Hermann, Jörg, Michelle,\n Nicole, Christian, Jürgen, Günther, Catrin}";
            string lN = names[0];

            foreach (string item in names)
            {
                lN = lN.Length < item.Length ? item : lN;
            }

            lblResult.Text += string.Format("\nstring[] names中最長的名子是: {0}", lN);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CorC(names);
        }
        internal void CorC(string[] names)
        {
            lblResult.Text = " string[] names = { Heinrich, Hermann, Jörg, Michelle,\n Nicole, Christian, Jürgen, Günther, Catrin}";
            int count = 0;
            string check = "Cc";
            foreach (string item in names)
            {
                if (item.Any(check.Contains))
                {
                    count++;
                }
            }
            lblResult.Text += string.Format("\nstring[] names 中有C或c的字樣共有{0}個", count);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string scores = scoresMax("最大值為:", 2, 3, 46, 33, 22, 100, 150, 33, 55);
            lblResult.Text = string.Format("int[2, 3, 46, 33, 22, 100, 150, 33, 55] scores{0}", scores);
        }
        string scoresMax(string Max, params int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[i] < scores[j])
                    {
                        int tmp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = tmp;
                    }
                }
            }
            string result = Max + scores[0];
            return result;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };
            scoresMinMax(scores);
        }
        internal void scoresMinMax(int[] scores)
        {
            int min = scores[0];
            int max = scores[0];
            foreach (int item in scores)
            {
                min = min > item ? item : min;
                max = max < item ? item : max;
            }

            lblResult.Text = string.Format("int[2, 3, 46, 33, 22, 100, 150, 33, 55 ] scores中\n最大值為:{0}\n最小值為:{1}", max, min);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loto();
        }
        internal void loto()
        {
            Random rng = new Random(Guid.NewGuid().GetHashCode());
            int[] lotto = new int[49];
            int num = 1;

            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = num++;
            }


            for (int i = lotto.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                int tmp = lotto[i];
                lotto[i] = lotto[j];
                lotto[j] = tmp;
            }

            lblResult.Text = string.Format("本期大樂透號碼為{0},{1},{2},{3},{4},{5}", lotto[0], lotto[1], lotto[2], lotto[3], lotto[4], lotto[5]);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CheckNum("forLoop");
        }


        private void button12_Click(object sender, EventArgs e)
        {
            CheckNum("whileLoop");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CheckNum("doLoop");
        }

        internal void CheckNum(string type)
        {
            int num1 = 0, num2 = 0, num3 = 0;

            try
            {
                num1 = int.Parse(txtBoxNum1.Text);
                num2 = int.Parse(txtBoxNum2.Text);
                num3 = int.Parse(txtBoxNum3.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (num3 <= 0)
            {
                MessageBox.Show("Step請大於0", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (type == "forLoop")
            {
                forLoop(num1, num2, num3);
            }
            else if (type == "whileLoop")
            {
                whileLoop(num1, num2, num3);
            }
            else if (type == "doLoop")
            {
                doLoop(num1, num2, num3);
            }
        }
        internal void forLoop(int num1, int num2, int num3)
        {
            int sum = 0;
            for (int i = num1; i <= num2; i += num3)
            {
                sum += i;
            }
            lblResult.Text = string.Format("{0} 到 {1} 相隔 {2} \n加總為{3}", num1, num2, num3 - 1, sum);
        }
        internal void whileLoop(int num1, int num2, int num3)
        {
            int sum = 0;

            lblResult.Text = string.Format("{0} 到 {1} 相隔 {2}", num1, num2, num3 - 1);
            while (num1 <= num2)
            {
                sum += num1;
                num1 += num3;
            }
            lblResult.Text += string.Format("\n加總為{0}", sum);
        }
        internal void doLoop(int num1, int num2, int num3)
        {
            int sum = 0;
            lblResult.Text = string.Format("{0} 到 {1} 相隔 {2}", num1, num2, num3 - 1);
            do
            {
                sum += num1;
                num1 += num3;

            } while (num1 <= num2);
            lblResult.Text += string.Format("\n加總為{0}", sum);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果";
        }

        private void ChangeColor(object sender, MouseEventArgs e)
        {
            Button btn = new Button();
            btn = (Button)sender;
            btn.BackColor = Color.AliceBlue;
        }

        private void ReColor(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = (Button)sender;
            btn.BackColor = SystemColors.Control;
        }
    }
}
