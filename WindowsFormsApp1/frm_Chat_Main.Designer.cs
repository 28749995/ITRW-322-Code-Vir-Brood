namespace WindowsFormsApp1
{
    partial class frm_Chat_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Chat_Main));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bw_Chat = new System.ComponentModel.BackgroundWorker();
            this.tmr_Chat = new System.Windows.Forms.Timer(this.components);
            this.clr_Custom_Chat = new System.Windows.Forms.ColorDialog();
            this.fnt_Custom_Chat = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearChatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbx_Chat_Output = new System.Windows.Forms.RichTextBox();
            this.picbx_User = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtbx_Message_Input = new System.Windows.Forms.TextBox();
            this.btn_Send_Input = new System.Windows.Forms.Button();
            this.lstbx_Contacts = new System.Windows.Forms.ListBox();
            this.lbl_User_Username = new System.Windows.Forms.Label();
            this.lbl_User_Email = new System.Windows.Forms.Label();
            this.lbl_User_Telephone = new System.Windows.Forms.Label();
            this.changeProfilePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_User)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bw_Chat
            // 
            this.bw_Chat.WorkerReportsProgress = true;
            this.bw_Chat.WorkerSupportsCancellation = true;
            // 
            // tmr_Chat
            // 
            this.tmr_Chat.Interval = 1000;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.clearChatToolStripMenuItem,
            this.clearChatToolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearChatToolStripMenuItem
            // 
            this.clearChatToolStripMenuItem.Name = "clearChatToolStripMenuItem";
            this.clearChatToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.clearChatToolStripMenuItem.Text = "Private Message";
            // 
            // clearChatToolStripMenuItem1
            // 
            this.clearChatToolStripMenuItem1.Name = "clearChatToolStripMenuItem1";
            this.clearChatToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.clearChatToolStripMenuItem1.Text = "Clear Chat";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFontToolStripMenuItem,
            this.changeColorToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Fonts";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Database";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeProfilePictureToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeFontToolStripMenuItem.Text = "Change Font";
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbx_Chat_Output);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstbx_Contacts);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.picbx_User);
            this.groupBox2.Location = new System.Drawing.Point(479, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 270);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Send_Input);
            this.groupBox3.Controls.Add(this.txtbx_Message_Input);
            this.groupBox3.Location = new System.Drawing.Point(12, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 138);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtbx_Chat_Output
            // 
            this.txtbx_Chat_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Chat_Output.Location = new System.Drawing.Point(3, 16);
            this.txtbx_Chat_Output.Name = "txtbx_Chat_Output";
            this.txtbx_Chat_Output.Size = new System.Drawing.Size(455, 251);
            this.txtbx_Chat_Output.TabIndex = 0;
            this.txtbx_Chat_Output.Text = "";
            // 
            // picbx_User
            // 
            this.picbx_User.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbx_User.Location = new System.Drawing.Point(6, 16);
            this.picbx_User.Name = "picbx_User";
            this.picbx_User.Size = new System.Drawing.Size(128, 128);
            this.picbx_User.TabIndex = 0;
            this.picbx_User.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_User_Telephone);
            this.groupBox4.Controls.Add(this.lbl_User_Email);
            this.groupBox4.Controls.Add(this.lbl_User_Username);
            this.groupBox4.Location = new System.Drawing.Point(140, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 128);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(479, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtbx_Message_Input
            // 
            this.txtbx_Message_Input.Location = new System.Drawing.Point(3, 19);
            this.txtbx_Message_Input.Multiline = true;
            this.txtbx_Message_Input.Name = "txtbx_Message_Input";
            this.txtbx_Message_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_Message_Input.Size = new System.Drawing.Size(452, 81);
            this.txtbx_Message_Input.TabIndex = 0;
            // 
            // btn_Send_Input
            // 
            this.btn_Send_Input.Location = new System.Drawing.Point(6, 106);
            this.btn_Send_Input.Name = "btn_Send_Input";
            this.btn_Send_Input.Size = new System.Drawing.Size(75, 23);
            this.btn_Send_Input.TabIndex = 1;
            this.btn_Send_Input.Text = "Send";
            this.btn_Send_Input.UseVisualStyleBackColor = true;
            // 
            // lstbx_Contacts
            // 
            this.lstbx_Contacts.FormattingEnabled = true;
            this.lstbx_Contacts.Location = new System.Drawing.Point(6, 150);
            this.lstbx_Contacts.Name = "lstbx_Contacts";
            this.lstbx_Contacts.Size = new System.Drawing.Size(303, 108);
            this.lstbx_Contacts.TabIndex = 3;
            // 
            // lbl_User_Username
            // 
            this.lbl_User_Username.AutoSize = true;
            this.lbl_User_Username.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Username.Location = new System.Drawing.Point(6, 16);
            this.lbl_User_Username.Name = "lbl_User_Username";
            this.lbl_User_Username.Size = new System.Drawing.Size(64, 16);
            this.lbl_User_Username.TabIndex = 0;
            this.lbl_User_Username.Text = "Username:";
            // 
            // lbl_User_Email
            // 
            this.lbl_User_Email.AutoSize = true;
            this.lbl_User_Email.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Email.Location = new System.Drawing.Point(6, 51);
            this.lbl_User_Email.Name = "lbl_User_Email";
            this.lbl_User_Email.Size = new System.Drawing.Size(40, 16);
            this.lbl_User_Email.TabIndex = 1;
            this.lbl_User_Email.Text = "Email:";
            // 
            // lbl_User_Telephone
            // 
            this.lbl_User_Telephone.AutoSize = true;
            this.lbl_User_Telephone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Telephone.Location = new System.Drawing.Point(6, 84);
            this.lbl_User_Telephone.Name = "lbl_User_Telephone";
            this.lbl_User_Telephone.Size = new System.Drawing.Size(67, 16);
            this.lbl_User_Telephone.TabIndex = 2;
            this.lbl_User_Telephone.Text = "Telephone:";
            // 
            // changeProfilePictureToolStripMenuItem
            // 
            this.changeProfilePictureToolStripMenuItem.Name = "changeProfilePictureToolStripMenuItem";
            this.changeProfilePictureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.changeProfilePictureToolStripMenuItem.Text = "Change Profile Picture";
            // 
            // frm_Chat_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_Chat_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bread Mail";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_User)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker bw_Chat;
        private System.Windows.Forms.Timer tmr_Chat;
        private System.Windows.Forms.ColorDialog clr_Custom_Chat;
        private System.Windows.Forms.FontDialog fnt_Custom_Chat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearChatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtbx_Chat_Output;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picbx_User;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstbx_Contacts;
        private System.Windows.Forms.Button btn_Send_Input;
        private System.Windows.Forms.TextBox txtbx_Message_Input;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_User_Telephone;
        private System.Windows.Forms.Label lbl_User_Email;
        private System.Windows.Forms.Label lbl_User_Username;
        private System.Windows.Forms.ToolStripMenuItem changeProfilePictureToolStripMenuItem;
    }
}