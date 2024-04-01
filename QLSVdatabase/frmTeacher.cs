using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVdatabase
{
    public partial class frmTeacher : Form
    {
        public frmTeacher(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }

        private string mgv;
        private string nguoithucthi = "admin";


        private void frmTeacher_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Add new teacher";
            }
            else
            {
                this.Text = "Update teacher";
                var r = new Database().Select("selectTeacher '" + int.Parse(mgv) + "'");
                txtLastname.Text = r["Last_name"].ToString();
                txtFirstname.Text = r["First_name"].ToString();
                rbtMale.Checked = r["Sex"].ToString() == "1" ? true : false;
                mtbdateofbirth.Text = r["Date_of_birth"].ToString();
                txtphonenumber.Text = r["Phone_number"].ToString();
                txtemail.Text = r["Email"].ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime Date_of_birth;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            try
            {
                Date_of_birth = DateTime.ParseExact(mtbdateofbirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch 
            {
                MessageBox.Show("Date of birth is incorrect ");
                mtbdateofbirth.Select();
                return;
            }

            if(string.IsNullOrEmpty(mgv))
            {
                sql = "InsertTeacher";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Maker",
                    value = nguoithucthi
                });


            }
            else
            {
                sql = "updateTeacher";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Updater",
                    value = nguoithucthi
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@Teacher_ID",
                    value = mgv
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@Last_name",
                value = txtLastname.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@First_name",
                value = txtFirstname.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Date_of_birth",
                value = Date_of_birth.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Sex",
                value = rbtMale.Checked?"1":"0"
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = txtemail.Text
            });

            lstPara.Add(new CustomParameter() 
            {
                key = "@Phone_number",
                value = txtphonenumber.Text
            });


            var rs = new Database().ExeCute(sql, lstPara);
            if(rs == 1)
            {
                if(string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Add new Teacher successful");
                }
                else
                {
                    MessageBox.Show("Update Teacher successful");
                }
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
