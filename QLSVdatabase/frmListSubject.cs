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
    public partial class frmListSubject : Form
    {
        public frmListSubject()
        {
            InitializeComponent();
        }

        private void dgvListSubject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var mamh = dgvListSubject.Rows[e.RowIndex].Cells["Subject_ID"].Value.ToString();
                new frmSubject(mamh).ShowDialog();
                LoadListSubject();
            }
        }

        private string keyword = "";
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            new frmSubject(null).ShowDialog();
            LoadListSubject();
        }

        private void LoadListSubject()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@keyword",
                value = keyword
            });
            dgvListSubject.DataSource = new Database().SelectData("selectAllSubject", lstPara);
        }

        private void frmListSubject_Load(object sender, EventArgs e)
        {
            LoadListSubject();
            dgvListSubject.Columns["Subject_ID"].HeaderText = "Subject ID";
            dgvListSubject.Columns["Name_subject"].HeaderText = "Name Subject";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            keyword = txtSearch.Text;
            LoadListSubject();
        }

        private void dgvListSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
