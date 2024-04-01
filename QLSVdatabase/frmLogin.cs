using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVdatabase
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string nameaccount = "";
        public Boolean isLogin = false;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtNameaccount.Text))
            {
                MessageBox.Show("Please enter your account");
                txtNameaccount.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtNameaccount.Text))
            {
                MessageBox.Show("Please enter your password");
            }

            nameaccount = txtNameaccount.Text;

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@Username",
                    value = txtNameaccount.Text
                },
                new CustomParameter()
                {
                    key = "@Password",
                    value = txtpassword.Text
                },
            };

            var rs = new Database().SelectData("Loginaccount", lst);
            if(rs.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                this.isLogin = true;
            }
            else
            {
                MessageBox.Show("The account or password is incorrect");
                this.isLogin = false;
            }


            //nameaccount = "admin";
            
        }
    }
}
