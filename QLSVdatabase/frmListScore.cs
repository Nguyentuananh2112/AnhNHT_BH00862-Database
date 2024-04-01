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
    public partial class frmListScore : Form
    {
        public frmListScore()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListScore();
        }

        private void dgvSocre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListScore_Load(object sender, EventArgs e)
        {
            LoadListScore();
        }

        public void LoadListScore()
        {
            List<ScoreDto> listData = new List<ScoreDto>();

            List<CustomParameter> listPara = new List<CustomParameter>();

            
            listPara.Add(new CustomParameter()
            {
                key = "@firstName",
                value = txtFirstname.Text
            });

            listPara.Add(new CustomParameter()
            {
                key = "@lastName",
                value = txtLastname.Text
            });

            listPara.Add(new CustomParameter()
            {
                key = "@courseID",
                value = txtCourseID.Text
            });

            listPara.Add(new CustomParameter()
            {
                key = "@nameCourse",
                value = txtNamecourse.Text
            });
            string getListScore = "getListScore";
            listData = new Database().ExeCuteScore(getListScore, listPara);

            dgvSocre.DataSource = listData;
        }
    }
}
