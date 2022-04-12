
namespace MyHW
{
    partial class MyHWForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyHWForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.txtBoxNum3 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(144, 38);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 34);
            this.txtNumber.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(103, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "☝Odd or Even";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.ReColor);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(35, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Linen;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblResult.Location = new System.Drawing.Point(171, 469);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(71, 36);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "結果";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 87);
            this.button2.TabIndex = 5;
            this.button2.Text = "a = 55 b=150  c=50\r\n三個數字中的最大值\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.ReColor);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(363, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "九九乘法表";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.ReColor);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(363, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 60);
            this.button4.TabIndex = 7;
            this.button4.Text = "100的二進制是多少?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.ReColor);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(537, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(328, 45);
            this.button5.TabIndex = 8;
            this.button5.Text = "int[] 統計 奇數 有幾個 , 偶數有幾個";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseLeave += new System.EventHandler(this.ReColor);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(537, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 45);
            this.button6.TabIndex = 9;
            this.button6.Text = "string[] 最長名字 ?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseLeave += new System.EventHandler(this.ReColor);
            this.button6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(537, 218);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(209, 79);
            this.button7.TabIndex = 10;
            this.button7.Text = "string[] 名字有 “C” or “c” 字樣有幾個 ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseLeave += new System.EventHandler(this.ReColor);
            this.button7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(880, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(209, 45);
            this.button8.TabIndex = 11;
            this.button8.Text = "Max (params int[] )";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseLeave += new System.EventHandler(this.ReColor);
            this.button8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(880, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(218, 45);
            this.button9.TabIndex = 12;
            this.button9.Text = " MAX()   / Min ( int[] )";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button9.MouseLeave += new System.EventHandler(this.ReColor);
            this.button9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(880, 218);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(238, 66);
            this.button10.TabIndex = 13;
            this.button10.Text = "int[] 樂透 6個號碼不重複";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button10.MouseLeave += new System.EventHandler(this.ReColor);
            this.button10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Step:";
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(129, 259);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(100, 34);
            this.txtBoxNum1.TabIndex = 17;
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Location = new System.Drawing.Point(129, 301);
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.Size = new System.Drawing.Size(100, 34);
            this.txtBoxNum2.TabIndex = 18;
            // 
            // txtBoxNum3
            // 
            this.txtBoxNum3.Location = new System.Drawing.Point(129, 344);
            this.txtBoxNum3.Name = "txtBoxNum3";
            this.txtBoxNum3.Size = new System.Drawing.Size(100, 34);
            this.txtBoxNum3.TabIndex = 19;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Khaki;
            this.button11.Location = new System.Drawing.Point(235, 259);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(77, 34);
            this.button11.TabIndex = 20;
            this.button11.Tag = "1";
            this.button11.Text = "For";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Khaki;
            this.button12.Location = new System.Drawing.Point(235, 299);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(77, 34);
            this.button12.TabIndex = 21;
            this.button12.Tag = "";
            this.button12.Text = "While";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Khaki;
            this.button13.Location = new System.Drawing.Point(235, 344);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(77, 34);
            this.button13.TabIndex = 22;
            this.button13.Tag = "";
            this.button13.Text = "Do";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.Location = new System.Drawing.Point(43, 411);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(152, 45);
            this.button14.TabIndex = 23;
            this.button14.Text = "清空結果欄";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            this.button14.MouseLeave += new System.EventHandler(this.ReColor);
            this.button14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // MyHWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 583);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.txtBoxNum3);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1140, 630);
            this.Name = "MyHWForm";
            this.Text = "MyHWForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxNum1;
        private System.Windows.Forms.TextBox txtBoxNum2;
        private System.Windows.Forms.TextBox txtBoxNum3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

