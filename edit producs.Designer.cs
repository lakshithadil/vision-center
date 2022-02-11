
namespace vision_center1
{
    partial class edit_products
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
            System.Windows.Forms.Label pIDLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label qtyInStockLabel;
            System.Windows.Forms.Label date_fromLabel;
            System.Windows.Forms.Label pIDLabel1;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label made_byLabel;
            System.Windows.Forms.Label pIDLabel2;
            System.Windows.Forms.Label focal_typeLabel;
            System.Windows.Forms.Label made_byLabel1;
            System.Windows.Forms.Label powerLabel;
            System.Windows.Forms.Label photoGray_NormalLabel;
            System.Windows.Forms.Label other_featuresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_products));
            this.visionCenterDataSet = new vision_center1.VisionCenterDataSet();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.PRODUCTTableAdapter();
            this.tableAdapterManager = new vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager();
            this.fRAMETableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.FRAMETableAdapter();
            this.lENSETableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.LENSETableAdapter();
            this.pRODUCTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pRODUCTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.unit_priceTextBox = new System.Windows.Forms.TextBox();
            this.qtyInStockTextBox = new System.Windows.Forms.TextBox();
            this.date_fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fRAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIDMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.made_byComboBox = new System.Windows.Forms.ComboBox();
            this.lENSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIDMaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.focal_typeComboBox = new System.Windows.Forms.ComboBox();
            this.made_byComboBox1 = new System.Windows.Forms.ComboBox();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.photoGray_NormalComboBox = new System.Windows.Forms.ComboBox();
            this.other_featuresComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            pIDLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            qtyInStockLabel = new System.Windows.Forms.Label();
            date_fromLabel = new System.Windows.Forms.Label();
            pIDLabel1 = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            made_byLabel = new System.Windows.Forms.Label();
            pIDLabel2 = new System.Windows.Forms.Label();
            focal_typeLabel = new System.Windows.Forms.Label();
            made_byLabel1 = new System.Windows.Forms.Label();
            powerLabel = new System.Windows.Forms.Label();
            photoGray_NormalLabel = new System.Windows.Forms.Label();
            other_featuresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingNavigator)).BeginInit();
            this.pRODUCTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fRAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENSEBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pIDLabel
            // 
            pIDLabel.AutoSize = true;
            pIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pIDLabel.Location = new System.Drawing.Point(52, 147);
            pIDLabel.Name = "pIDLabel";
            pIDLabel.Size = new System.Drawing.Size(94, 20);
            pIDLabel.TabIndex = 1;
            pIDLabel.Text = "Product ID:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(52, 199);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(81, 20);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "Category:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(52, 250);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(100, 20);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unit_priceLabel.Location = new System.Drawing.Point(52, 297);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(136, 20);
            unit_priceLabel.TabIndex = 7;
            unit_priceLabel.Text = "Unit price (LKR):";
            // 
            // qtyInStockLabel
            // 
            qtyInStockLabel.AutoSize = true;
            qtyInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyInStockLabel.Location = new System.Drawing.Point(52, 350);
            qtyInStockLabel.Name = "qtyInStockLabel";
            qtyInStockLabel.Size = new System.Drawing.Size(105, 20);
            qtyInStockLabel.TabIndex = 9;
            qtyInStockLabel.Text = "Qty In Stock:";
            // 
            // date_fromLabel
            // 
            date_fromLabel.AutoSize = true;
            date_fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_fromLabel.Location = new System.Drawing.Point(52, 399);
            date_fromLabel.Name = "date_fromLabel";
            date_fromLabel.Size = new System.Drawing.Size(89, 20);
            date_fromLabel.TabIndex = 11;
            date_fromLabel.Text = "Date from:";
            // 
            // pIDLabel1
            // 
            pIDLabel1.AutoSize = true;
            pIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pIDLabel1.Location = new System.Drawing.Point(40, 52);
            pIDLabel1.Name = "pIDLabel1";
            pIDLabel1.Size = new System.Drawing.Size(89, 20);
            pIDLabel1.TabIndex = 13;
            pIDLabel1.Text = "ProductID:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeLabel.Location = new System.Drawing.Point(40, 92);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(50, 20);
            typeLabel.TabIndex = 15;
            typeLabel.Text = "Type:";
            // 
            // made_byLabel
            // 
            made_byLabel.AutoSize = true;
            made_byLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            made_byLabel.Location = new System.Drawing.Point(40, 138);
            made_byLabel.Name = "made_byLabel";
            made_byLabel.Size = new System.Drawing.Size(77, 20);
            made_byLabel.TabIndex = 17;
            made_byLabel.Text = "Made by:";
            // 
            // pIDLabel2
            // 
            pIDLabel2.AutoSize = true;
            pIDLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pIDLabel2.Location = new System.Drawing.Point(28, 56);
            pIDLabel2.Name = "pIDLabel2";
            pIDLabel2.Size = new System.Drawing.Size(94, 20);
            pIDLabel2.TabIndex = 19;
            pIDLabel2.Text = "Product ID:";
            // 
            // focal_typeLabel
            // 
            focal_typeLabel.AutoSize = true;
            focal_typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            focal_typeLabel.Location = new System.Drawing.Point(28, 99);
            focal_typeLabel.Name = "focal_typeLabel";
            focal_typeLabel.Size = new System.Drawing.Size(91, 20);
            focal_typeLabel.TabIndex = 21;
            focal_typeLabel.Text = "Focal type:";
            // 
            // made_byLabel1
            // 
            made_byLabel1.AutoSize = true;
            made_byLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            made_byLabel1.Location = new System.Drawing.Point(28, 147);
            made_byLabel1.Name = "made_byLabel1";
            made_byLabel1.Size = new System.Drawing.Size(77, 20);
            made_byLabel1.TabIndex = 23;
            made_byLabel1.Text = "Made by:";
            // 
            // powerLabel
            // 
            powerLabel.AutoSize = true;
            powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            powerLabel.Location = new System.Drawing.Point(28, 198);
            powerLabel.Name = "powerLabel";
            powerLabel.Size = new System.Drawing.Size(61, 20);
            powerLabel.TabIndex = 25;
            powerLabel.Text = "Power:";
            // 
            // photoGray_NormalLabel
            // 
            photoGray_NormalLabel.AutoSize = true;
            photoGray_NormalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            photoGray_NormalLabel.Location = new System.Drawing.Point(28, 246);
            photoGray_NormalLabel.Name = "photoGray_NormalLabel";
            photoGray_NormalLabel.Size = new System.Drawing.Size(157, 20);
            photoGray_NormalLabel.TabIndex = 27;
            photoGray_NormalLabel.Text = "Photo Gray/Normal:";
            // 
            // other_featuresLabel
            // 
            other_featuresLabel.AutoSize = true;
            other_featuresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            other_featuresLabel.Location = new System.Drawing.Point(28, 288);
            other_featuresLabel.Name = "other_featuresLabel";
            other_featuresLabel.Size = new System.Drawing.Size(122, 20);
            other_featuresLabel.TabIndex = 29;
            other_featuresLabel.Text = "Other features:";
            // 
            // visionCenterDataSet
            // 
            this.visionCenterDataSet.DataSetName = "VisionCenterDataSet";
            this.visionCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.visionCenterDataSet;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.FRAMETableAdapter = this.fRAMETableAdapter;
            this.tableAdapterManager.LENSETableAdapter = this.lENSETableAdapter;
            this.tableAdapterManager.ORDERLINETableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = this.pRODUCTTableAdapter;
            this.tableAdapterManager.TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // fRAMETableAdapter
            // 
            this.fRAMETableAdapter.ClearBeforeFill = true;
            // 
            // lENSETableAdapter
            // 
            this.lENSETableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTBindingNavigator
            // 
            this.pRODUCTBindingNavigator.AddNewItem = null;
            this.pRODUCTBindingNavigator.BindingSource = this.pRODUCTBindingSource;
            this.pRODUCTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pRODUCTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pRODUCTBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pRODUCTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.pRODUCTBindingNavigatorSaveItem});
            this.pRODUCTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pRODUCTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pRODUCTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pRODUCTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pRODUCTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pRODUCTBindingNavigator.Name = "pRODUCTBindingNavigator";
            this.pRODUCTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pRODUCTBindingNavigator.Size = new System.Drawing.Size(982, 31);
            this.pRODUCTBindingNavigator.TabIndex = 0;
            this.pRODUCTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // pRODUCTBindingNavigatorSaveItem
            // 
            this.pRODUCTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUCTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUCTBindingNavigatorSaveItem.Image")));
            this.pRODUCTBindingNavigatorSaveItem.Name = "pRODUCTBindingNavigatorSaveItem";
            this.pRODUCTBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.pRODUCTBindingNavigatorSaveItem.Text = "Save Data";
            this.pRODUCTBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRODUCTBindingNavigatorSaveItem_Click);
            // 
            // pIDMaskedTextBox
            // 
            this.pIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "PID", true));
            this.pIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDMaskedTextBox.Location = new System.Drawing.Point(235, 144);
            this.pIDMaskedTextBox.Name = "pIDMaskedTextBox";
            this.pIDMaskedTextBox.Size = new System.Drawing.Size(309, 27);
            this.pIDMaskedTextBox.TabIndex = 2;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Category", true));
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "lenses",
            "frames",
            "accessories",
            "sunglasses",
            "repairparts"});
            this.categoryComboBox.Location = new System.Drawing.Point(235, 196);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(309, 28);
            this.categoryComboBox.TabIndex = 4;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            this.categoryComboBox.SelectedValueChanged += new System.EventHandler(this.categoryComboBox_SelectedValueChanged);
            this.categoryComboBox.TextChanged += new System.EventHandler(this.categoryComboBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(235, 247);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(309, 27);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // unit_priceTextBox
            // 
            this.unit_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Unit price", true));
            this.unit_priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_priceTextBox.Location = new System.Drawing.Point(235, 294);
            this.unit_priceTextBox.Name = "unit_priceTextBox";
            this.unit_priceTextBox.Size = new System.Drawing.Size(309, 27);
            this.unit_priceTextBox.TabIndex = 8;
            // 
            // qtyInStockTextBox
            // 
            this.qtyInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "QtyInStock", true));
            this.qtyInStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyInStockTextBox.Location = new System.Drawing.Point(235, 347);
            this.qtyInStockTextBox.Name = "qtyInStockTextBox";
            this.qtyInStockTextBox.Size = new System.Drawing.Size(309, 27);
            this.qtyInStockTextBox.TabIndex = 10;
            // 
            // date_fromDateTimePicker
            // 
            this.date_fromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pRODUCTBindingSource, "Date from", true));
            this.date_fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fromDateTimePicker.Location = new System.Drawing.Point(235, 395);
            this.date_fromDateTimePicker.Name = "date_fromDateTimePicker";
            this.date_fromDateTimePicker.Size = new System.Drawing.Size(309, 27);
            this.date_fromDateTimePicker.TabIndex = 12;
            // 
            // fRAMEBindingSource
            // 
            this.fRAMEBindingSource.DataMember = "FK_FRAME_PRODUCT";
            this.fRAMEBindingSource.DataSource = this.pRODUCTBindingSource;
            // 
            // pIDMaskedTextBox1
            // 
            this.pIDMaskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fRAMEBindingSource, "PID", true));
            this.pIDMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDMaskedTextBox1.Location = new System.Drawing.Point(201, 45);
            this.pIDMaskedTextBox1.Name = "pIDMaskedTextBox1";
            this.pIDMaskedTextBox1.Size = new System.Drawing.Size(164, 27);
            this.pIDMaskedTextBox1.TabIndex = 14;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fRAMEBindingSource, "Type", true));
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "HALF",
            "FULL"});
            this.typeComboBox.Location = new System.Drawing.Point(201, 85);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(164, 28);
            this.typeComboBox.TabIndex = 16;
            // 
            // made_byComboBox
            // 
            this.made_byComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fRAMEBindingSource, "Made by", true));
            this.made_byComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.made_byComboBox.FormattingEnabled = true;
            this.made_byComboBox.Items.AddRange(new object[] {
            "METAL",
            "COMBINED METALPLASTIC",
            "TR90 PLASTIC",
            "NORMAL PLASTIC"});
            this.made_byComboBox.Location = new System.Drawing.Point(201, 131);
            this.made_byComboBox.Name = "made_byComboBox";
            this.made_byComboBox.Size = new System.Drawing.Size(164, 28);
            this.made_byComboBox.TabIndex = 18;
            // 
            // lENSEBindingSource
            // 
            this.lENSEBindingSource.DataMember = "FK_LENSE_PRODUCT";
            this.lENSEBindingSource.DataSource = this.pRODUCTBindingSource;
            // 
            // pIDMaskedTextBox2
            // 
            this.pIDMaskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "PID", true));
            this.pIDMaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDMaskedTextBox2.Location = new System.Drawing.Point(201, 53);
            this.pIDMaskedTextBox2.Name = "pIDMaskedTextBox2";
            this.pIDMaskedTextBox2.Size = new System.Drawing.Size(164, 27);
            this.pIDMaskedTextBox2.TabIndex = 20;
            // 
            // focal_typeComboBox
            // 
            this.focal_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "Focal type", true));
            this.focal_typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focal_typeComboBox.FormattingEnabled = true;
            this.focal_typeComboBox.Items.AddRange(new object[] {
            "SINGLE VISION",
            "ROUNDED BIFOCAL",
            "FLAT TOP BIFOCAL",
            "VARIFOCAL"});
            this.focal_typeComboBox.Location = new System.Drawing.Point(201, 96);
            this.focal_typeComboBox.Name = "focal_typeComboBox";
            this.focal_typeComboBox.Size = new System.Drawing.Size(164, 28);
            this.focal_typeComboBox.TabIndex = 22;
            // 
            // made_byComboBox1
            // 
            this.made_byComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "Made by", true));
            this.made_byComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.made_byComboBox1.FormattingEnabled = true;
            this.made_byComboBox1.Items.AddRange(new object[] {
            "PLASTIC",
            "GLASS"});
            this.made_byComboBox1.Location = new System.Drawing.Point(201, 144);
            this.made_byComboBox1.Name = "made_byComboBox1";
            this.made_byComboBox1.Size = new System.Drawing.Size(164, 28);
            this.made_byComboBox1.TabIndex = 24;
            // 
            // powerTextBox
            // 
            this.powerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "Power", true));
            this.powerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerTextBox.Location = new System.Drawing.Point(201, 195);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(164, 27);
            this.powerTextBox.TabIndex = 26;
            // 
            // photoGray_NormalComboBox
            // 
            this.photoGray_NormalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "PhotoGray/Normal", true));
            this.photoGray_NormalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoGray_NormalComboBox.FormattingEnabled = true;
            this.photoGray_NormalComboBox.Items.AddRange(new object[] {
            "PHOTOGRAY",
            "NORMAL"});
            this.photoGray_NormalComboBox.Location = new System.Drawing.Point(201, 243);
            this.photoGray_NormalComboBox.Name = "photoGray_NormalComboBox";
            this.photoGray_NormalComboBox.Size = new System.Drawing.Size(164, 28);
            this.photoGray_NormalComboBox.TabIndex = 28;
            // 
            // other_featuresComboBox
            // 
            this.other_featuresComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "Other features", true));
            this.other_featuresComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other_featuresComboBox.FormattingEnabled = true;
            this.other_featuresComboBox.Items.AddRange(new object[] {
            "UNCOTED",
            "MULTI COTED",
            "BLUECUT"});
            this.other_featuresComboBox.Location = new System.Drawing.Point(201, 285);
            this.other_featuresComboBox.Name = "other_featuresComboBox";
            this.other_featuresComboBox.Size = new System.Drawing.Size(164, 28);
            this.other_featuresComboBox.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(821, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 40);
            this.button2.TabIndex = 34;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 39);
            this.button1.TabIndex = 35;
            this.button1.Text = "Find Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(pIDLabel1);
            this.groupBox1.Controls.Add(this.made_byComboBox);
            this.groupBox1.Controls.Add(made_byLabel);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(typeLabel);
            this.groupBox1.Controls.Add(this.pIDMaskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(569, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 216);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(pIDLabel2);
            this.groupBox2.Controls.Add(this.other_featuresComboBox);
            this.groupBox2.Controls.Add(other_featuresLabel);
            this.groupBox2.Controls.Add(this.photoGray_NormalComboBox);
            this.groupBox2.Controls.Add(photoGray_NormalLabel);
            this.groupBox2.Controls.Add(this.pIDMaskedTextBox2);
            this.groupBox2.Controls.Add(this.powerTextBox);
            this.groupBox2.Controls.Add(focal_typeLabel);
            this.groupBox2.Controls.Add(powerLabel);
            this.groupBox2.Controls.Add(this.focal_typeComboBox);
            this.groupBox2.Controls.Add(this.made_byComboBox1);
            this.groupBox2.Controls.Add(made_byLabel1);
            this.groupBox2.Location = new System.Drawing.Point(575, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 342);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lense details";
            // 
            // edit_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(pIDLabel);
            this.Controls.Add(this.pIDMaskedTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(unit_priceLabel);
            this.Controls.Add(this.unit_priceTextBox);
            this.Controls.Add(qtyInStockLabel);
            this.Controls.Add(this.qtyInStockTextBox);
            this.Controls.Add(date_fromLabel);
            this.Controls.Add(this.date_fromDateTimePicker);
            this.Controls.Add(this.pRODUCTBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit_products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Products";
            this.Load += new System.EventHandler(this.edit_producs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingNavigator)).EndInit();
            this.pRODUCTBindingNavigator.ResumeLayout(false);
            this.pRODUCTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fRAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENSEBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisionCenterDataSet visionCenterDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private VisionCenterDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private VisionCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pRODUCTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pRODUCTBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox pIDMaskedTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox unit_priceTextBox;
        private System.Windows.Forms.TextBox qtyInStockTextBox;
        private System.Windows.Forms.DateTimePicker date_fromDateTimePicker;
        private VisionCenterDataSetTableAdapters.FRAMETableAdapter fRAMETableAdapter;
        private System.Windows.Forms.BindingSource fRAMEBindingSource;
        private VisionCenterDataSetTableAdapters.LENSETableAdapter lENSETableAdapter;
        private System.Windows.Forms.MaskedTextBox pIDMaskedTextBox1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox made_byComboBox;
        private System.Windows.Forms.BindingSource lENSEBindingSource;
        private System.Windows.Forms.MaskedTextBox pIDMaskedTextBox2;
        private System.Windows.Forms.ComboBox focal_typeComboBox;
        private System.Windows.Forms.ComboBox made_byComboBox1;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.ComboBox photoGray_NormalComboBox;
        private System.Windows.Forms.ComboBox other_featuresComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}