using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechTalk2023.Framework;
using TechTalk2023.Models;
using TechTalk2023.Service;

namespace TechTalk2023.Features.StudentInfo
{
    public partial class AddStudentInfo : Form
    {

        StudentInfoService studentservice = new StudentInfoService();
        public int Id = 0;

        public AddStudentInfo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentInfos studentInfo = new StudentInfos();
            studentInfo.Id = Id;
            studentInfo.FirstName = txtFirstName.Text;
            studentInfo.LastName = txtLastName.Text;
            studentInfo.Age = Convert.ToInt32(txtAge.Text == "" ? "0" : txtAge.Text);
            studentInfo.Address1 = txtAddress1.Text;
            studentInfo.Address2 = txtAddress2.Text;

            if (studentservice.SaveStudentInfo(studentInfo) > 0)
            {
                MessageBox.Show(CommonVariable.SaveMessage, MessageTitle.StudentInfo);


                this.Close();
            }
            else
                MessageBox.Show(CommonVariable.UnableToSave, MessageTitle.StudentInfo);

          
        }

        private void AddStudentInfo_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {

                DataTable table = studentservice.SelectStudentInfoById(Id);


                if (table != null && table.Rows.Count > 0)
                {
                    txtFirstName.Text = table.Rows[0]["FirstName"].ToString();
                    txtLastName.Text = table.Rows[0]["LastName"].ToString();
                    txtAge.Text = table.Rows[0]["Age"].ToString();
                    txtAddress1.Text = table.Rows[0]["Address1"].ToString();
                    txtAddress2.Text = table.Rows[0]["Address2"].ToString();
                }

            }
        }
    }
}
