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
    public partial class frmListCourse : Form
    {
        public frmListCourse()
        {
            InitializeComponent();
        }

        private string keyword = "";

        private void frmListCourse_Load(object sender, EventArgs e)
        {
            loadListCourse();

        }

        public void loadListCourse()
        {
            List<CourseDto> listData = new List<CourseDto>();
             
            CustomParameter parameter = new CustomParameter()
            {
                key = "@keyword",
                value = keyword
            };
            
            string getlistCourse = "getListCourse";
            listData = new Database().ExeCuteCourse(getlistCourse, parameter);

            dgvListCourse.DataSource = listData;

            dgvListCourse.Columns["courseID"].DisplayIndex = 0;

            dgvListCourse.Columns["courseID"].HeaderText = "Course ID";
            dgvListCourse.Columns["firstName"].HeaderText = "Teacher Name";
            dgvListCourse.Columns["nameCourse"].HeaderText = "Course Name";
            dgvListCourse.Columns["nameSubject"].HeaderText = "Subject Name";

            dgvListCourse.Columns["teacherID"].Visible = false;
            dgvListCourse.Columns["subjectID"].Visible = false;
         
        }

        private void dgvListCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            keyword = txtKeyword.Text;
            loadListCourse();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            new frmCourse(0).ShowDialog();
            loadListCourse();
        }
    }
}
