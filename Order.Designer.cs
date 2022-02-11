
namespace vision_center1
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonplaceanorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(853, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonplaceanorder
            // 
            this.buttonplaceanorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonplaceanorder.FlatAppearance.BorderSize = 5;
            this.buttonplaceanorder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonplaceanorder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonplaceanorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonplaceanorder.ForeColor = System.Drawing.Color.Wheat;
            this.buttonplaceanorder.Image = ((System.Drawing.Image)(resources.GetObject("buttonplaceanorder.Image")));
            this.buttonplaceanorder.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonplaceanorder.Location = new System.Drawing.Point(65, 392);
            this.buttonplaceanorder.Name = "buttonplaceanorder";
            this.buttonplaceanorder.Size = new System.Drawing.Size(278, 50);
            this.buttonplaceanorder.TabIndex = 4;
            this.buttonplaceanorder.Text = "PLACE AN ORDER";
            this.buttonplaceanorder.UseVisualStyleBackColor = true;
            this.buttonplaceanorder.Click += new System.EventHandler(this.buttonplaceanorder_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(923, 510);
            this.Controls.Add(this.buttonplaceanorder);
            this.Controls.Add(this.label2);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonplaceanorder;
    }
}