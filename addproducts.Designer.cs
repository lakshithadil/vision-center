
namespace vision_center1
{
    partial class addproducts
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
            System.Windows.Forms.Label date_fromLabel;
            System.Windows.Forms.Label qtyInStockLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label pIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addproducts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pRODUCTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visionCenterDataSet = new vision_center1.VisionCenterDataSet();
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
            this.pRODUCTTableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.PRODUCTTableAdapter();
            this.tableAdapterManager = new vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager();
            date_fromLabel = new System.Windows.Forms.Label();
            qtyInStockLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            pIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingNavigator)).BeginInit();
            this.pRODUCTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // date_fromLabel
            // 
            date_fromLabel.AutoSize = true;
            date_fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_fromLabel.Location = new System.Drawing.Point(147, 402);
            date_fromLabel.Name = "date_fromLabel";
            date_fromLabel.Size = new System.Drawing.Size(154, 20);
            date_fromLabel.TabIndex = 10;
            date_fromLabel.Text = "Date from             :";
            // 
            // qtyInStockLabel
            // 
            qtyInStockLabel.AutoSize = true;
            qtyInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyInStockLabel.Location = new System.Drawing.Point(147, 342);
            qtyInStockLabel.Name = "qtyInStockLabel";
            qtyInStockLabel.Size = new System.Drawing.Size(155, 20);
            qtyInStockLabel.TabIndex = 8;
            qtyInStockLabel.Text = "Qty In Stock          :";
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unit_priceLabel.Location = new System.Drawing.Point(147, 280);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(156, 20);
            unit_priceLabel.TabIndex = 6;
            unit_priceLabel.Text = "Unit price (LKR)    :";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(147, 219);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(155, 20);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description           :";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(147, 158);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(156, 20);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category               :";
            // 
            // pIDLabel
            // 
            pIDLabel.AutoSize = true;
            pIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pIDLabel.Location = new System.Drawing.Point(147, 101);
            pIDLabel.Name = "pIDLabel";
            pIDLabel.Size = new System.Drawing.Size(154, 20);
            pIDLabel.TabIndex = 0;
            pIDLabel.Text = "Product ID            :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 553);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pRODUCTBindingNavigator);
            this.panel2.Controls.Add(pIDLabel);
            this.panel2.Controls.Add(this.pIDMaskedTextBox);
            this.panel2.Controls.Add(categoryLabel);
            this.panel2.Controls.Add(this.categoryComboBox);
            this.panel2.Controls.Add(descriptionLabel);
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(unit_priceLabel);
            this.panel2.Controls.Add(this.unit_priceTextBox);
            this.panel2.Controls.Add(qtyInStockLabel);
            this.panel2.Controls.Add(this.qtyInStockTextBox);
            this.panel2.Controls.Add(date_fromLabel);
            this.panel2.Controls.Add(this.date_fromDateTimePicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 553);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "ENTER PRODUCT DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(821, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pRODUCTBindingNavigator
            // 
            this.pRODUCTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pRODUCTBindingNavigator.BindingSource = this.pRODUCTBindingSource;
            this.pRODUCTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pRODUCTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pRODUCTBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pRODUCTBindingNavigatorSaveItem});
            this.pRODUCTBindingNavigator.Location = new System.Drawing.Point(389, 11);
            this.pRODUCTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pRODUCTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pRODUCTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pRODUCTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pRODUCTBindingNavigator.Name = "pRODUCTBindingNavigator";
            this.pRODUCTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pRODUCTBindingNavigator.Size = new System.Drawing.Size(331, 27);
            this.pRODUCTBindingNavigator.TabIndex = 1;
            this.pRODUCTBindingNavigator.Text = "bindingNavigator1";
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
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.visionCenterDataSet;
            // 
            // visionCenterDataSet
            // 
            this.visionCenterDataSet.DataSetName = "VisionCenterDataSet";
            this.visionCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // pRODUCTBindingNavigatorSaveItem
            // 
            this.pRODUCTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUCTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUCTBindingNavigatorSaveItem.Image")));
            this.pRODUCTBindingNavigatorSaveItem.Name = "pRODUCTBindingNavigatorSaveItem";
            this.pRODUCTBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pRODUCTBindingNavigatorSaveItem.Text = "Save Data";
            this.pRODUCTBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRODUCTBindingNavigatorSaveItem_Click);
            // 
            // pIDMaskedTextBox
            // 
            this.pIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "PID", true));
            this.pIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDMaskedTextBox.Location = new System.Drawing.Point(370, 101);
            this.pIDMaskedTextBox.Name = "pIDMaskedTextBox";
            this.pIDMaskedTextBox.Size = new System.Drawing.Size(423, 27);
            this.pIDMaskedTextBox.TabIndex = 1;
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
            this.categoryComboBox.Location = new System.Drawing.Point(370, 158);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(423, 28);
            this.categoryComboBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(370, 219);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(423, 27);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // unit_priceTextBox
            // 
            this.unit_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Unit price", true));
            this.unit_priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_priceTextBox.Location = new System.Drawing.Point(370, 280);
            this.unit_priceTextBox.Name = "unit_priceTextBox";
            this.unit_priceTextBox.Size = new System.Drawing.Size(423, 27);
            this.unit_priceTextBox.TabIndex = 7;
            // 
            // qtyInStockTextBox
            // 
            this.qtyInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "QtyInStock", true));
            this.qtyInStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyInStockTextBox.Location = new System.Drawing.Point(370, 342);
            this.qtyInStockTextBox.Name = "qtyInStockTextBox";
            this.qtyInStockTextBox.Size = new System.Drawing.Size(423, 27);
            this.qtyInStockTextBox.TabIndex = 9;
            // 
            // date_fromDateTimePicker
            // 
            this.date_fromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pRODUCTBindingSource, "Date from", true));
            this.date_fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fromDateTimePicker.Location = new System.Drawing.Point(370, 401);
            this.date_fromDateTimePicker.Name = "date_fromDateTimePicker";
            this.date_fromDateTimePicker.Size = new System.Drawing.Size(423, 27);
            this.date_fromDateTimePicker.TabIndex = 11;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.FRAMETableAdapter = null;
            this.tableAdapterManager.LENSETableAdapter = null;
            this.tableAdapterManager.ORDERLINETableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = this.pRODUCTTableAdapter;
            this.tableAdapterManager.TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addproducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add products";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.addproducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingNavigator)).EndInit();
            this.pRODUCTBindingNavigator.ResumeLayout(false);
            this.pRODUCTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisionCenterDataSet visionCenterDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private VisionCenterDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private VisionCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingNavigator pRODUCTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pRODUCTBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox pIDMaskedTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox unit_priceTextBox;
        private System.Windows.Forms.TextBox qtyInStockTextBox;
        private System.Windows.Forms.DateTimePicker date_fromDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}