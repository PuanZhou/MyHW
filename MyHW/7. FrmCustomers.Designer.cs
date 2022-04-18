
namespace MyHW
{
    partial class FrmCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerIDAscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerIdDescToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ImageList2;
            this.listView1.Location = new System.Drawing.Point(12, 98);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1114, 398);
            this.listView1.SmallImageList = this.ImageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.orderByToolStripMenuItem,
            this.groupByToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 124);
            // 
            // detToolStripMenuItem
            // 
            this.detToolStripMenuItem.Name = "detToolStripMenuItem";
            this.detToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.detToolStripMenuItem.Text = "Details View";
            this.detToolStripMenuItem.Click += new System.EventHandler(this.detToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDAscToolStripMenuItem,
            this.customerIdDescToolStripMenuItem});
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.orderByToolStripMenuItem.Text = "Order by";
            // 
            // customerIDAscToolStripMenuItem
            // 
            this.customerIDAscToolStripMenuItem.Name = "customerIDAscToolStripMenuItem";
            this.customerIDAscToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customerIDAscToolStripMenuItem.Text = "CustomerID Asc";
            this.customerIDAscToolStripMenuItem.Click += new System.EventHandler(this.customerIDAscToolStripMenuItem_Click);
            // 
            // customerIdDescToolStripMenuItem
            // 
            this.customerIdDescToolStripMenuItem.Name = "customerIdDescToolStripMenuItem";
            this.customerIdDescToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customerIdDescToolStripMenuItem.Text = "CustomerId Desc";
            this.customerIdDescToolStripMenuItem.Click += new System.EventHandler(this.customerIdDescToolStripMenuItem_Click);
            // 
            // groupByToolStripMenuItem
            // 
            this.groupByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.groupByToolStripMenuItem.Name = "groupByToolStripMenuItem";
            this.groupByToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.groupByToolStripMenuItem.Text = "Group by";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "argentina32.png");
            this.ImageList2.Images.SetKeyName(1, "austria32.png");
            this.ImageList2.Images.SetKeyName(2, "belgium32.png");
            this.ImageList2.Images.SetKeyName(3, "brazil32.png");
            this.ImageList2.Images.SetKeyName(4, "canada32.png");
            this.ImageList2.Images.SetKeyName(5, "denmark32.png");
            this.ImageList2.Images.SetKeyName(6, "finland32.png");
            this.ImageList2.Images.SetKeyName(7, "france32.png");
            this.ImageList2.Images.SetKeyName(8, "germany32.png");
            this.ImageList2.Images.SetKeyName(9, "ireland32.png");
            this.ImageList2.Images.SetKeyName(10, "italy32.png");
            this.ImageList2.Images.SetKeyName(11, "mexico32.png");
            this.ImageList2.Images.SetKeyName(12, "norway32.png");
            this.ImageList2.Images.SetKeyName(13, "poland32.png");
            this.ImageList2.Images.SetKeyName(14, "portugal32.png");
            this.ImageList2.Images.SetKeyName(15, "spain32.png");
            this.ImageList2.Images.SetKeyName(16, "sweden32.png");
            this.ImageList2.Images.SetKeyName(17, "switzerland32.png");
            this.ImageList2.Images.SetKeyName(18, "united-kingdom32.png");
            this.ImageList2.Images.SetKeyName(19, "united-states32.png");
            this.ImageList2.Images.SetKeyName(20, "venezuela32.png");
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "argentina16.png");
            this.ImageList1.Images.SetKeyName(1, "austria16.png");
            this.ImageList1.Images.SetKeyName(2, "belgium16.png");
            this.ImageList1.Images.SetKeyName(3, "brazil16.png");
            this.ImageList1.Images.SetKeyName(4, "canada16.png");
            this.ImageList1.Images.SetKeyName(5, "denmark16.png");
            this.ImageList1.Images.SetKeyName(6, "finland16.png");
            this.ImageList1.Images.SetKeyName(7, "france16.png");
            this.ImageList1.Images.SetKeyName(8, "germany16.png");
            this.ImageList1.Images.SetKeyName(9, "ireland16.png");
            this.ImageList1.Images.SetKeyName(10, "italy16.png");
            this.ImageList1.Images.SetKeyName(11, "mexico16.png");
            this.ImageList1.Images.SetKeyName(12, "norway16.png");
            this.ImageList1.Images.SetKeyName(13, "poland16.png");
            this.ImageList1.Images.SetKeyName(14, "portugal16.png");
            this.ImageList1.Images.SetKeyName(15, "spain16.png");
            this.ImageList1.Images.SetKeyName(16, "sweden16.png");
            this.ImageList1.Images.SetKeyName(17, "switzerland16.png");
            this.ImageList1.Images.SetKeyName(18, "united-kingdom16.png");
            this.ImageList1.Images.SetKeyName(19, "united-states16.png");
            this.ImageList1.Images.SetKeyName(20, "venezuela16.png");
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1138, 508);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.ImageList ImageList2;
        internal System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerIDAscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerIdDescToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
    }
}