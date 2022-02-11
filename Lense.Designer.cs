
namespace vision_center1
{
    partial class Lense
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
            System.Windows.Forms.Label focal_typeLabel;
            System.Windows.Forms.Label made_byLabel;
            System.Windows.Forms.Label powerLabel;
            System.Windows.Forms.Label photoGray_NormalLabel;
            System.Windows.Forms.Label other_featuresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lense));
            this.visionCenterDataSet = new vision_center1.VisionCenterDataSet();
            this.lENSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lENSETableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.LENSETableAdapter();
            this.tableAdapterManager = new vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager();
            this.pIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.focal_typeComboBox = new System.Windows.Forms.ComboBox();
            this.made_byComboBox = new System.Windows.Forms.ComboBox();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.photoGray_NormalComboBox = new System.Windows.Forms.ComboBox();
            this.other_featuresComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lENSEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lENSEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            pIDLabel = new System.Windows.Forms.Label();
            focal_typeLabel = new System.Windows.Forms.Label();
            made_byLabel = new System.Windows.Forms.Label();
            powerLabel = new System.Windows.Forms.Label();
            photoGray_NormalLabel = new System.Windows.Forms.Label();
            other_featuresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENSEBindingNavigator)).BeginInit();
            this.lENSEBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pIDLabel
            // 
            pIDLabel.AutoSize = true;
            pIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pIDLabel.Location = new System.Drawing.Point(161, 123);
            pIDLabel.Name = "pIDLabel";
            pIDLabel.Size = new System.Drawing.Size(184, 20);
            pIDLabel.TabIndex = 1;
            pIDLabel.Text = "Product ID                  :";
            // 
            // focal_typeLabel
            // 
            focal_typeLabel.AutoSize = true;
            focal_typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            focal_typeLabel.Location = new System.Drawing.Point(161, 177);
            focal_typeLabel.Name = "focal_typeLabel";
            focal_typeLabel.Size = new System.Drawing.Size(181, 20);
            focal_typeLabel.TabIndex = 3;
            focal_typeLabel.Text = "Focal type                  :";
            // 
            // made_byLabel
            // 
            made_byLabel.AutoSize = true;
            made_byLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            made_byLabel.Location = new System.Drawing.Point(161, 235);
            made_byLabel.Name = "made_byLabel";
            made_byLabel.Size = new System.Drawing.Size(177, 20);
            made_byLabel.TabIndex = 5;
            made_byLabel.Text = "Made by                    :";
            // 
            // powerLabel
            // 
            powerLabel.AutoSize = true;
            powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            powerLabel.Location = new System.Drawing.Point(161, 290);
            powerLabel.Name = "powerLabel";
            powerLabel.Size = new System.Drawing.Size(176, 20);
            powerLabel.TabIndex = 7;
            powerLabel.Text = "Power                       :";
            // 
            // photoGray_NormalLabel
            // 
            photoGray_NormalLabel.AutoSize = true;
            photoGray_NormalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            photoGray_NormalLabel.Location = new System.Drawing.Point(161, 344);
            photoGray_NormalLabel.Name = "photoGray_NormalLabel";
            photoGray_NormalLabel.Size = new System.Drawing.Size(177, 20);
            photoGray_NormalLabel.TabIndex = 9;
            photoGray_NormalLabel.Text = "Photo Gray/Normal    :";
            // 
            // other_featuresLabel
            // 
            other_featuresLabel.AutoSize = true;
            other_featuresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            other_featuresLabel.Location = new System.Drawing.Point(161, 399);
            other_featuresLabel.Name = "other_featuresLabel";
            other_featuresLabel.Size = new System.Drawing.Size(172, 20);
            other_featuresLabel.TabIndex = 11;
            other_featuresLabel.Text = "Other features          :";
            // 
            // visionCenterDataSet
            // 
            this.visionCenterDataSet.DataSetName = "VisionCenterDataSet";
            this.visionCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lENSEBindingSource
            // 
            this.lENSEBindingSource.DataMember = "LENSE";
            this.lENSEBindingSource.DataSource = this.visionCenterDataSet;
            // 
            // lENSETableAdapter
            // 
            this.lENSETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.FRAMETableAdapter = null;
            this.tableAdapterManager.LENSETableAdapter = this.lENSETableAdapter;
            this.tableAdapterManager.ORDERLINETableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pIDMaskedTextBox
            // 
            this.pIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "PID", true));
            this.pIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDMaskedTextBox.Location = new System.Drawing.Point(393, 123);
            this.pIDMaskedTextBox.Name = "pIDMaskedTextBox";
            this.pIDMaskedTextBox.Size = new System.Drawing.Size(423, 27);
            this.pIDMaskedTextBox.TabIndex = 2;
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
            this.focal_typeComboBox.Location = new System.Drawing.Point(393, 177);
            this.focal_typeComboBox.Name = "focal_typeComboBox";
            this.focal_typeComboBox.Size = new System.Drawing.Size(423, 28);
            this.focal_typeComboBox.TabIndex = 4;
            // 
            // made_byComboBox
            // 
            this.made_byComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "Made by", true));
            this.made_byComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.made_byComboBox.FormattingEnabled = true;
            this.made_byComboBox.Items.AddRange(new object[] {
            "PLASTIC",
            "GLASS"});
            this.made_byComboBox.Location = new System.Drawing.Point(393, 235);
            this.made_byComboBox.Name = "made_byComboBox";
            this.made_byComboBox.Size = new System.Drawing.Size(423, 28);
            this.made_byComboBox.TabIndex = 6;
            // 
            // powerTextBox
            // 
            this.powerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "Power", true));
            this.powerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerTextBox.Location = new System.Drawing.Point(393, 290);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(423, 27);
            this.powerTextBox.TabIndex = 8;
            // 
            // photoGray_NormalComboBox
            // 
            this.photoGray_NormalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lENSEBindingSource, "PhotoGray/Normal", true));
            this.photoGray_NormalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoGray_NormalComboBox.FormattingEnabled = true;
            this.photoGray_NormalComboBox.Items.AddRange(new object[] {
            "PHOTOGRAY",
            "NORMAL"});
            this.photoGray_NormalComboBox.Location = new System.Drawing.Point(393, 344);
            this.photoGray_NormalComboBox.Name = "photoGray_NormalComboBox";
            this.photoGray_NormalComboBox.Size = new System.Drawing.Size(423, 28);
            this.photoGray_NormalComboBox.TabIndex = 10;
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
            this.other_featuresComboBox.Location = new System.Drawing.Point(393, 399);
            this.other_featuresComboBox.Name = "other_featuresComboBox";
            this.other_featuresComboBox.Size = new System.Drawing.Size(423, 28);
            this.other_featuresComboBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(821, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // lENSEBindingNavigatorSaveItem
            // 
            this.lENSEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lENSEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lENSEBindingNavigatorSaveItem.Image")));
            this.lENSEBindingNavigatorSaveItem.Name = "lENSEBindingNavigatorSaveItem";
            this.lENSEBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.lENSEBindingNavigatorSaveItem.Text = "Save Data";
            this.lENSEBindingNavigatorSaveItem.Click += new System.EventHandler(this.lENSEBindingNavigatorSaveItem_Click_1);
            // 
            // lENSEBindingNavigator
            // 
            this.lENSEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lENSEBindingNavigator.BindingSource = this.lENSEBindingSource;
            this.lENSEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lENSEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lENSEBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.lENSEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lENSEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lENSEBindingNavigatorSaveItem});
            this.lENSEBindingNavigator.Location = new System.Drawing.Point(308, 11);
            this.lENSEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lENSEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lENSEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lENSEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lENSEBindingNavigator.Name = "lENSEBindingNavigator";
            this.lENSEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lENSEBindingNavigator.Size = new System.Drawing.Size(331, 31);
            this.lENSEBindingNavigator.TabIndex = 0;
            this.lENSEBindingNavigator.Text = "bindingNavigator1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "ENTER LENSE DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lENSEBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(pIDLabel);
            this.Controls.Add(this.pIDMaskedTextBox);
            this.Controls.Add(focal_typeLabel);
            this.Controls.Add(this.focal_typeComboBox);
            this.Controls.Add(made_byLabel);
            this.Controls.Add(this.made_byComboBox);
            this.Controls.Add(powerLabel);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(photoGray_NormalLabel);
            this.Controls.Add(this.photoGray_NormalComboBox);
            this.Controls.Add(other_featuresLabel);
            this.Controls.Add(this.other_featuresComboBox);
            this.Name = "Lense";
            this.Text = "Lense";
            this.Load += new System.EventHandler(this.Lense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENSEBindingNavigator)).EndInit();
            this.lENSEBindingNavigator.ResumeLayout(false);
            this.lENSEBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisionCenterDataSet visionCenterDataSet;
        private System.Windows.Forms.BindingSource lENSEBindingSource;
        private VisionCenterDataSetTableAdapters.LENSETableAdapter lENSETableAdapter;
        private VisionCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox pIDMaskedTextBox;
        private System.Windows.Forms.ComboBox focal_typeComboBox;
        private System.Windows.Forms.ComboBox made_byComboBox;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.ComboBox photoGray_NormalComboBox;
        private System.Windows.Forms.ComboBox other_featuresComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton lENSEBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator lENSEBindingNavigator;
        private System.Windows.Forms.Label label1;
    }
}