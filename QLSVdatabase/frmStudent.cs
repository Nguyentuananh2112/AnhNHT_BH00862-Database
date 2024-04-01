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
    public partial class frmStudent : Form
    {
        public frmStudent(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private void frmStudent_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Add new Student: ";
            }
            else
            {
                this.Text = "Update student information: ";
                var r = new Database().Select("selectStudent '" + msv + "'");
               // MessageBox.Show(r[0].ToString());//

                txtlastname.Text = r["Last_Name"].ToString();
                txtfirstname.Text = r["First_Name"].ToString();
                mtbDateofbirth.Text = r["Date_of_birth"].ToString();
                if (int.Parse(r["Sex"].ToString()) == 1)
                {
                    rbtMale.Checked = true;
                }
                else
                {
                    rbtFemale.Checked = true;
                }
                txtHometown.Text = r["Home_Town"].ToString();
                txtaddress.Text = r["address"].ToString();
                txtPhonemunber.Text = r["Phone_number"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void mtbSex_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string Last_name = txtlastname.Text;
            string First_name = txtfirstname.Text;
            DateTime Date_of_birth;
            try
            {
                Date_of_birth = DateTime.ParseExact(mtbDateofbirth.Text, "dd/MM/yyyy",CultureInfo.InvariantCulture);
            }
            catch (Exception) 
            {
                MessageBox.Show("Invalid date of birth");
                mtbDateofbirth.Select();
                return;
            }



            String Sex = rbtMale.Checked ? "1" : "0";
            String Home_town = txtHometown.Text;
            String Address = txtaddress.Text;
            String Phone_number = txtPhonemunber.Text;
            String Email = txtaddress.Text;




            List<CustomParameter> lstPara = new List<CustomParameter>();
            if(string .IsNullOrEmpty(msv))
            {
                sql = "AddnewStudent";
               
            }
            else
            {
                sql = "updateStudent";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Student_ID",
                    value = msv,
                });

            }  

            lstPara.Add(new CustomParameter()
            {
                key = "@Last_name",
                value = Last_name
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@First_name",
                value = First_name
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Date_of_birth",
                value = Date_of_birth.ToString("yyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Sex",
                value = Sex
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Home_town",
                value = Home_town
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Address",
                value = Address
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Phone_number",
                value = Phone_number
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = Email
            });


            var rs  = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Successfully added new student");
                }
                else
                {
                    MessageBox.Show("Successfully updated student information");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Execution failed");
            }
        }
    }
}
