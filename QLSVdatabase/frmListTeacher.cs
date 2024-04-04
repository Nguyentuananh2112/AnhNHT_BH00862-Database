using System;
using System.Collections.Generic;
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
            dgvListTeacher.DataSource = new Database().SelectData(sql, lstPara);
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

        private void delTeacher_Click(object sender, EventArgs e)
        {
            Tuple<string, string> tagData = delTeacher.Tag as Tuple<string, string>;
            if (tagData != null)
            {
                string teacherID = tagData.Item1 as string;
                string fullName = tagData.Item2 as string;
                DialogResult result = MessageBox.Show("Do you want delete teacher '" + fullName + "'?", "Delete", MessageBoxButtons.OKCancel);
                string sql = "deleteTeacher";
                if (result == DialogResult.OK)
                {
                    List<CustomParameter> listPara = new List<CustomParameter>();

                    listPara.Add(new CustomParameter
                    {
                        key = "@teacherId",
                        value = teacherID
                    });

                    int resultDel = new Database().ExeCuteDelete(sql, listPara);
                    if (resultDel > 0)
                    {
                        MessageBox.Show("Delete successfully!");
                        loadListTeacher();
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    loadListTeacher();
                }

            }
        }
    }
}
