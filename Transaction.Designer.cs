
namespace vision_center1
{
    partial class Transaction
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
            System.Windows.Forms.Label tIDLabel;
            System.Windows.Forms.Label oIDLabel;
            System.Windows.Forms.Label full_AmountLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label paid_DateLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label after_discount_balanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.visionCenterDataSet = new vision_center1.VisionCenterDataSet();
            this.tRANSACTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANSACTIONTableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.TRANSACTIONTableAdapter();
            this.tableAdapterManager = new vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager();
            this.tRANSACTIONBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.tRANSACTIONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.oIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.full_AmountTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.paid_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.after_discount_balanceTextBox = new System.Windows.Forms.TextBox();
            tIDLabel = new System.Windows.Forms.Label();
            oIDLabel = new System.Windows.Forms.Label();
            full_AmountLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            paid_DateLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            after_discount_balanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONBindingNavigator)).BeginInit();
            this.tRANSACTIONBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tIDLabel
            // 
            tIDLabel.AutoSize = true;
            tIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tIDLabel.Location = new System.Drawing.Point(123, 75);
            tIDLabel.Name = "tIDLabel";
            tIDLabel.Size = new System.Drawing.Size(209, 20);
            tIDLabel.TabIndex = 1;
            tIDLabel.Text = "Transaction ID                 :";
            // 
            // oIDLabel
            // 
            oIDLabel.AutoSize = true;
            oIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            oIDLabel.Location = new System.Drawing.Point(123, 128);
            oIDLabel.Name = "oIDLabel";
            oIDLabel.Size = new System.Drawing.Size(204, 20);
            oIDLabel.TabIndex = 3;
            oIDLabel.Text = "Order ID                         :";
            // 
            // full_AmountLabel
            // 
            full_AmountLabel.AutoSize = true;
            full_AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            full_AmountLabel.Location = new System.Drawing.Point(123, 182);
            full_AmountLabel.Name = "full_AmountLabel";
            full_AmountLabel.Size = new System.Drawing.Size(203, 20);
            full_AmountLabel.TabIndex = 5;
            full_AmountLabel.Text = "Full Amount(LKR)           :";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discountLabel.Location = new System.Drawing.Point(123, 240);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(203, 20);
            discountLabel.TabIndex = 7;
            discountLabel.Text = "Discount(%)                   :";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paymentLabel.Location = new System.Drawing.Point(123, 342);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(199, 20);
            paymentLabel.TabIndex = 9;
            paymentLabel.Text = "Payment(LKR)               :";
            // 
            // paid_DateLabel
            // 
            paid_DateLabel.AutoSize = true;
            paid_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paid_DateLabel.Location = new System.Drawing.Point(123, 400);
            paid_DateLabel.Name = "paid_DateLabel";
            paid_DateLabel.Size = new System.Drawing.Size(198, 20);
            paid_DateLabel.TabIndex = 11;
            paid_DateLabel.Text = "Paid Date                      :";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            balanceLabel.Location = new System.Drawing.Point(123, 451);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(200, 20);
            balanceLabel.TabIndex = 13;
            balanceLabel.Text = "Balance(LKR)                :";
            // 
            // after_discount_balanceLabel
            // 
            after_discount_balanceLabel.AutoSize = true;
            after_discount_balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            after_discount_balanceLabel.Location = new System.Drawing.Point(123, 293);
            after_discount_balanceLabel.Name = "after_discount_balanceLabel";
            after_discount_balanceLabel.Size = new System.Drawing.Size(203, 20);
            after_discount_balanceLabel.TabIndex = 17;
            after_discount_balanceLabel.Text = "After discount(LKR)        :";
            // 
            // visionCenterDataSet
            // 
            this.visionCenterDataSet.DataSetName = "VisionCenterDataSet";
            this.visionCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRANSACTIONBindingSource
            // 
            this.tRANSACTIONBindingSource.DataMember = "TRANSACTION";
            this.tRANSACTIONBindingSource.DataSource = this.visionCenterDataSet;
            // 
            // tRANSACTIONTableAdapter
            // 
            this.tRANSACTIONTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONTableAdapter = this.tRANSACTIONTableAdapter;
            this.tableAdapterManager.UpdateOrder = vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // tRANSACTIONBindingNavigator
            // 
            this.tRANSACTIONBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tRANSACTIONBindingNavigator.BindingSource = this.tRANSACTIONBindingSource;
            this.tRANSACTIONBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tRANSACTIONBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tRANSACTIONBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tRANSACTIONBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tRANSACTIONBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tRANSACTIONBindingNavigatorSaveItem});
            this.tRANSACTIONBindingNavigator.Location = new System.Drawing.Point(524, 11);
            this.tRANSACTIONBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tRANSACTIONBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tRANSACTIONBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tRANSACTIONBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tRANSACTIONBindingNavigator.Name = "tRANSACTIONBindingNavigator";
            this.tRANSACTIONBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tRANSACTIONBindingNavigator.Size = new System.Drawing.Size(331, 31);
            this.tRANSACTIONBindingNavigator.TabIndex = 0;
            this.tRANSACTIONBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // tRANSACTIONBindingNavigatorSaveItem
            // 
            this.tRANSACTIONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tRANSACTIONBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tRANSACTIONBindingNavigatorSaveItem.Image")));
            this.tRANSACTIONBindingNavigatorSaveItem.Name = "tRANSACTIONBindingNavigatorSaveItem";
            this.tRANSACTIONBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.tRANSACTIONBindingNavigatorSaveItem.Text = "Save Data";
            this.tRANSACTIONBindingNavigatorSaveItem.Click += new System.EventHandler(this.tRANSACTIONBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 553);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(tIDLabel);
            this.panel2.Controls.Add(this.tIDMaskedTextBox);
            this.panel2.Controls.Add(oIDLabel);
            this.panel2.Controls.Add(this.oIDMaskedTextBox);
            this.panel2.Controls.Add(full_AmountLabel);
            this.panel2.Controls.Add(this.full_AmountTextBox);
            this.panel2.Controls.Add(discountLabel);
            this.panel2.Controls.Add(this.discountTextBox);
            this.panel2.Controls.Add(paymentLabel);
            this.panel2.Controls.Add(this.paymentTextBox);
            this.panel2.Controls.Add(paid_DateLabel);
            this.panel2.Controls.Add(this.paid_DateDateTimePicker);
            this.panel2.Controls.Add(balanceLabel);
            this.panel2.Controls.Add(this.balanceTextBox);
            this.panel2.Controls.Add(after_discount_balanceLabel);
            this.panel2.Controls.Add(this.after_discount_balanceTextBox);
            this.panel2.Controls.Add(this.tRANSACTIONBindingNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 553);
            this.panel2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(821, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Finish";
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
            this.label1.Size = new System.Drawing.Size(314, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "ENTER TRANSACTION DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tIDMaskedTextBox
            // 
            this.tIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONBindingSource, "TID", true));
            this.tIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIDMaskedTextBox.Location = new System.Drawing.Point(393, 75);
            this.tIDMaskedTextBox.Name = "tIDMaskedTextBox";
            this.tIDMaskedTextBox.Size = new System.Drawing.Size(423, 27);
            this.tIDMaskedTextBox.TabIndex = 2;
            // 
            // oIDMaskedTextBox
            // 
            this.oIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONBindingSource, "OID", true));
            this.oIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oIDMaskedTextBox.Location = new System.Drawing.Point(393, 128);
            this.oIDMaskedTextBox.Name = "oIDMaskedTextBox";
            this.oIDMaskedTextBox.Size = new System.Drawing.Size(423, 27);
            this.oIDMaskedTextBox.TabIndex = 4;
            // 
            // full_AmountTextBox
            // 
            this.full_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONBindingSource, "Full Amount", true));
            this.full_AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_AmountTextBox.Location = new System.Drawing.Point(393, 182);
            this.full_AmountTextBox.Name = "full_AmountTextBox";
            this.full_AmountTextBox.Size = new System.Drawing.Size(423, 27);
            this.full_AmountTextBox.TabIndex = 6;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONBindingSource, "Discount", true));
            this.discountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(393, 240);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(423, 27);
            this.discountTextBox.TabIndex = 8;
            this.discountTextBox.TextChanged += new System.EventHandler(this.discountTextBox_TextChanged);
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONBindingSource, "Payment", true));
            this.paymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTextBox.Location = new System.Drawing.Point(393, 342);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(423, 27);
            this.paymentTextBox.TabIndex = 10;
            this.paymentTextBox.TextChanged += new System.EventHandler(this.paymentTextBox_TextChanged);
            // 
            // paid_DateDateTimePicker
            // 
            this.paid_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tRANSACTIONBindingSource, "Paid Date", true));
            this.paid_DateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_DateDateTimePicker.Location = new System.Drawing.Point(393, 399);
            this.paid_DateDateTimePicker.Name = "paid_DateDateTimePicker";
            this.paid_DateDateTimePicker.Size = new System.Drawing.Size(423, 27);
            this.paid_DateDateTimePicker.TabIndex = 12;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONBindingSource, "Balance", true));
            this.balanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTextBox.Location = new System.Drawing.Point(393, 451);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(423, 27);
            this.balanceTextBox.TabIndex = 14;
            // 
            // after_discount_balanceTextBox
            // 
            this.after_discount_balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONBindingSource, "After discount balance", true));
            this.after_discount_balanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.after_discount_balanceTextBox.Location = new System.Drawing.Point(393, 293);
            this.after_discount_balanceTextBox.Name = "after_discount_balanceTextBox";
            this.after_discount_balanceTextBox.Size = new System.Drawing.Size(423, 27);
            this.after_discount_balanceTextBox.TabIndex = 18;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONBindingNavigator)).EndInit();
            this.tRANSACTIONBindingNavigator.ResumeLayout(false);
            this.tRANSACTIONBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VisionCenterDataSet visionCenterDataSet;
        private System.Windows.Forms.BindingSource tRANSACTIONBindingSource;
        private VisionCenterDataSetTableAdapters.TRANSACTIONTableAdapter tRANSACTIONTableAdapter;
        private VisionCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tRANSACTIONBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tRANSACTIONBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox tIDMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox oIDMaskedTextBox;
        private System.Windows.Forms.TextBox full_AmountTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.DateTimePicker paid_DateDateTimePicker;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox after_discount_balanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}