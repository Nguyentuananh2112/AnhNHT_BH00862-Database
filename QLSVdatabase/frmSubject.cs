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
    public partial class frmSubject : Form
    {
        public frmSubject(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }

        private string mamh;
        private string nguoithuchien = "admin";
        private void frmSubject_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = "Add new subject";
            }
            else
            {
                this.Text = "Update subject";
                var r = new Database().Select("exec selectSubject '" + mamh + "'");
                txtNamesubject.Text = r["Name_subject"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamesubject.Text))
            {
                MessageBox.Show("The subject name mustn't be left blank");
                txtNamesubject.Select();
                return;
            }
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mamh))
            {
                sql = "insertSubject";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Maker",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateSubject";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Subject_ID",
                    value = mamh
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@Updater",
                    value = nguoithuchien
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@Name_subject",
                value = txtNamesubject.Text
            });
            var rs = new Database().ExeCute(sql, lstPara);
            if(rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("New subject added successfully");
                }
                else
                {
                    MessageBox.Show("Subject information updated successfully");
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
