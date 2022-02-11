
namespace vision_center1
{
    partial class edit_prescriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_prescriptions));
            System.Windows.Forms.Label pRIDLabel;
            System.Windows.Forms.Label cIDLabel;
            System.Windows.Forms.Label date_of_issueLabel;
            System.Windows.Forms.Label dLsphericalLabel;
            System.Windows.Forms.Label dLAxisLabel;
            System.Windows.Forms.Label dLcylinderLabel;
            System.Windows.Forms.Label dRsphericalLabel;
            System.Windows.Forms.Label dRAxisLabel;
            System.Windows.Forms.Label dRcylinderLabel;
            System.Windows.Forms.Label nLsphericalLabel;
            System.Windows.Forms.Label nLAxisLabel;
            System.Windows.Forms.Label nLcylinderLabel;
            System.Windows.Forms.Label nRsphericalLabel;
            System.Windows.Forms.Label nRAxisLabel;
            System.Windows.Forms.Label nRcylinderLabel;
            System.Windows.Forms.Label commentsLabel;
            this.visionCenterDataSet = new vision_center1.VisionCenterDataSet();
            this.pRESCRIPTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRESCRIPTIONTableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.PRESCRIPTIONTableAdapter();
            this.tableAdapterManager = new vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager();
            this.pRESCRIPTIONBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pRESCRIPTIONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pRIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.date_of_issueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dLsphericalTextBox = new System.Windows.Forms.TextBox();
            this.dLAxisTextBox = new System.Windows.Forms.TextBox();
            this.dLcylinderTextBox = new System.Windows.Forms.TextBox();
            this.dRsphericalTextBox = new System.Windows.Forms.TextBox();
            this.dRAxisTextBox = new System.Windows.Forms.TextBox();
            this.dRcylinderTextBox = new System.Windows.Forms.TextBox();
            this.nLsphericalTextBox = new System.Windows.Forms.TextBox();
            this.nLAxisTextBox = new System.Windows.Forms.TextBox();
            this.nLcylinderTextBox = new System.Windows.Forms.TextBox();
            this.nRsphericalTextBox = new System.Windows.Forms.TextBox();
            this.nRAxisTextBox = new System.Windows.Forms.TextBox();
            this.nRcylinderTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            pRIDLabel = new System.Windows.Forms.Label();
            cIDLabel = new System.Windows.Forms.Label();
            date_of_issueLabel = new System.Windows.Forms.Label();
            dLsphericalLabel = new System.Windows.Forms.Label();
            dLAxisLabel = new System.Windows.Forms.Label();
            dLcylinderLabel = new System.Windows.Forms.Label();
            dRsphericalLabel = new System.Windows.Forms.Label();
            dRAxisLabel = new System.Windows.Forms.Label();
            dRcylinderLabel = new System.Windows.Forms.Label();
            nLsphericalLabel = new System.Windows.Forms.Label();
            nLAxisLabel = new System.Windows.Forms.Label();
            nLcylinderLabel = new System.Windows.Forms.Label();
            nRsphericalLabel = new System.Windows.Forms.Label();
            nRAxisLabel = new System.Windows.Forms.Label();
            nRcylinderLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESCRIPTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESCRIPTIONBindingNavigator)).BeginInit();
            this.pRESCRIPTIONBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visionCenterDataSet
            // 
            this.visionCenterDataSet.DataSetName = "VisionCenterDataSet";
            this.visionCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRESCRIPTIONBindingSource
            // 
            this.pRESCRIPTIONBindingSource.DataMember = "PRESCRIPTION";
            this.pRESCRIPTIONBindingSource.DataSource = this.visionCenterDataSet;
            // 
            // pRESCRIPTIONTableAdapter
            // 
            this.pRESCRIPTIONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.FRAMETableAdapter = null;
            this.tableAdapterManager.LENSETableAdapter = null;
            this.tableAdapterManager.ORDERLINETableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = this.pRESCRIPTIONTableAdapter;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pRESCRIPTIONBindingNavigator
            // 
            this.pRESCRIPTIONBindingNavigator.AddNewItem = null;
            this.pRESCRIPTIONBindingNavigator.BindingSource = this.pRESCRIPTIONBindingSource;
            this.pRESCRIPTIONBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pRESCRIPTIONBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pRESCRIPTIONBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pRESCRIPTIONBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pRESCRIPTIONBindingNavigatorSaveItem});
            this.pRESCRIPTIONBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pRESCRIPTIONBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pRESCRIPTIONBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pRESCRIPTIONBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pRESCRIPTIONBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pRESCRIPTIONBindingNavigator.Name = "pRESCRIPTIONBindingNavigator";
            this.pRESCRIPTIONBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pRESCRIPTIONBindingNavigator.Size = new System.Drawing.Size(982, 27);
            this.pRESCRIPTIONBindingNavigator.TabIndex = 0;
            this.pRESCRIPTIONBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // pRESCRIPTIONBindingNavigatorSaveItem
            // 
            this.pRESCRIPTIONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRESCRIPTIONBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRESCRIPTIONBindingNavigatorSaveItem.Image")));
            this.pRESCRIPTIONBindingNavigatorSaveItem.Name = "pRESCRIPTIONBindingNavigatorSaveItem";
            this.pRESCRIPTIONBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pRESCRIPTIONBindingNavigatorSaveItem.Text = "Save Data";
            this.pRESCRIPTIONBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRESCRIPTIONBindingNavigatorSaveItem_Click);
            // 
            // pRIDLabel
            // 
            pRIDLabel.AutoSize = true;
            pRIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pRIDLabel.Location = new System.Drawing.Point(110, 56);
            pRIDLabel.Name = "pRIDLabel";
            pRIDLabel.Size = new System.Drawing.Size(146, 20);
            pRIDLabel.TabIndex = 1;
            pRIDLabel.Text = "Prescription ID    :";
            // 
            // pRIDMaskedTextBox
            // 
            this.pRIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "PRID", true));
            this.pRIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRIDMaskedTextBox.Location = new System.Drawing.Point(283, 53);
            this.pRIDMaskedTextBox.Name = "pRIDMaskedTextBox";
            this.pRIDMaskedTextBox.ReadOnly = true;
            this.pRIDMaskedTextBox.Size = new System.Drawing.Size(293, 27);
            this.pRIDMaskedTextBox.TabIndex = 2;
            // 
            // cIDLabel
            // 
            cIDLabel.AutoSize = true;
            cIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cIDLabel.Location = new System.Drawing.Point(110, 99);
            cIDLabel.Name = "cIDLabel";
            cIDLabel.Size = new System.Drawing.Size(144, 20);
            cIDLabel.TabIndex = 3;
            cIDLabel.Text = "Customer ID       :";
            // 
            // cIDMaskedTextBox
            // 
            this.cIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "CID", true));
            this.cIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cIDMaskedTextBox.Location = new System.Drawing.Point(283, 96);
            this.cIDMaskedTextBox.Name = "cIDMaskedTextBox";
            this.cIDMaskedTextBox.ReadOnly = true;
            this.cIDMaskedTextBox.Size = new System.Drawing.Size(293, 27);
            this.cIDMaskedTextBox.TabIndex = 4;
            // 
            // date_of_issueLabel
            // 
            date_of_issueLabel.AutoSize = true;
            date_of_issueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_of_issueLabel.Location = new System.Drawing.Point(110, 139);
            date_of_issueLabel.Name = "date_of_issueLabel";
            date_of_issueLabel.Size = new System.Drawing.Size(144, 20);
            date_of_issueLabel.TabIndex = 5;
            date_of_issueLabel.Text = "Date of issue      :";
            // 
            // date_of_issueDateTimePicker
            // 
            this.date_of_issueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pRESCRIPTIONBindingSource, "Date of issue", true));
            this.date_of_issueDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_of_issueDateTimePicker.Location = new System.Drawing.Point(283, 140);
            this.date_of_issueDateTimePicker.Name = "date_of_issueDateTimePicker";
            this.date_of_issueDateTimePicker.Size = new System.Drawing.Size(293, 27);
            this.date_of_issueDateTimePicker.TabIndex = 6;
            // 
            // dLsphericalLabel
            // 
            dLsphericalLabel.AutoSize = true;
            dLsphericalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dLsphericalLabel.Location = new System.Drawing.Point(11, 55);
            dLsphericalLabel.Name = "dLsphericalLabel";
            dLsphericalLabel.Size = new System.Drawing.Size(105, 20);
            dLsphericalLabel.TabIndex = 7;
            dLsphericalLabel.Text = "DLspherical:";
            // 
            // dLsphericalTextBox
            // 
            this.dLsphericalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "DLspherical", true));
            this.dLsphericalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLsphericalTextBox.Location = new System.Drawing.Point(182, 52);
            this.dLsphericalTextBox.Name = "dLsphericalTextBox";
            this.dLsphericalTextBox.Size = new System.Drawing.Size(87, 27);
            this.dLsphericalTextBox.TabIndex = 8;
            // 
            // dLAxisLabel
            // 
            dLAxisLabel.AutoSize = true;
            dLAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dLAxisLabel.Location = new System.Drawing.Point(9, 80);
            dLAxisLabel.Name = "dLAxisLabel";
            dLAxisLabel.Size = new System.Drawing.Size(69, 20);
            dLAxisLabel.TabIndex = 9;
            dLAxisLabel.Text = "DLAxis:";
            // 
            // dLAxisTextBox
            // 
            this.dLAxisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "DLAxis", true));
            this.dLAxisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLAxisTextBox.Location = new System.Drawing.Point(182, 80);
            this.dLAxisTextBox.Name = "dLAxisTextBox";
            this.dLAxisTextBox.Size = new System.Drawing.Size(87, 27);
            this.dLAxisTextBox.TabIndex = 10;
            // 
            // dLcylinderLabel
            // 
            dLcylinderLabel.AutoSize = true;
            dLcylinderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dLcylinderLabel.Location = new System.Drawing.Point(9, 108);
            dLcylinderLabel.Name = "dLcylinderLabel";
            dLcylinderLabel.Size = new System.Drawing.Size(95, 20);
            dLcylinderLabel.TabIndex = 11;
            dLcylinderLabel.Text = "DLcylinder:";
            // 
            // dLcylinderTextBox
            // 
            this.dLcylinderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "DLcylinder", true));
            this.dLcylinderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLcylinderTextBox.Location = new System.Drawing.Point(182, 108);
            this.dLcylinderTextBox.Name = "dLcylinderTextBox";
            this.dLcylinderTextBox.Size = new System.Drawing.Size(87, 27);
            this.dLcylinderTextBox.TabIndex = 12;
            // 
            // dRsphericalLabel
            // 
            dRsphericalLabel.AutoSize = true;
            dRsphericalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dRsphericalLabel.Location = new System.Drawing.Point(9, 136);
            dRsphericalLabel.Name = "dRsphericalLabel";
            dRsphericalLabel.Size = new System.Drawing.Size(107, 20);
            dRsphericalLabel.TabIndex = 13;
            dRsphericalLabel.Text = "DRspherical:";
            // 
            // dRsphericalTextBox
            // 
            this.dRsphericalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "DRspherical", true));
            this.dRsphericalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dRsphericalTextBox.Location = new System.Drawing.Point(182, 136);
            this.dRsphericalTextBox.Name = "dRsphericalTextBox";
            this.dRsphericalTextBox.Size = new System.Drawing.Size(87, 27);
            this.dRsphericalTextBox.TabIndex = 14;
            // 
            // dRAxisLabel
            // 
            dRAxisLabel.AutoSize = true;
            dRAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dRAxisLabel.Location = new System.Drawing.Point(9, 164);
            dRAxisLabel.Name = "dRAxisLabel";
            dRAxisLabel.Size = new System.Drawing.Size(71, 20);
            dRAxisLabel.TabIndex = 15;
            dRAxisLabel.Text = "DRAxis:";
            // 
            // dRAxisTextBox
            // 
            this.dRAxisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "DRAxis", true));
            this.dRAxisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dRAxisTextBox.Location = new System.Drawing.Point(182, 164);
            this.dRAxisTextBox.Name = "dRAxisTextBox";
            this.dRAxisTextBox.Size = new System.Drawing.Size(87, 27);
            this.dRAxisTextBox.TabIndex = 16;
            // 
            // dRcylinderLabel
            // 
            dRcylinderLabel.AutoSize = true;
            dRcylinderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dRcylinderLabel.Location = new System.Drawing.Point(9, 192);
            dRcylinderLabel.Name = "dRcylinderLabel";
            dRcylinderLabel.Size = new System.Drawing.Size(97, 20);
            dRcylinderLabel.TabIndex = 17;
            dRcylinderLabel.Text = "DRcylinder:";
            // 
            // dRcylinderTextBox
            // 
            this.dRcylinderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "DRcylinder", true));
            this.dRcylinderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dRcylinderTextBox.Location = new System.Drawing.Point(182, 192);
            this.dRcylinderTextBox.Name = "dRcylinderTextBox";
            this.dRcylinderTextBox.Size = new System.Drawing.Size(87, 27);
            this.dRcylinderTextBox.TabIndex = 18;
            // 
            // nLsphericalLabel
            // 
            nLsphericalLabel.AutoSize = true;
            nLsphericalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nLsphericalLabel.Location = new System.Drawing.Point(420, 55);
            nLsphericalLabel.Name = "nLsphericalLabel";
            nLsphericalLabel.Size = new System.Drawing.Size(104, 20);
            nLsphericalLabel.TabIndex = 19;
            nLsphericalLabel.Text = "NLspherical:";
            // 
            // nLsphericalTextBox
            // 
            this.nLsphericalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "NLspherical", true));
            this.nLsphericalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLsphericalTextBox.Location = new System.Drawing.Point(632, 52);
            this.nLsphericalTextBox.Name = "nLsphericalTextBox";
            this.nLsphericalTextBox.Size = new System.Drawing.Size(87, 27);
            this.nLsphericalTextBox.TabIndex = 20;
            // 
            // nLAxisLabel
            // 
            nLAxisLabel.AutoSize = true;
            nLAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nLAxisLabel.Location = new System.Drawing.Point(420, 83);
            nLAxisLabel.Name = "nLAxisLabel";
            nLAxisLabel.Size = new System.Drawing.Size(68, 20);
            nLAxisLabel.TabIndex = 21;
            nLAxisLabel.Text = "NLAxis:";
            // 
            // nLAxisTextBox
            // 
            this.nLAxisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "NLAxis", true));
            this.nLAxisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLAxisTextBox.Location = new System.Drawing.Point(632, 80);
            this.nLAxisTextBox.Name = "nLAxisTextBox";
            this.nLAxisTextBox.Size = new System.Drawing.Size(87, 27);
            this.nLAxisTextBox.TabIndex = 22;
            // 
            // nLcylinderLabel
            // 
            nLcylinderLabel.AutoSize = true;
            nLcylinderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nLcylinderLabel.Location = new System.Drawing.Point(420, 111);
            nLcylinderLabel.Name = "nLcylinderLabel";
            nLcylinderLabel.Size = new System.Drawing.Size(94, 20);
            nLcylinderLabel.TabIndex = 23;
            nLcylinderLabel.Text = "NLcylinder:";
            // 
            // nLcylinderTextBox
            // 
            this.nLcylinderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "NLcylinder", true));
            this.nLcylinderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLcylinderTextBox.Location = new System.Drawing.Point(632, 108);
            this.nLcylinderTextBox.Name = "nLcylinderTextBox";
            this.nLcylinderTextBox.Size = new System.Drawing.Size(87, 27);
            this.nLcylinderTextBox.TabIndex = 24;
            // 
            // nRsphericalLabel
            // 
            nRsphericalLabel.AutoSize = true;
            nRsphericalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nRsphericalLabel.Location = new System.Drawing.Point(420, 139);
            nRsphericalLabel.Name = "nRsphericalLabel";
            nRsphericalLabel.Size = new System.Drawing.Size(106, 20);
            nRsphericalLabel.TabIndex = 25;
            nRsphericalLabel.Text = "NRspherical:";
            // 
            // nRsphericalTextBox
            // 
            this.nRsphericalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "NRspherical", true));
            this.nRsphericalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRsphericalTextBox.Location = new System.Drawing.Point(632, 136);
            this.nRsphericalTextBox.Name = "nRsphericalTextBox";
            this.nRsphericalTextBox.Size = new System.Drawing.Size(87, 27);
            this.nRsphericalTextBox.TabIndex = 26;
            // 
            // nRAxisLabel
            // 
            nRAxisLabel.AutoSize = true;
            nRAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nRAxisLabel.Location = new System.Drawing.Point(420, 167);
            nRAxisLabel.Name = "nRAxisLabel";
            nRAxisLabel.Size = new System.Drawing.Size(70, 20);
            nRAxisLabel.TabIndex = 27;
            nRAxisLabel.Text = "NRAxis:";
            // 
            // nRAxisTextBox
            // 
            this.nRAxisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "NRAxis", true));
            this.nRAxisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRAxisTextBox.Location = new System.Drawing.Point(632, 164);
            this.nRAxisTextBox.Name = "nRAxisTextBox";
            this.nRAxisTextBox.Size = new System.Drawing.Size(87, 27);
            this.nRAxisTextBox.TabIndex = 28;
            // 
            // nRcylinderLabel
            // 
            nRcylinderLabel.AutoSize = true;
            nRcylinderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nRcylinderLabel.Location = new System.Drawing.Point(420, 195);
            nRcylinderLabel.Name = "nRcylinderLabel";
            nRcylinderLabel.Size = new System.Drawing.Size(96, 20);
            nRcylinderLabel.TabIndex = 29;
            nRcylinderLabel.Text = "NRcylinder:";
            // 
            // nRcylinderTextBox
            // 
            this.nRcylinderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "NRcylinder", true));
            this.nRcylinderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRcylinderTextBox.Location = new System.Drawing.Point(632, 192);
            this.nRcylinderTextBox.Name = "nRcylinderTextBox";
            this.nRcylinderTextBox.Size = new System.Drawing.Size(87, 27);
            this.nRcylinderTextBox.TabIndex = 30;
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            commentsLabel.Location = new System.Drawing.Point(11, 255);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(95, 20);
            commentsLabel.TabIndex = 31;
            commentsLabel.Text = "Comments:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRESCRIPTIONBindingSource, "Comments", true));
            this.commentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.Location = new System.Drawing.Point(182, 252);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(537, 27);
            this.commentsTextBox.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(821, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 40);
            this.button2.TabIndex = 33;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(620, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 49);
            this.button1.TabIndex = 34;
            this.button1.Text = "Find Prescription";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(commentsLabel);
            this.groupBox1.Controls.Add(dLsphericalLabel);
            this.groupBox1.Controls.Add(this.commentsTextBox);
            this.groupBox1.Controls.Add(this.nRcylinderTextBox);
            this.groupBox1.Controls.Add(nRcylinderLabel);
            this.groupBox1.Controls.Add(this.nRAxisTextBox);
            this.groupBox1.Controls.Add(nRAxisLabel);
            this.groupBox1.Controls.Add(this.nRsphericalTextBox);
            this.groupBox1.Controls.Add(nRsphericalLabel);
            this.groupBox1.Controls.Add(this.nLcylinderTextBox);
            this.groupBox1.Controls.Add(this.dLsphericalTextBox);
            this.groupBox1.Controls.Add(nLcylinderLabel);
            this.groupBox1.Controls.Add(dLAxisLabel);
            this.groupBox1.Controls.Add(this.nLAxisTextBox);
            this.groupBox1.Controls.Add(this.dLAxisTextBox);
            this.groupBox1.Controls.Add(nLAxisLabel);
            this.groupBox1.Controls.Add(dLcylinderLabel);
            this.groupBox1.Controls.Add(this.nLsphericalTextBox);
            this.groupBox1.Controls.Add(this.dLcylinderTextBox);
            this.groupBox1.Controls.Add(nLsphericalLabel);
            this.groupBox1.Controls.Add(dRsphericalLabel);
            this.groupBox1.Controls.Add(this.dRcylinderTextBox);
            this.groupBox1.Controls.Add(this.dRsphericalTextBox);
            this.groupBox1.Controls.Add(dRcylinderLabel);
            this.groupBox1.Controls.Add(dRAxisLabel);
            this.groupBox1.Controls.Add(this.dRAxisTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(101, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 302);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescription";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // edit_prescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(pRIDLabel);
            this.Controls.Add(this.pRIDMaskedTextBox);
            this.Controls.Add(cIDLabel);
            this.Controls.Add(this.cIDMaskedTextBox);
            this.Controls.Add(date_of_issueLabel);
            this.Controls.Add(this.date_of_issueDateTimePicker);
            this.Controls.Add(this.pRESCRIPTIONBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit_prescriptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Prescriptions";
            this.Load += new System.EventHandler(this.edit_prescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESCRIPTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESCRIPTIONBindingNavigator)).EndInit();
            this.pRESCRIPTIONBindingNavigator.ResumeLayout(false);
            this.pRESCRIPTIONBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisionCenterDataSet visionCenterDataSet;
        private System.Windows.Forms.BindingSource pRESCRIPTIONBindingSource;
        private VisionCenterDataSetTableAdapters.PRESCRIPTIONTableAdapter pRESCRIPTIONTableAdapter;
        private VisionCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pRESCRIPTIONBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pRESCRIPTIONBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox pRIDMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cIDMaskedTextBox;
        private System.Windows.Forms.DateTimePicker date_of_issueDateTimePicker;
        private System.Windows.Forms.TextBox dLsphericalTextBox;
        private System.Windows.Forms.TextBox dLAxisTextBox;
        private System.Windows.Forms.TextBox dLcylinderTextBox;
        private System.Windows.Forms.TextBox dRsphericalTextBox;
        private System.Windows.Forms.TextBox dRAxisTextBox;
        private System.Windows.Forms.TextBox dRcylinderTextBox;
        private System.Windows.Forms.TextBox nLsphericalTextBox;
        private System.Windows.Forms.TextBox nLAxisTextBox;
        private System.Windows.Forms.TextBox nLcylinderTextBox;
        private System.Windows.Forms.TextBox nRsphericalTextBox;
        private System.Windows.Forms.TextBox nRAxisTextBox;
        private System.Windows.Forms.TextBox nRcylinderTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}