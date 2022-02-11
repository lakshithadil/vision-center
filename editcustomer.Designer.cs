
namespace vision_center1
{
    partial class editcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editcustomer));
            System.Windows.Forms.Label cIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label tP_NoLabel;
            System.Windows.Forms.Label adLine1Label;
            System.Windows.Forms.Label adLine2Label;
            this.visionCenterDataSet = new vision_center1.VisionCenterDataSet();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new vision_center1.VisionCenterDataSetTableAdapters.CUSTOMERTableAdapter();
            this.tableAdapterManager = new vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager();
            this.cUSTOMERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cUSTOMERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.tP_NoTextBox = new System.Windows.Forms.TextBox();
            this.adLine1TextBox = new System.Windows.Forms.TextBox();
            this.adLine2TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            cIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            tP_NoLabel = new System.Windows.Forms.Label();
            adLine1Label = new System.Windows.Forms.Label();
            adLine2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingNavigator)).BeginInit();
            this.cUSTOMERBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // visionCenterDataSet
            // 
            this.visionCenterDataSet.DataSetName = "VisionCenterDataSet";
            this.visionCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.visionCenterDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter;
            this.tableAdapterManager.FRAMETableAdapter = null;
            this.tableAdapterManager.LENSETableAdapter = null;
            this.tableAdapterManager.ORDERLINETableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = vision_center1.VisionCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cUSTOMERBindingNavigator
            // 
            this.cUSTOMERBindingNavigator.AddNewItem = null;
            this.cUSTOMERBindingNavigator.BindingSource = this.cUSTOMERBindingSource;
            this.cUSTOMERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cUSTOMERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cUSTOMERBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cUSTOMERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cUSTOMERBindingNavigatorSaveItem});
            this.cUSTOMERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cUSTOMERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cUSTOMERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cUSTOMERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cUSTOMERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cUSTOMERBindingNavigator.Name = "cUSTOMERBindingNavigator";
            this.cUSTOMERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cUSTOMERBindingNavigator.Size = new System.Drawing.Size(982, 27);
            this.cUSTOMERBindingNavigator.TabIndex = 0;
            this.cUSTOMERBindingNavigator.Text = "bindingNavigator1";
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
            // cUSTOMERBindingNavigatorSaveItem
            // 
            this.cUSTOMERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cUSTOMERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cUSTOMERBindingNavigatorSaveItem.Image")));
            this.cUSTOMERBindingNavigatorSaveItem.Name = "cUSTOMERBindingNavigatorSaveItem";
            this.cUSTOMERBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cUSTOMERBindingNavigatorSaveItem.Text = "Save Data";
            this.cUSTOMERBindingNavigatorSaveItem.Click += new System.EventHandler(this.cUSTOMERBindingNavigatorSaveItem_Click);
            // 
            // cIDLabel
            // 
            cIDLabel.AutoSize = true;
            cIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cIDLabel.Location = new System.Drawing.Point(137, 155);
            cIDLabel.Name = "cIDLabel";
            cIDLabel.Size = new System.Drawing.Size(139, 20);
            cIDLabel.TabIndex = 2;
            cIDLabel.Text = "Customer ID      :";
            // 
            // cIDMaskedTextBox
            // 
            this.cIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CID", true));
            this.cIDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cIDMaskedTextBox.Location = new System.Drawing.Point(359, 155);
            this.cIDMaskedTextBox.Name = "cIDMaskedTextBox";
            this.cIDMaskedTextBox.ReadOnly = true;
            this.cIDMaskedTextBox.Size = new System.Drawing.Size(423, 27);
            this.cIDMaskedTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(137, 212);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(137, 20);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name        :";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(359, 212);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(423, 27);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(138, 266);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(136, 20);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "Last Name        :";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(360, 266);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(423, 27);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // tP_NoLabel
            // 
            tP_NoLabel.AutoSize = true;
            tP_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tP_NoLabel.Location = new System.Drawing.Point(138, 324);
            tP_NoLabel.Name = "tP_NoLabel";
            tP_NoLabel.Size = new System.Drawing.Size(134, 20);
            tP_NoLabel.TabIndex = 8;
            tP_NoLabel.Text = "TelePhone No   :";
            // 
            // tP_NoTextBox
            // 
            this.tP_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "TP_No", true));
            this.tP_NoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tP_NoTextBox.Location = new System.Drawing.Point(360, 324);
            this.tP_NoTextBox.Name = "tP_NoTextBox";
            this.tP_NoTextBox.Size = new System.Drawing.Size(423, 27);
            this.tP_NoTextBox.TabIndex = 9;
            // 
            // adLine1Label
            // 
            adLine1Label.AutoSize = true;
            adLine1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adLine1Label.Location = new System.Drawing.Point(137, 378);
            adLine1Label.Name = "adLine1Label";
            adLine1Label.Size = new System.Drawing.Size(132, 20);
            adLine1Label.TabIndex = 10;
            adLine1Label.Text = "Address Line1  :";
            // 
            // adLine1TextBox
            // 
            this.adLine1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "AdLine1", true));
            this.adLine1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adLine1TextBox.Location = new System.Drawing.Point(359, 378);
            this.adLine1TextBox.Name = "adLine1TextBox";
            this.adLine1TextBox.Size = new System.Drawing.Size(423, 27);
            this.adLine1TextBox.TabIndex = 11;
            // 
            // adLine2Label
            // 
            adLine2Label.AutoSize = true;
            adLine2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adLine2Label.Location = new System.Drawing.Point(137, 433);
            adLine2Label.Name = "adLine2Label";
            adLine2Label.Size = new System.Drawing.Size(132, 20);
            adLine2Label.TabIndex = 12;
            adLine2Label.Text = "Address Line2  :";
            // 
            // adLine2TextBox
            // 
            this.adLine2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "AdLine2", true));
            this.adLine2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adLine2TextBox.Location = new System.Drawing.Point(359, 433);
            this.adLine2TextBox.Name = "adLine2TextBox";
            this.adLine2TextBox.Size = new System.Drawing.Size(423, 27);
            this.adLine2TextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(359, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(423, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Find customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(821, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // editcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cIDLabel);
            this.Controls.Add(this.cIDMaskedTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(tP_NoLabel);
            this.Controls.Add(this.tP_NoTextBox);
            this.Controls.Add(adLine1Label);
            this.Controls.Add(this.adLine1TextBox);
            this.Controls.Add(adLine2Label);
            this.Controls.Add(this.adLine2TextBox);
            this.Controls.Add(this.cUSTOMERBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.editcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visionCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingNavigator)).EndInit();
            this.cUSTOMERBindingNavigator.ResumeLayout(false);
            this.cUSTOMERBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisionCenterDataSet visionCenterDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private VisionCenterDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private VisionCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cUSTOMERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cUSTOMERBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox cIDMaskedTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox tP_NoTextBox;
        private System.Windows.Forms.TextBox adLine1TextBox;
        private System.Windows.Forms.TextBox adLine2TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}