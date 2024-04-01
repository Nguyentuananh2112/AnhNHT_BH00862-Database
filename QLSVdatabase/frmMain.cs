using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVdatabase
{
    public partial class frmMain : Form
    {
        

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fn = new frmLogin();
            fn.ShowDialog();

            //var account = fn.nameaccount;

            Boolean isLogin = fn.isLogin;

            if (!isLogin)
            {
                Application.Exit();
            }

            var  db = new Database();
            //dgvData.DataSource = db.SelectData(null);
            frmWelcome f = new frmWelcome();
            Addform(f);

        }

        private void Addform(Form f)
        {
            this.pnlcontent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlcontent.Controls.Add(f);
            f.Show();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListStudent f = new frmListStudent();
            Addform(f);
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTeacher f = new frmListTeacher();
            Addform(f);
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSubject f = new frmListSubject();
            Addform(f);
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCourse f = new frmListCourse();
            Addform(f);
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListScore f = new frmListScore();
            Addform(f);
        }

        private void pnlcontent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



