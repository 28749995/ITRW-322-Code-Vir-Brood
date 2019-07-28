namespace WindowsFormsApp1
{
    partial class frm_Contact_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Contact_Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picbx_Contact = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Message = new System.Windows.Forms.Button();
            this.mtxtbx_Mobile_Number = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_Full_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Contact)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 73);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact\'s profile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Message);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.picbx_Contact);
            this.groupBox1.Location = new System.Drawing.Point(6, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // picbx_Contact
            // 
            this.picbx_Contact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbx_Contact.Location = new System.Drawing.Point(6, 19);
            this.picbx_Contact.Name = "picbx_Contact";
            this.picbx_Contact.Size = new System.Drawing.Size(128, 128);
            this.picbx_Contact.TabIndex = 11;
            this.picbx_Contact.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxtbx_Mobile_Number);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbx_Email);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbx_Username);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbx_Full_Name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(140, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 248);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btn_Message
            // 
            this.btn_Message.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Message.Location = new System.Drawing.Point(6, 189);
            this.btn_Message.Name = "btn_Message";
            this.btn_Message.Size = new System.Drawing.Size(128, 62);
            this.btn_Message.TabIndex = 13;
            this.btn_Message.Text = "Message";
            this.btn_Message.UseVisualStyleBackColor = true;
            this.btn_Message.Click += new System.EventHandler(this.btn_Message_Click);
            // 
            // mtxtbx_Mobile_Number
            // 
            this.mtxtbx_Mobile_Number.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.mtxtbx_Mobile_Number.Location = new System.Drawing.Point(10, 187);
            this.mtxtbx_Mobile_Number.Mask = "(999) 000-0000";
            this.mtxtbx_Mobile_Number.Name = "mtxtbx_Mobile_Number";
            this.mtxtbx_Mobile_Number.ReadOnly = true;
            this.mtxtbx_Mobile_Number.Size = new System.Drawing.Size(210, 22);
            this.mtxtbx_Mobile_Number.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mobile Number";
            // 
            // txtbx_Email
            // 
            this.txtbx_Email.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Email.Location = new System.Drawing.Point(10, 138);
            this.txtbx_Email.Name = "txtbx_Email";
            this.txtbx_Email.ReadOnly = true;
            this.txtbx_Email.Size = new System.Drawing.Size(210, 22);
            this.txtbx_Email.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username.Location = new System.Drawing.Point(10, 89);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.ReadOnly = true;
            this.txtbx_Username.Size = new System.Drawing.Size(210, 22);
            this.txtbx_Username.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // txtbx_Full_Name
            // 
            this.txtbx_Full_Name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Full_Name.Location = new System.Drawing.Point(10, 40);
            this.txtbx_Full_Name.Name = "txtbx_Full_Name";
            this.txtbx_Full_Name.ReadOnly = true;
            this.txtbx_Full_Name.Size = new System.Drawing.Size(210, 22);
            this.txtbx_Full_Name.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full Name";
            // 
            // frm_Contact_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Contact_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Contact)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Message;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picbx_Contact;
        private System.Windows.Forms.MaskedTextBox mtxtbx_Mobile_Number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_Full_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}