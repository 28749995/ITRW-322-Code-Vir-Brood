//Hello World, my name is Zander Boonzaaier...What now?
//Perspective, my dude.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 395;
            grpbx_Create.Enabled = false;
            grpbx_Login.Enabled = true;
            txtbx_Username_Login.Focus();
           
        }

        private void btn_C_Login_Click(object sender, EventArgs e)
        {
            this.Height = 395;
            this.AcceptButton = btn_Sign_In;
            grpbx_Create.Enabled = false;
            grpbx_Login.Enabled = true;
            txtbx_Username_Login.Focus();
        }

        private void btn_L_Create_Click(object sender, EventArgs e)
        {
            this.Height = 707;
            this.AcceptButton = btn_Sign_Up;
            grpbx_Create.Enabled = true;
            grpbx_Login.Enabled = false;
            txtbx_Username_Create.Focus();
        }
    }
}
