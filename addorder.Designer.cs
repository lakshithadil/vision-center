
namespace vision_center1
{
    partial class addorder
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
            System.Windows.Forms.Label oIDLabel;
            System.Windows.Forms.Label cIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label sPECTACLELabel;
            System.Windows.Forms.Label sUNGLASSLabel;
            System.Windows.Forms.Label aCCESSORIESLabel;
            System.Windows.Forms.Label rEPAIRLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addorder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rEPAIRCheckBox = new System.Windows.Forms.CheckBox();
            this.oRDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visionCenterDataSet = new vision_center1.VisionCenterDataSet();
            this.aCCESSORIESCheckBox = new System.Windows.Forms.CheckBox();
            this.sUNGLASSCheckBox = new System.Windows.Forms.CheckBox();
            this.sPECTACLECheckBox = new System.Windows.Forms.CheckBox();
            this.oIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oRDERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oRDERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oRDERTableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.ORDERTableAdapter();
            this.tableAdapterManager = new vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager();
            oIDLabel = new System.Windows.Forms.Label();
            cIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            sPECTACLELabel = new System.Windows.Forms.Label();
            sUNGLASSLabel = new System.Windows.Forms.Label();
            aCCESSORIESLabel = new System.Windows.Forms.Label();
            rEPAIRLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingNavigator)).BeginInit();
            this.oRDERBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // oIDLabel
            // 
            oIDLabel.AutoSize = true;
            oIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            oIDLabel.Location = new System.Drawing.Point(172, 129);
            oIDLabel.Name = "oIDLabel";
            oIDLabel.Size = new System.Drawing.Size(139, 20);
            oIDLabel.TabIndex = 15;
            oIDLabel.Text = "Order ID            :";
            // 
            // cIDLabel
            // 
            cIDLabel.AutoSize = true;
            cIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cIDLabel.Location = new System.Drawing.Point(172, 192);
            cIDLabel.Name = "cIDLabel";
            cIDLabel.Size = new System.Drawing.Size(139, 20);
            cIDLabel.TabIndex = 17;
            cIDLabel.Text = "Customer ID      :";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderDateLabel.Location = new System.Drawing.Point(172, 255);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(138, 20);
            orderDateLabel.TabIndex = 19;
            orderDateLabel.Text = "Order Date        :";
            // 
            // sPECTACLELabel
            // 
            sPECTACLELabel.AutoSize = true;
            sPECTACLELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sPECTACLELabel.Location = new System.Drawing.Point(187, 43);
            sPECTACLELabel.Name = "sPECTACLELabel";
            sPECTACLELabel.Size = new System.Drawing.Size(128, 20);
            sPECTACLELabel.TabIndex = 21;
            sPECTACLELabel.Text = "SPECTACLE   :";
            // 
            // sUNGLASSLabel
            // 
            sUNGLASSLabel.AutoSize = true;
            sUNGLASSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sUNGLASSLabel.Location = new System.Drawing.Point(187, 95);
            sUNGLASSLabel.Name = "sUNGLASSLabel";
            sUNGLASSLabel.Size = new System.Drawing.Size(125, 20);
            sUNGLASSLabel.TabIndex = 23;
            sUNGLASSLabel.Text = "SUNGLASS    :";
            // 
            // aCCESSORIESLabel
            // 
            aCCESSORIESLabel.AutoSize = true;
            aCCESSORIESLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aCCESSORIESLabel.Location = new System.Drawing.Point(396, 43);
            aCCESSORIESLabel.Name = "aCCESSORIESLabel";
            aCCESSORIESLabel.Size = new System.Drawing.Size(143, 20);
            aCCESSORIESLabel.TabIndex = 25;
            aCCESSORIESLabel.Text = "ACCESSORIES  :";
            // 
            // rEPAIRLabel
            // 
            rEPAIRLabel.AutoSize = true;
            rEPAIRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rEPAIRLabel.Location = new System.Drawing.Point(396, 94);
            rEPAIRLabel.Name = "rEPAIRLabel";
            rEPAIRLabel.Size = new System.Drawing.Size(145, 20);
            rEPAIRLabel.TabIndex = 27;
            rEPAIRLabel.Text = "REPAIR              :";
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
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(oIDLabel);
            this.panel2.Controls.Add(this.oIDMaskedTextBox);
            this.panel2.Controls.Add(cIDLabel);
            this.panel2.Controls.Add(this.cIDMaskedTextBox);
            this.panel2.Controls.Add(orderDateLabel);
            this.panel2.Controls.Add(this.orderDateDateTimePicker);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.oRDERBindingNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 553);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sPECTACLELabel);
            this.groupBox1.Controls.Add(this.rEPAIRCheckBox);
            this.groupBox1.Controls.Add(rEPAIRLabel);
            this.groupBox1.Controls.Add(this.aCCESSORIESCheckBox);
            this.groupBox1.Controls.Add(aCCESSORIESLabel);
            this.groupBox1.Controls.Add(this.sUNGLASSCheckBox);
            this.groupBox1.Controls.Add(sUNGLASSLabel);
            this.groupBox1.Controls.Add(this.sPECTACLECheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(166, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 159);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Type";
            // 
            // rEPAIRCheckBox
            // 
            this.rEPAIRCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.oRDERBindingSource, "REPAIR", true));
            this.rEPAIRCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEPAIRCheckBox.Location = new System.Drawing.Point(574, 94);
            this.rEPAIRCheckBox.Name = "rEPAIRCheckBox";
            this.rEPAIRCheckBox.Size = new System.Drawing.Size(40, 24);
            this.rEPAIRCheckBox.TabIndex = 28;
            this.rEPAIRCheckBox.UseVisualStyleBackColor = true;
            // 
            // oRDERBindingSource
            // 
            this.oRDERBindingSource.DataMember = "ORDER";
            this.oRDERBindingSource.DataSource = this.visionCenterDataSet;
            // 
            // visionCenterDataSet
            // 
            this.visionCenterDataSet.DataSetName = "VisionCenterDataSet";
            this.visionCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCCESSORIESCheckBox
            // 
            this.aCCESSORIESCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.oRDERBindingSource, "ACCESSORIES", true));
            this.aCCESSORIESCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCCESSORIESCheckBox.Location = new System.Drawing.Point(574, 42);
            this.aCCESSORIESCheckBox.Name = "aCCESSORIESCheckBox";
            this.aCCESSORIESCheckBox.Size = new System.Drawing.Size(40, 24);
            this.aCCESSORIESCheckBox.TabIndex = 26;
            this.aCCESSORIESCheckBox.UseVisualStyleBackColor = true;
            // 
            // sUNGLASSCheckBox
            // 
            this.sUNGLASSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.oRDERBindingSource, "SUNGLASS", true));
            this.sUNGLASSCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUNGLASSCheckBox.Location = new System.Drawing.Point(327, 94);
            this.sUNGLASSCheckBox.Name = "sUNGLASSCheckBox";
            this.sUNGLASSCheckBox.Size = new System.Drawing.Size(49, 24);
            this.sUNGLASSCheckBox.TabIndex = 24;
            this.sUNGLASSCheckBox.UseVisualStyleBackColor = true;
            // 
            // sPECTACLECheckBox
            // 
            this.sPECTACLECheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.oRDERBindingSource, "SPECTACLE", true));
            this.sPECTACLECheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPECTACLECheckBox.Location = new System.Drawing.Point(327, 41);
            this.sPECTACLECheckBox.Name = "sPECTACLECheckBox";
            this.sPECTACLECheckBox.Size = new System.Drawing.Size(63, 24);
            this.sPECTACLECheckBox.TabIndex = 22;
            this.sPECTACLECheckBox.UseVisualStyleBackColor = true;
            // 
            // oIDMaskedTextBox
            // 
            this.oIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERBindingSource, "OID", true));
            this.oIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oIDMaskedTextBox.Location = new System.Drawing.Point(357, 126);
            this.oIDMaskedTextBox.Name = "oIDMaskedTextBox";
            this.oIDMaskedTextBox.Size = new System.Drawing.Size(423, 27);
            this.oIDMaskedTextBox.TabIndex = 16;
            // 
            // cIDMaskedTextBox
            // 
            this.cIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERBindingSource, "CID", true));
            this.cIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cIDMaskedTextBox.Location = new System.Drawing.Point(357, 185);
            this.cIDMaskedTextBox.Name = "cIDMaskedTextBox";
            this.cIDMaskedTextBox.Size = new System.Drawing.Size(423, 27);
            this.cIDMaskedTextBox.TabIndex = 18;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oRDERBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(357, 250);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(423, 27);
            this.orderDateDateTimePicker.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(821, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "ENTER ORDER DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oRDERBindingNavigator
            // 
            this.oRDERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oRDERBindingNavigator.BindingSource = this.oRDERBindingSource;
            this.oRDERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oRDERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oRDERBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.oRDERBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.oRDERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oRDERBindingNavigatorSaveItem});
            this.oRDERBindingNavigator.Location = new System.Drawing.Point(589, 20);
            this.oRDERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oRDERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oRDERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oRDERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oRDERBindingNavigator.Name = "oRDERBindingNavigator";
            this.oRDERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oRDERBindingNavigator.Size = new System.Drawing.Size(331, 31);
            this.oRDERBindingNavigator.TabIndex = 1;
            this.oRDERBindingNavigator.Text = "bindingNavigator1";
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
            // oRDERBindingNavigatorSaveItem
            // 
            this.oRDERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oRDERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oRDERBindingNavigatorSaveItem.Image")));
            this.oRDERBindingNavigatorSaveItem.Name = "oRDERBindingNavigatorSaveItem";
            this.oRDERBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.oRDERBindingNavigatorSaveItem.Text = "Save Data";
            this.oRDERBindingNavigatorSaveItem.Click += new System.EventHandler(this.oRDERBindingNavigatorSaveItem_Click);
            // 
            // oRDERTableAdapter
            // 
            this.oRDERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.FRAMETableAdapter = null;
            this.tableAdapterManager.LENSETableAdapter = null;
            this.tableAdapterManager.ORDERLINETableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = this.oRDERTableAdapter;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // addorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Name = "addorder";
            this.Text = "addorder";
            this.Load += new System.EventHandler(this.addorder_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingNavigator)).EndInit();
            this.oRDERBindingNavigator.ResumeLayout(false);
            this.oRDERBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private VisionCenterDataSet visionCenterDataSet;
        private System.Windows.Forms.BindingSource oRDERBindingSource;
        private VisionCenterDataSetTableAdapters.ORDERTableAdapter oRDERTableAdapter;
        private VisionCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oRDERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oRDERBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox oIDMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cIDMaskedTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.CheckBox sPECTACLECheckBox;
        private System.Windows.Forms.CheckBox sUNGLASSCheckBox;
        private System.Windows.Forms.CheckBox aCCESSORIESCheckBox;
        private System.Windows.Forms.CheckBox rEPAIRCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}