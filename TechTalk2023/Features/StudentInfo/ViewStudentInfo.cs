using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TechTalk2023.Framework;
using TechTalk2023.Service;

namespace TechTalk2023.Features.StudentInfo
{
    public partial class ViewStudentInfo : Form
    {

        StudentInfoService studentInfo = new StudentInfoService();
        public ViewStudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentInfo addStudentInfo = new AddStudentInfo();
            addStudentInfo.ShowDialog();
            LoadStudenmtInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            LoadStudenmtInfo();
        }

        private void LoadStudenmtInfo()
        {
            dataGridView1.DataSource = studentInfo.SelectStudentInfo();
        }

        private void ViewStudentInfo_Load(object sender, EventArgs e)
        {
            LoadStudenmtInfo();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                int UserId = Convert.ToInt32(dr.Cells[0].Value.ToString());
                if (studentInfo.DeleteStudentInfo(UserId) > 0)
                {
                    MessageBox.Show(CommonVariable.DeleteMessage, MessageTitle.StudentInfo);
                    LoadStudenmtInfo();
                }
                else
                {
                    MessageBox.Show(CommonVariable.UnableToSave, MessageTitle.StudentInfo);
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                string UserId = dr.Cells[0].Value.ToString();
                AddStudentInfo student = new AddStudentInfo();
                student.Id = Convert.ToInt32(UserId);
                student.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Please select the row to Edit", "Student Details");
            }
            LoadStudenmtInfo();
        }
    }
}
