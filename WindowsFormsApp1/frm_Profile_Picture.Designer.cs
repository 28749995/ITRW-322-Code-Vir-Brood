namespace WindowsFormsApp1
{
    partial class frm_Profile_Picture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Profile_Picture));
            this.pbx_Profile_Picture = new System.Windows.Forms.PictureBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ofd_Browse_Picture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Profile_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Profile_Picture
            // 
            this.pbx_Profile_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_Profile_Picture.Location = new System.Drawing.Point(0, 0);
            this.pbx_Profile_Picture.Name = "pbx_Profile_Picture";
            this.pbx_Profile_Picture.Size = new System.Drawing.Size(327, 263);
            this.pbx_Profile_Picture.TabIndex = 0;
            this.pbx_Profile_Picture.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(12, 230);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 24);
            this.btn_Browse.TabIndex = 1;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // ofd_Browse_Picture
            // 
            this.ofd_Browse_Picture.FileName = "openFileDialog1";
            this.ofd_Browse_Picture.Filter = "Image Files|*.jpg; *.png; *.jpeg; *bmp";
            this.ofd_Browse_Picture.Title = "Choose Profile Picture";
            // 
            // frm_Profile_Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 263);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.pbx_Profile_Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Profile_Picture";
            this.Text = "Change Profile Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Profile_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Profile_Picture;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog ofd_Browse_Picture;
    }
}