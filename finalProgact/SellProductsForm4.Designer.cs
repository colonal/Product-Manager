namespace finalProgact
{
    partial class SellProductsForm4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comQuantity = new System.Windows.Forms.ComboBox();
            this.comBoxMember = new System.Windows.Forms.ComboBox();
            this.comBoxProduct = new System.Windows.Forms.ComboBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.filldData = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.lblAddProduct);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 320);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(53, 9);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(278, 53);
            this.lblAddProduct.TabIndex = 5;
            this.lblAddProduct.Text = "Sell Product";
            this.lblAddProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::finalProgact.Properties.Resources.shop;
            this.pictureBox1.Location = new System.Drawing.Point(82, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.filldData);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comQuantity);
            this.groupBox2.Controls.Add(this.comBoxMember);
            this.groupBox2.Controls.Add(this.comBoxProduct);
            this.groupBox2.Controls.Add(this.lblMember);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.lblProduct);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 286);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(173, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comQuantity
            // 
            this.comQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comQuantity.FormattingEnabled = true;
            this.comQuantity.Location = new System.Drawing.Point(173, 147);
            this.comQuantity.Name = "comQuantity";
            this.comQuantity.Size = new System.Drawing.Size(214, 33);
            this.comQuantity.TabIndex = 8;
            // 
            // comBoxMember
            // 
            this.comBoxMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMember.FormattingEnabled = true;
            this.comBoxMember.Location = new System.Drawing.Point(173, 93);
            this.comBoxMember.Name = "comBoxMember";
            this.comBoxMember.Size = new System.Drawing.Size(214, 33);
            this.comBoxMember.TabIndex = 7;
            // 
            // comBoxProduct
            // 
            this.comBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxProduct.FormattingEnabled = true;
            this.comBoxProduct.Location = new System.Drawing.Point(173, 44);
            this.comBoxProduct.Name = "comBoxProduct";
            this.comBoxProduct.Size = new System.Drawing.Size(214, 33);
            this.comBoxProduct.TabIndex = 6;
            this.comBoxProduct.SelectedValueChanged += new System.EventHandler(this.comBoxProduct_SelectedValueChanged);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(18, 93);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(97, 25);
            this.lblMember.TabIndex = 5;
            this.lblMember.Text = "Member:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(18, 147);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 25);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(18, 44);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(93, 25);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product:";
            // 
            // filldData
            // 
            this.filldData.AutoSize = true;
            this.filldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filldData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filldData.Location = new System.Drawing.Point(83, 252);
            this.filldData.Name = "filldData";
            this.filldData.Size = new System.Drawing.Size(227, 25);
            this.filldData.TabIndex = 14;
            this.filldData.Text = "All data must be filled out";
            this.filldData.Visible = false;
            // 
            // SellProductsForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SellProductsForm4";
            this.Text = "SellProductsForm4";
            this.Load += new System.EventHandler(this.SellProductsForm4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox comQuantity;
        private System.Windows.Forms.ComboBox comBoxMember;
        private System.Windows.Forms.ComboBox comBoxProduct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label filldData;

    }
}