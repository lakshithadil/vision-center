
namespace vision_center1
{
    partial class Orderline
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
            System.Windows.Forms.Label oIDLabel1;
            System.Windows.Forms.Label pIDLabel1;
            System.Windows.Forms.Label used_forLabel1;
            System.Windows.Forms.Label quantityLabel1;
            System.Windows.Forms.Label sub_totalLabel2;
            System.Windows.Forms.Label pIDLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label qtyInStockLabel;
            System.Windows.Forms.Label date_fromLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orderline));
            this.visionCenterDataSet = new vision_center1.VisionCenterDataSet();
            this.oRDERLINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERLINETableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.ORDERLINETableAdapter();
            this.tableAdapterManager = new vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager();
            this.oRDERLINEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oRDERLINEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.oIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.used_forComboBox1 = new System.Windows.Forms.ComboBox();
            this.quantityTextBox1 = new System.Windows.Forms.TextBox();
            oIDLabel1 = new System.Windows.Forms.Label();
            pIDLabel1 = new System.Windows.Forms.Label();
            used_forLabel1 = new System.Windows.Forms.Label();
            quantityLabel1 = new System.Windows.Forms.Label();
            sub_totalLabel2 = new System.Windows.Forms.Label();
            pIDLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            qtyInStockLabel = new System.Windows.Forms.Label();
            date_fromLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINEBindingNavigator)).BeginInit();
            this.oRDERLINEBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // oIDLabel1
            // 
            oIDLabel1.AutoSize = true;
            oIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            oIDLabel1.Location = new System.Drawing.Point(53, 92);
            oIDLabel1.Name = "oIDLabel1";
            oIDLabel1.Size = new System.Drawing.Size(139, 20);
            oIDLabel1.TabIndex = 11;
            oIDLabel1.Text = "Order ID            :";
            // 
            // pIDLabel1
            // 
            pIDLabel1.AutoSize = true;
            pIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pIDLabel1.Location = new System.Drawing.Point(53, 149);
            pIDLabel1.Name = "pIDLabel1";
            pIDLabel1.Size = new System.Drawing.Size(139, 20);
            pIDLabel1.TabIndex = 13;
            pIDLabel1.Text = "Product ID         :";
            // 
            // used_forLabel1
            // 
            used_forLabel1.AutoSize = true;
            used_forLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            used_forLabel1.Location = new System.Drawing.Point(53, 208);
            used_forLabel1.Name = "used_forLabel1";
            used_forLabel1.Size = new System.Drawing.Size(138, 20);
            used_forLabel1.TabIndex = 15;
            used_forLabel1.Text = "Used for            :";
            // 
            // quantityLabel1
            // 
            quantityLabel1.AutoSize = true;
            quantityLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel1.Location = new System.Drawing.Point(53, 265);
            quantityLabel1.Name = "quantityLabel1";
            quantityLabel1.Size = new System.Drawing.Size(141, 20);
            quantityLabel1.TabIndex = 17;
            quantityLabel1.Text = "Quantity             :";
            // 
            // sub_totalLabel2
            // 
            sub_totalLabel2.AutoSize = true;
            sub_totalLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sub_totalLabel2.Location = new System.Drawing.Point(54, 317);
            sub_totalLabel2.Name = "sub_totalLabel2";
            sub_totalLabel2.Size = new System.Drawing.Size(140, 20);
            sub_totalLabel2.TabIndex = 19;
            sub_totalLabel2.Text = "Sub total(LKR)   :";
            // 
            // pIDLabel
            // 
            pIDLabel.AutoSize = true;
            pIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pIDLabel.Location = new System.Drawing.Point(499, 139);
            pIDLabel.Name = "pIDLabel";
            pIDLabel.Size = new System.Drawing.Size(154, 20);
            pIDLabel.TabIndex = 21;
            pIDLabel.Text = "Product ID            :";
            pIDLabel.Click += new System.EventHandler(this.pIDLabel_Click);
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(499, 167);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(156, 20);
            categoryLabel.TabIndex = 23;
            categoryLabel.Text = "Category               :";
            categoryLabel.Click += new System.EventHandler(this.categoryLabel_Click);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(499, 198);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(155, 20);
            descriptionLabel.TabIndex = 25;
            descriptionLabel.Text = "Description           :";
            descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unit_priceLabel.Location = new System.Drawing.Point(499, 226);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(156, 20);
            unit_priceLabel.TabIndex = 27;
            unit_priceLabel.Text = "Unit price (LKR)    :";
            unit_priceLabel.Click += new System.EventHandler(this.unit_priceLabel_Click);
            // 
            // qtyInStockLabel
            // 
            qtyInStockLabel.AutoSize = true;
            qtyInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyInStockLabel.Location = new System.Drawing.Point(499, 254);
            qtyInStockLabel.Name = "qtyInStockLabel";
            qtyInStockLabel.Size = new System.Drawing.Size(155, 20);
            qtyInStockLabel.TabIndex = 29;
            qtyInStockLabel.Text = "Qty In Stock          :";
            qtyInStockLabel.Click += new System.EventHandler(this.qtyInStockLabel_Click);
            // 
            // date_fromLabel
            // 
            date_fromLabel.AutoSize = true;
            date_fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_fromLabel.Location = new System.Drawing.Point(499, 283);
            date_fromLabel.Name = "date_fromLabel";
            date_fromLabel.Size = new System.Drawing.Size(154, 20);
            date_fromLabel.TabIndex = 31;
            date_fromLabel.Text = "Date from             :";
            date_fromLabel.Click += new System.EventHandler(this.date_fromLabel_Click);
            // 
            // visionCenterDataSet
            // 
            this.visionCenterDataSet.DataSetName = "VisionCenterDataSet";
            this.visionCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDERLINEBindingSource
            // 
            this.oRDERLINEBindingSource.DataMember = "ORDERLINE";
            this.oRDERLINEBindingSource.DataSource = this.visionCenterDataSet;
            // 
            // oRDERLINETableAdapter
            // 
            this.oRDERLINETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.FRAMETableAdapter = null;
            this.tableAdapterManager.LENSETableAdapter = null;
            this.tableAdapterManager.ORDERLINETableAdapter = this.oRDERLINETableAdapter;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oRDERLINEBindingNavigator
            // 
            this.oRDERLINEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oRDERLINEBindingNavigator.BindingSource = this.oRDERLINEBindingSource;
            this.oRDERLINEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oRDERLINEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oRDERLINEBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.oRDERLINEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.oRDERLINEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oRDERLINEBindingNavigatorSaveItem});
            this.oRDERLINEBindingNavigator.Location = new System.Drawing.Point(374, 11);
            this.oRDERLINEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oRDERLINEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oRDERLINEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oRDERLINEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oRDERLINEBindingNavigator.Name = "oRDERLINEBindingNavigator";
            this.oRDERLINEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oRDERLINEBindingNavigator.Size = new System.Drawing.Size(370, 27);
            this.oRDERLINEBindingNavigator.TabIndex = 0;
            this.oRDERLINEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // oRDERLINEBindingNavigatorSaveItem
            // 
            this.oRDERLINEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oRDERLINEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oRDERLINEBindingNavigatorSaveItem.Image")));
            this.oRDERLINEBindingNavigatorSaveItem.Name = "oRDERLINEBindingNavigatorSaveItem";
            this.oRDERLINEBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.oRDERLINEBindingNavigatorSaveItem.Text = "Save Data";
            this.oRDERLINEBindingNavigatorSaveItem.Click += new System.EventHandler(this.oRDERLINEBindingNavigatorSaveItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 553);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(pIDLabel);
            this.panel2.Controls.Add(categoryLabel);
            this.panel2.Controls.Add(descriptionLabel);
            this.panel2.Controls.Add(unit_priceLabel);
            this.panel2.Controls.Add(qtyInStockLabel);
            this.panel2.Controls.Add(date_fromLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(oIDLabel1);
            this.panel2.Controls.Add(this.oIDMaskedTextBox);
            this.panel2.Controls.Add(pIDLabel1);
            this.panel2.Controls.Add(this.pIDMaskedTextBox);
            this.panel2.Controls.Add(used_forLabel1);
            this.panel2.Controls.Add(this.used_forComboBox1);
            this.panel2.Controls.Add(quantityLabel1);
            this.panel2.Controls.Add(this.quantityTextBox1);
            this.panel2.Controls.Add(sub_totalLabel2);
            this.panel2.Controls.Add(this.oRDERLINEBindingNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 553);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(821, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 40);
            this.button3.TabIndex = 42;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(215, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(57, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(396, 37);
            this.button2.TabIndex = 40;
            this.button2.Text = "Add more products";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "SELECTED PRODUCT DETAILS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 29);
            this.label7.TabIndex = 38;
            this.label7.Text = "ENTER ORDERLINE DETAILS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(661, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 37;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(661, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 36;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 35;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 34;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 33;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(661, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 32;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add to cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oIDMaskedTextBox
            // 
            this.oIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERLINEBindingSource, "OID", true));
            this.oIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oIDMaskedTextBox.Location = new System.Drawing.Point(219, 92);
            this.oIDMaskedTextBox.Name = "oIDMaskedTextBox";
            this.oIDMaskedTextBox.Size = new System.Drawing.Size(234, 27);
            this.oIDMaskedTextBox.TabIndex = 12;
            // 
            // pIDMaskedTextBox
            // 
            this.pIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERLINEBindingSource, "PID", true));
            this.pIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDMaskedTextBox.Location = new System.Drawing.Point(219, 149);
            this.pIDMaskedTextBox.Name = "pIDMaskedTextBox";
            this.pIDMaskedTextBox.Size = new System.Drawing.Size(234, 27);
            this.pIDMaskedTextBox.TabIndex = 14;
            this.pIDMaskedTextBox.TextChanged += new System.EventHandler(this.pIDMaskedTextBox_TextChanged);
            // 
            // used_forComboBox1
            // 
            this.used_forComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERLINEBindingSource, "Used for", true));
            this.used_forComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.used_forComboBox1.FormattingEnabled = true;
            this.used_forComboBox1.Items.AddRange(new object[] {
            "SPECTACLE",
            "SUNGLASS",
            "ACCESSORIES",
            "REPAIR"});
            this.used_forComboBox1.Location = new System.Drawing.Point(219, 210);
            this.used_forComboBox1.Name = "used_forComboBox1";
            this.used_forComboBox1.Size = new System.Drawing.Size(234, 28);
            this.used_forComboBox1.TabIndex = 16;
            // 
            // quantityTextBox1
            // 
            this.quantityTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERLINEBindingSource, "Quantity", true));
            this.quantityTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox1.Location = new System.Drawing.Point(219, 265);
            this.quantityTextBox1.Name = "quantityTextBox1";
            this.quantityTextBox1.Size = new System.Drawing.Size(234, 27);
            this.quantityTextBox1.TabIndex = 18;
            // 
            // Orderline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Name = "Orderline";
            this.Text = "Orderline";
            this.Load += new System.EventHandler(this.Orderline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINEBindingNavigator)).EndInit();
            this.oRDERLINEBindingNavigator.ResumeLayout(false);
            this.oRDERLINEBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VisionCenterDataSet visionCenterDataSet;
        private System.Windows.Forms.BindingSource oRDERLINEBindingSource;
        private VisionCenterDataSetTableAdapters.ORDERLINETableAdapter oRDERLINETableAdapter;
        private VisionCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oRDERLINEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oRDERLINEBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox oIDMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox pIDMaskedTextBox;
        private System.Windows.Forms.ComboBox used_forComboBox1;
        private System.Windows.Forms.TextBox quantityTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}