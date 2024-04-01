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
    public partial class frmCourse : Form
    {
        public frmCourse(int courseId)
        {
            this.courseId = courseId;
            InitializeComponent();
        }

        private int courseId;
        

        private void frmCourse_Load(object sender, EventArgs e)
        {
            string getListTeacher = "getListTeacher";
            List<TeacherDto> teacherList = new Database().ExeCuteTeacher(getListTeacher);

            cbbTeacher.DataSource = teacherList;

            cbbTeacher.DisplayMember = "TeacherName";
            cbbTeacher.ValueMember = "TeacherId";


            string getListSubject = "getListSubject";
            List<SubjectDto> subjectList = new Database().ExeCuteSubject(getListSubject);

            cbbSubject.DataSource = subjectList;

            cbbSubject.DisplayMember = "SubjectName";
            cbbSubject.ValueMember = "SubjectId";



        }

        private void cbbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int subjectId = int.Parse(cbbSubject.SelectedValue.ToString());

            int teacherId = int.Parse(cbbTeacher.SelectedValue.ToString());

            string nameCourse = txtNameCourse.Text.Trim();


            if (string.IsNullOrEmpty(txtNameCourse.Text))
            {
                MessageBox.Show("The Course name mustn't be left blank");
                txtNameCourse.Select();
                return;
            }

            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (courseId == 0)
            {
                sql = "insertCourse";
            }
            else
            {
                sql = "updateCourse";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Course_ID",
                    value = courseId.ToString()
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@Name_Course",
                value = txtNameCourse.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Teacher_ID",
                value = teacherId.ToString()
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Subject_ID",
                value = subjectId.ToString()
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (courseId == 0)
                {
                    MessageBox.Show("New Course added successfully");
                }
                else
                {
                    MessageBox.Show("Course information updated successfully");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Query execution failed");
                this.Dispose();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
