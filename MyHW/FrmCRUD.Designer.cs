
namespace MyHW
{
    partial class FrmCRUD
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
            System.Windows.Forms.Label photoIdLabel;
            System.Windows.Forms.Label cityIDLabel;
            System.Windows.Forms.Label photoNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label cityIDLabel1;
            System.Windows.Forms.Label cityNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUD));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cityIDTextBox1 = new System.Windows.Forms.TextBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mytripDataSet = new MyHW.MytripDataSet();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoIdTextBox = new System.Windows.Forms.TextBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityIDTextBox = new System.Windows.Forms.TextBox();
            this.photoNameTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.photoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.photoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.photoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoTableAdapter = new MyHW.MytripDataSetTableAdapters.PhotoTableAdapter();
            this.tableAdapterManager = new MyHW.MytripDataSetTableAdapters.TableAdapterManager();
            this.cityTableAdapter = new MyHW.MytripDataSetTableAdapters.CityTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            photoIdLabel = new System.Windows.Forms.Label();
            cityIDLabel = new System.Windows.Forms.Label();
            photoNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            cityIDLabel1 = new System.Windows.Forms.Label();
            cityNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mytripDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingNavigator)).BeginInit();
            this.photoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // photoIdLabel
            // 
            photoIdLabel.AutoSize = true;
            photoIdLabel.Location = new System.Drawing.Point(10, 42);
            photoIdLabel.Name = "photoIdLabel";
            photoIdLabel.Size = new System.Drawing.Size(60, 15);
            photoIdLabel.TabIndex = 2;
            photoIdLabel.Text = "Photo Id:";
            // 
            // cityIDLabel
            // 
            cityIDLabel.AutoSize = true;
            cityIDLabel.Location = new System.Drawing.Point(10, 73);
            cityIDLabel.Name = "cityIDLabel";
            cityIDLabel.Size = new System.Drawing.Size(54, 15);
            cityIDLabel.TabIndex = 4;
            cityIDLabel.Text = "City ID:";
            // 
            // photoNameLabel
            // 
            photoNameLabel.AutoSize = true;
            photoNameLabel.Location = new System.Drawing.Point(10, 104);
            photoNameLabel.Name = "photoNameLabel";
            photoNameLabel.Size = new System.Drawing.Size(81, 15);
            photoNameLabel.TabIndex = 6;
            photoNameLabel.Text = "Photo Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(10, 140);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(76, 15);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(10, 172);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(37, 15);
            dateLabel.TabIndex = 12;
            dateLabel.Text = "Date:";
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Location = new System.Drawing.Point(12, 104);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(54, 15);
            cityIDLabel1.TabIndex = 1;
            cityIDLabel1.Text = "City ID:";
            // 
            // cityNameLabel
            // 
            cityNameLabel.AutoSize = true;
            cityNameLabel.Location = new System.Drawing.Point(12, 135);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new System.Drawing.Size(72, 15);
            cityNameLabel.TabIndex = 3;
            cityNameLabel.Text = "City Name:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(cityIDLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.cityIDTextBox1);
            this.splitContainer1.Panel1.Controls.Add(cityNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.cityNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.cityDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(photoIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.photoIdTextBox);
            this.splitContainer1.Panel2.Controls.Add(cityIDLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cityIDTextBox);
            this.splitContainer1.Panel2.Controls.Add(photoNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.photoNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.photoPictureBox);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(dateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.dateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.photoBindingNavigator);
            this.splitContainer1.Panel2.Controls.Add(this.photoDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1188, 563);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 0;
            // 
            // cityIDTextBox1
            // 
            this.cityIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityID", true));
            this.cityIDTextBox1.Location = new System.Drawing.Point(90, 101);
            this.cityIDTextBox1.Name = "cityIDTextBox1";
            this.cityIDTextBox1.Size = new System.Drawing.Size(100, 25);
            this.cityIDTextBox1.TabIndex = 2;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.mytripDataSet;
            // 
            // mytripDataSet
            // 
            this.mytripDataSet.DataSetName = "MytripDataSet";
            this.mytripDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityName", true));
            this.cityNameTextBox.Location = new System.Drawing.Point(90, 132);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.cityNameTextBox.TabIndex = 4;
            // 
            // cityDataGridView
            // 
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(12, 226);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.RowHeadersWidth = 51;
            this.cityDataGridView.RowTemplate.Height = 27;
            this.cityDataGridView.Size = new System.Drawing.Size(300, 220);
            this.cityDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CityName";
            this.dataGridViewTextBoxColumn7.HeaderText = "CityName";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // photoIdTextBox
            // 
            this.photoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "PhotoId", true));
            this.photoIdTextBox.Location = new System.Drawing.Point(97, 39);
            this.photoIdTextBox.Name = "photoIdTextBox";
            this.photoIdTextBox.Size = new System.Drawing.Size(200, 25);
            this.photoIdTextBox.TabIndex = 3;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataMember = "Photo";
            this.photoBindingSource.DataSource = this.mytripDataSet;
            // 
            // cityIDTextBox
            // 
            this.cityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "CityID", true));
            this.cityIDTextBox.Location = new System.Drawing.Point(97, 70);
            this.cityIDTextBox.Name = "cityIDTextBox";
            this.cityIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.cityIDTextBox.TabIndex = 5;
            // 
            // photoNameTextBox
            // 
            this.photoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "PhotoName", true));
            this.photoNameTextBox.Location = new System.Drawing.Point(97, 101);
            this.photoNameTextBox.Name = "photoNameTextBox";
            this.photoNameTextBox.Size = new System.Drawing.Size(200, 25);
            this.photoNameTextBox.TabIndex = 7;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(321, 39);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(480, 255);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 9;
            this.photoPictureBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(97, 137);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 25);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.photoBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(97, 168);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateDateTimePicker.TabIndex = 13;
            // 
            // photoBindingNavigator
            // 
            this.photoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.photoBindingNavigator.BindingSource = this.photoBindingSource;
            this.photoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.photoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.photoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.photoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.photoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.photoBindingNavigatorSaveItem});
            this.photoBindingNavigator.Location = new System.Drawing.Point(3, 9);
            this.photoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.photoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.photoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.photoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.photoBindingNavigator.Name = "photoBindingNavigator";
            this.photoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.photoBindingNavigator.Size = new System.Drawing.Size(320, 27);
            this.photoBindingNavigator.TabIndex = 1;
            this.photoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // photoBindingNavigatorSaveItem
            // 
            this.photoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.photoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("photoBindingNavigatorSaveItem.Image")));
            this.photoBindingNavigatorSaveItem.Name = "photoBindingNavigatorSaveItem";
            this.photoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.photoBindingNavigatorSaveItem.Text = "儲存資料";
            this.photoBindingNavigatorSaveItem.Click += new System.EventHandler(this.photoBindingNavigatorSaveItem_Click);
            // 
            // photoDataGridView
            // 
            this.photoDataGridView.AutoGenerateColumns = false;
            this.photoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.photoDataGridView.DataSource = this.photoBindingSource;
            this.photoDataGridView.Location = new System.Drawing.Point(3, 299);
            this.photoDataGridView.Name = "photoDataGridView";
            this.photoDataGridView.RowHeadersWidth = 51;
            this.photoDataGridView.RowTemplate.Height = 40;
            this.photoDataGridView.Size = new System.Drawing.Size(789, 294);
            this.photoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PhotoId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PhotoId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhotoName";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhotoName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Photo";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // photoTableAdapter
            // 
            this.photoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.PhotoTableAdapter = this.photoTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyHW.MytripDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 66);
            this.button1.TabIndex = 14;
            this.button1.Text = "Browse....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 563);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmCRUD";
            this.Text = "FrmCRUD";
            this.Load += new System.EventHandler(this.FrmCRUD_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mytripDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingNavigator)).EndInit();
            this.photoBindingNavigator.ResumeLayout(false);
            this.photoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MytripDataSet mytripDataSet;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private MytripDataSetTableAdapters.PhotoTableAdapter photoTableAdapter;
        private MytripDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator photoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton photoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox photoIdTextBox;
        private System.Windows.Forms.TextBox cityIDTextBox;
        private System.Windows.Forms.TextBox photoNameTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DataGridView photoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MytripDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.TextBox cityIDTextBox1;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}