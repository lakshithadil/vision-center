
namespace vision_center1
{
    partial class Frame
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
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label made_byLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.visionCenterDataSet = new vision_center1.VisionCenterDataSet();
            this.fRAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRAMETableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.FRAMETableAdapter();
            this.tableAdapterManager = new vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager();
            this.pIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.made_byComboBox = new System.Windows.Forms.ComboBox();
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
            this.fRAMEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fRAMEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            pIDLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            made_byLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAMEBindingNavigator)).BeginInit();
            this.fRAMEBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pIDLabel
            // 
            pIDLabel.AutoSize = true;
            pIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pIDLabel.Location = new System.Drawing.Point(168, 186);
            pIDLabel.Name = "pIDLabel";
            pIDLabel.Size = new System.Drawing.Size(129, 20);
            pIDLabel.TabIndex = 1;
            pIDLabel.Text = "Product ID       :";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeLabel.Location = new System.Drawing.Point(168, 242);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(130, 20);
            typeLabel.TabIndex = 3;
            typeLabel.Text = "Type                :";
            // 
            // made_byLabel
            // 
            made_byLabel.AutoSize = true;
            made_byLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            made_byLabel.Location = new System.Drawing.Point(168, 296);
            made_byLabel.Name = "made_byLabel";
            made_byLabel.Size = new System.Drawing.Size(132, 20);
            made_byLabel.TabIndex = 5;
            made_byLabel.Text = "Made by           :";
            // 
            // visionCenterDataSet
            // 
            this.visionCenterDataSet.DataSetName = "VisionCenterDataSet";
            this.visionCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fRAMEBindingSource
            // 
            this.fRAMEBindingSource.DataMember = "FRAME";
            this.fRAMEBindingSource.DataSource = this.visionCenterDataSet;
            // 
            // fRAMETableAdapter
            // 
            this.fRAMETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.FRAMETableAdapter = this.fRAMETableAdapter;
            this.tableAdapterManager.LENSETableAdapter = null;
            this.tableAdapterManager.ORDERLINETableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pIDMaskedTextBox
            // 
            this.pIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fRAMEBindingSource, "PID", true));
            this.pIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDMaskedTextBox.Location = new System.Drawing.Point(369, 186);
            this.pIDMaskedTextBox.Name = "pIDMaskedTextBox";
            this.pIDMaskedTextBox.Size = new System.Drawing.Size(423, 27);
            this.pIDMaskedTextBox.TabIndex = 2;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fRAMEBindingSource, "Type", true));
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "HALF",
            "FULL"});
            this.typeComboBox.Location = new System.Drawing.Point(369, 242);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(423, 28);
            this.typeComboBox.TabIndex = 4;
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
            this.made_byComboBox.Location = new System.Drawing.Point(369, 296);
            this.made_byComboBox.Name = "made_byComboBox";
            this.made_byComboBox.Size = new System.Drawing.Size(423, 28);
            this.made_byComboBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(821, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 7;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // fRAMEBindingNavigatorSaveItem
            // 
            this.fRAMEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fRAMEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fRAMEBindingNavigatorSaveItem.Image")));
            this.fRAMEBindingNavigatorSaveItem.Name = "fRAMEBindingNavigatorSaveItem";
            this.fRAMEBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.fRAMEBindingNavigatorSaveItem.Text = "Save Data";
            this.fRAMEBindingNavigatorSaveItem.Click += new System.EventHandler(this.fRAMEBindingNavigatorSaveItem_Click_1);
            // 
            // fRAMEBindingNavigator
            // 
            this.fRAMEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fRAMEBindingNavigator.BindingSource = this.fRAMEBindingSource;
            this.fRAMEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fRAMEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fRAMEBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.fRAMEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fRAMEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fRAMEBindingNavigatorSaveItem});
            this.fRAMEBindingNavigator.Location = new System.Drawing.Point(359, 9);
            this.fRAMEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fRAMEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fRAMEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fRAMEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fRAMEBindingNavigator.Name = "fRAMEBindingNavigator";
            this.fRAMEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fRAMEBindingNavigator.Size = new System.Drawing.Size(331, 31);
            this.fRAMEBindingNavigator.TabIndex = 0;
            this.fRAMEBindingNavigator.Text = "bindingNavigator1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "ENTER FRAME DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(pIDLabel);
            this.Controls.Add(this.pIDMaskedTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(made_byLabel);
            this.Controls.Add(this.made_byComboBox);
            this.Controls.Add(this.fRAMEBindingNavigator);
            this.Name = "Frame";
            this.Text = "Frame";
            this.Load += new System.EventHandler(this.Frame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAMEBindingNavigator)).EndInit();
            this.fRAMEBindingNavigator.ResumeLayout(false);
            this.fRAMEBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisionCenterDataSet visionCenterDataSet;
        private System.Windows.Forms.BindingSource fRAMEBindingSource;
        private VisionCenterDataSetTableAdapters.FRAMETableAdapter fRAMETableAdapter;
        private VisionCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox pIDMaskedTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox made_byComboBox;
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
        private System.Windows.Forms.ToolStripButton fRAMEBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator fRAMEBindingNavigator;
        private System.Windows.Forms.Label label1;
    }
}