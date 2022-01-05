namespace finalProgact
{
    partial class DisplayMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayMember));
            this.filldData = new System.Windows.Forms.Label();
            this.lblPathImage = new System.Windows.Forms.Label();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butDelet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUpload = new System.Windows.Forms.Label();
            this.butUpdate = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tBoxSurName = new System.Windows.Forms.TextBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddMember = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filldData
            // 
            this.filldData.AutoSize = true;
            this.filldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filldData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filldData.Location = new System.Drawing.Point(101, 385);
            this.filldData.Name = "filldData";
            this.filldData.Size = new System.Drawing.Size(227, 25);
            this.filldData.TabIndex = 15;
            this.filldData.Text = "All data must be filled out";
            this.filldData.Visible = false;
            this.filldData.Click += new System.EventHandler(this.filldData_Click);
            // 
            // lblPathImage
            // 
            this.lblPathImage.AutoSize = true;
            this.lblPathImage.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathImage.Location = new System.Drawing.Point(56, 249);
            this.lblPathImage.Name = "lblPathImage";
            this.lblPathImage.Size = new System.Drawing.Size(0, 53);
            this.lblPathImage.TabIndex = 6;
            this.lblPathImage.Visible = false;
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPhone.Location = new System.Drawing.Point(187, 181);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(214, 30);
            this.tBoxPhone.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.tBoxUserName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.butDelet);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblUpload);
            this.groupBox2.Controls.Add(this.filldData);
            this.groupBox2.Controls.Add(this.butUpdate);
            this.groupBox2.Controls.Add(this.tBoxPhone);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.tBoxSurName);
            this.groupBox2.Controls.Add(this.lblSurName);
            this.groupBox2.Controls.Add(this.tBoxName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 433);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // tBoxUserName
            // 
            this.tBoxUserName.Enabled = false;
            this.tBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUserName.Location = new System.Drawing.Point(187, 21);
            this.tBoxUserName.Name = "tBoxUserName";
            this.tBoxUserName.ReadOnly = true;
            this.tBoxUserName.Size = new System.Drawing.Size(214, 30);
            this.tBoxUserName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "UserName:";
            // 
            // butDelet
            // 
            this.butDelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelet.Location = new System.Drawing.Point(187, 311);
            this.butDelet.Name = "butDelet";
            this.butDelet.Size = new System.Drawing.Size(214, 34);
            this.butDelet.TabIndex = 19;
            this.butDelet.Text = "Delete";
            this.butDelet.UseVisualStyleBackColor = true;
            this.butDelet.Click += new System.EventHandler(this.butDelet_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpload.Location = new System.Drawing.Point(21, 232);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(87, 25);
            this.lblUpload.TabIndex = 16;
            this.lblUpload.Text = "Upload:";
            // 
            // butUpdate
            // 
            this.butUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Location = new System.Drawing.Point(187, 347);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(214, 34);
            this.butUpdate.TabIndex = 13;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(21, 181);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(81, 25);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone:";
            // 
            // tBoxSurName
            // 
            this.tBoxSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSurName.Location = new System.Drawing.Point(187, 131);
            this.tBoxSurName.Name = "tBoxSurName";
            this.tBoxSurName.Size = new System.Drawing.Size(214, 30);
            this.tBoxSurName.TabIndex = 9;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurName.Location = new System.Drawing.Point(21, 131);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(109, 25);
            this.lblSurName.TabIndex = 8;
            this.lblSurName.Text = "SurName:";
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxName.Location = new System.Drawing.Point(187, 79);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(214, 30);
            this.tBoxName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(21, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 25);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.lblPathImage);
            this.groupBox1.Controls.Add(this.lblAddMember);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 302);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblAddMember
            // 
            this.lblAddMember.AutoSize = true;
            this.lblAddMember.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMember.Location = new System.Drawing.Point(38, 14);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(382, 53);
            this.lblAddMember.TabIndex = 5;
            this.lblAddMember.Text = "Display Member";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DisplayMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 735);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayMember";
            this.Text = "Display Member";
            this.Load += new System.EventHandler(this.DisplayMember_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label filldData;
        private System.Windows.Forms.Label lblPathImage;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tBoxSurName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddMember;
        private System.Windows.Forms.Button butDelet;
        private System.Windows.Forms.TextBox tBoxUserName;
        private System.Windows.Forms.Label label1;
    }
}