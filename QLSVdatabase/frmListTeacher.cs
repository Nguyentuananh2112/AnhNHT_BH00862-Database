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
    public partial class frmListTeacher : Form
    {
        public frmListTeacher()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            keyword = txtsearch.Text;
            loadListTeacher();
        }
        private string keyword = "";

        private void loadListTeacher()
        {
            string sql = "selectAllTeacher";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@keyword",
                value = keyword
            });
            dgvListTeacher.DataSource = new Database().SelectData(sql,lstPara);
        }

        private void frmListTeacher_Load(object sender, EventArgs e)
        {
            loadListTeacher();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            new frmTeacher(null).ShowDialog();
            loadListTeacher();
        }

        private void dgvListTeacher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvListTeacher.Rows[e.RowIndex].Cells["Teacher_ID"].Value.ToString();
                new frmTeacher(mgv).ShowDialog();
                loadListTeacher();
            }
        }

        private void dgvListTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
