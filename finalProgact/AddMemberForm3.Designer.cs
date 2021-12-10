namespace finalProgact
{
    partial class AddMemberForm3
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
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddMember = new System.Windows.Forms.Label();
            this.tBoxSurName = new System.Windows.Forms.TextBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filldData = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblPathImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // lblAddMember
            // 
            this.lblAddMember.AutoSize = true;
            this.lblAddMember.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMember.Location = new System.Drawing.Point(76, 14);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(302, 53);
            this.lblAddMember.TabIndex = 5;
            this.lblAddMember.Text = "Add Member";
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
            // tBoxPhone
            // 
            this.tBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPhone.Location = new System.Drawing.Point(187, 181);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(214, 30);
            this.tBoxPhone.TabIndex = 11;
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(187, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::finalProgact.Properties.Resources.addmember;
            this.pictureBox1.Location = new System.Drawing.Point(124, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.groupBox1.Size = new System.Drawing.Size(444, 302);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblUpload);
            this.groupBox2.Controls.Add(this.filldData);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tBoxPhone);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.tBoxSurName);
            this.groupBox2.Controls.Add(this.lblSurName);
            this.groupBox2.Controls.Add(this.tBoxName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 382);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // filldData
            // 
            this.filldData.AutoSize = true;
            this.filldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filldData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filldData.Location = new System.Drawing.Point(82, 329);
            this.filldData.Name = "filldData";
            this.filldData.Size = new System.Drawing.Size(227, 25);
            this.filldData.TabIndex = 15;
            this.filldData.Text = "All data must be filled out";
            this.filldData.Visible = false;
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
            // AddMemberForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 684);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddMemberForm3";
            this.Text = "AddMemberForm3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddMember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBoxSurName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label filldData;
        private System.Windows.Forms.Label lblPathImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUpload;

    }
}