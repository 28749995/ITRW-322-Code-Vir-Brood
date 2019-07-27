namespace WindowsFormsApp1
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpbx_Login = new System.Windows.Forms.GroupBox();
            this.btn_L_Create = new System.Windows.Forms.Button();
            this.btn_Sign_In = new System.Windows.Forms.Button();
            this.txtbx_Password_Login = new System.Windows.Forms.TextBox();
            this.txtbx_Username_Login = new System.Windows.Forms.TextBox();
            this.txtbx_Password = new System.Windows.Forms.Label();
            this.txtbx_Username = new System.Windows.Forms.Label();
            this.grpbx_Create = new System.Windows.Forms.GroupBox();
            this.btn_C_Login = new System.Windows.Forms.Button();
            this.txtbx_Email_Create = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_Password_Confirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Sign_Up = new System.Windows.Forms.Button();
            this.txtbx_Password_create = new System.Windows.Forms.TextBox();
            this.txtbx_Username_Create = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbx_Login.SuspendLayout();
            this.grpbx_Create.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpbx_Login
            // 
            this.grpbx_Login.Controls.Add(this.btn_L_Create);
            this.grpbx_Login.Controls.Add(this.btn_Sign_In);
            this.grpbx_Login.Controls.Add(this.txtbx_Password_Login);
            this.grpbx_Login.Controls.Add(this.txtbx_Username_Login);
            this.grpbx_Login.Controls.Add(this.txtbx_Password);
            this.grpbx_Login.Controls.Add(this.txtbx_Username);
            this.grpbx_Login.Location = new System.Drawing.Point(12, 165);
            this.grpbx_Login.Name = "grpbx_Login";
            this.grpbx_Login.Size = new System.Drawing.Size(402, 177);
            this.grpbx_Login.TabIndex = 1;
            this.grpbx_Login.TabStop = false;
            this.grpbx_Login.Text = "Login";
            // 
            // btn_L_Create
            // 
            this.btn_L_Create.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_L_Create.Location = new System.Drawing.Point(6, 136);
            this.btn_L_Create.Name = "btn_L_Create";
            this.btn_L_Create.Size = new System.Drawing.Size(130, 35);
            this.btn_L_Create.TabIndex = 5;
            this.btn_L_Create.Text = "Create Account";
            this.btn_L_Create.UseVisualStyleBackColor = true;
            this.btn_L_Create.Click += new System.EventHandler(this.btn_L_Create_Click);
            // 
            // btn_Sign_In
            // 
            this.btn_Sign_In.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_In.Location = new System.Drawing.Point(266, 136);
            this.btn_Sign_In.Name = "btn_Sign_In";
            this.btn_Sign_In.Size = new System.Drawing.Size(130, 35);
            this.btn_Sign_In.TabIndex = 4;
            this.btn_Sign_In.Text = "Sign In";
            this.btn_Sign_In.UseVisualStyleBackColor = true;
            // 
            // txtbx_Password_Login
            // 
            this.txtbx_Password_Login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password_Login.Location = new System.Drawing.Point(6, 104);
            this.txtbx_Password_Login.Name = "txtbx_Password_Login";
            this.txtbx_Password_Login.Size = new System.Drawing.Size(390, 26);
            this.txtbx_Password_Login.TabIndex = 3;
            this.txtbx_Password_Login.UseSystemPasswordChar = true;
            // 
            // txtbx_Username_Login
            // 
            this.txtbx_Username_Login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username_Login.Location = new System.Drawing.Point(6, 50);
            this.txtbx_Username_Login.Name = "txtbx_Username_Login";
            this.txtbx_Username_Login.Size = new System.Drawing.Size(390, 26);
            this.txtbx_Username_Login.TabIndex = 2;
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.AutoSize = true;
            this.txtbx_Password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password.Location = new System.Drawing.Point(2, 81);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(68, 20);
            this.txtbx_Password.TabIndex = 1;
            this.txtbx_Password.Text = "Password";
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.AutoSize = true;
            this.txtbx_Username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username.Location = new System.Drawing.Point(2, 27);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(70, 20);
            this.txtbx_Username.TabIndex = 0;
            this.txtbx_Username.Text = "Username";
            // 
            // grpbx_Create
            // 
            this.grpbx_Create.Controls.Add(this.btn_C_Login);
            this.grpbx_Create.Controls.Add(this.txtbx_Email_Create);
            this.grpbx_Create.Controls.Add(this.label4);
            this.grpbx_Create.Controls.Add(this.txtbx_Password_Confirm);
            this.grpbx_Create.Controls.Add(this.label3);
            this.grpbx_Create.Controls.Add(this.btn_Sign_Up);
            this.grpbx_Create.Controls.Add(this.txtbx_Password_create);
            this.grpbx_Create.Controls.Add(this.txtbx_Username_Create);
            this.grpbx_Create.Controls.Add(this.label1);
            this.grpbx_Create.Controls.Add(this.label2);
            this.grpbx_Create.Location = new System.Drawing.Point(12, 408);
            this.grpbx_Create.Name = "grpbx_Create";
            this.grpbx_Create.Size = new System.Drawing.Size(402, 256);
            this.grpbx_Create.TabIndex = 2;
            this.grpbx_Create.TabStop = false;
            this.grpbx_Create.Text = "Create Account";
            // 
            // btn_C_Login
            // 
            this.btn_C_Login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C_Login.Location = new System.Drawing.Point(6, 215);
            this.btn_C_Login.Name = "btn_C_Login";
            this.btn_C_Login.Size = new System.Drawing.Size(130, 35);
            this.btn_C_Login.TabIndex = 9;
            this.btn_C_Login.Text = "Sign In";
            this.btn_C_Login.UseVisualStyleBackColor = true;
            this.btn_C_Login.Click += new System.EventHandler(this.btn_C_Login_Click);
            // 
            // txtbx_Email_Create
            // 
            this.txtbx_Email_Create.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Email_Create.Location = new System.Drawing.Point(6, 166);
            this.txtbx_Email_Create.Name = "txtbx_Email_Create";
            this.txtbx_Email_Create.Size = new System.Drawing.Size(390, 26);
            this.txtbx_Email_Create.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txtbx_Password_Confirm
            // 
            this.txtbx_Password_Confirm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password_Confirm.Location = new System.Drawing.Point(219, 104);
            this.txtbx_Password_Confirm.Name = "txtbx_Password_Confirm";
            this.txtbx_Password_Confirm.Size = new System.Drawing.Size(177, 26);
            this.txtbx_Password_Confirm.TabIndex = 4;
            this.txtbx_Password_Confirm.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // btn_Sign_Up
            // 
            this.btn_Sign_Up.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_Up.Location = new System.Drawing.Point(266, 215);
            this.btn_Sign_Up.Name = "btn_Sign_Up";
            this.btn_Sign_Up.Size = new System.Drawing.Size(130, 35);
            this.btn_Sign_Up.TabIndex = 6;
            this.btn_Sign_Up.Text = "Sign Up";
            this.btn_Sign_Up.UseVisualStyleBackColor = true;
            // 
            // txtbx_Password_create
            // 
            this.txtbx_Password_create.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password_create.Location = new System.Drawing.Point(6, 104);
            this.txtbx_Password_create.Name = "txtbx_Password_create";
            this.txtbx_Password_create.Size = new System.Drawing.Size(177, 26);
            this.txtbx_Password_create.TabIndex = 3;
            this.txtbx_Password_create.UseSystemPasswordChar = true;
            // 
            // txtbx_Username_Create
            // 
            this.txtbx_Username_Create.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username_Create.Location = new System.Drawing.Point(6, 50);
            this.txtbx_Username_Create.Name = "txtbx_Username_Create";
            this.txtbx_Username_Create.Size = new System.Drawing.Size(390, 26);
            this.txtbx_Username_Create.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // frm_Login
            // 
            this.AcceptButton = this.btn_Sign_In;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 668);
            this.Controls.Add(this.grpbx_Create);
            this.Controls.Add(this.grpbx_Login);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbx_Login.ResumeLayout(false);
            this.grpbx_Login.PerformLayout();
            this.grpbx_Create.ResumeLayout(false);
            this.grpbx_Create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpbx_Login;
        private System.Windows.Forms.Button btn_Sign_In;
        private System.Windows.Forms.TextBox txtbx_Password_Login;
        private System.Windows.Forms.TextBox txtbx_Username_Login;
        private System.Windows.Forms.Label txtbx_Password;
        private System.Windows.Forms.Label txtbx_Username;
        private System.Windows.Forms.GroupBox grpbx_Create;
        private System.Windows.Forms.Button btn_Sign_Up;
        private System.Windows.Forms.TextBox txtbx_Password_create;
        private System.Windows.Forms.TextBox txtbx_Username_Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_Email_Create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_Password_Confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_L_Create;
        private System.Windows.Forms.Button btn_C_Login;
    }
}

