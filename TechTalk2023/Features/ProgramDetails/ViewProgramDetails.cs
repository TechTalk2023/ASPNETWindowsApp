using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechTalk2023.Features.StudentInfo;
using TechTalk2023.Framework;
using TechTalk2023.Models;
using TechTalk2023.Service;

namespace TechTalk2023.Features.ProgramDetails
{
    public partial class ViewProgramDetails : Form
    {

        ProgramDetailsService program = new ProgramDetailsService();


        public ViewProgramDetails()
        {
            InitializeComponent();
        }

        private void ViewProgramDetails_Load(object sender, EventArgs e)
        {
            LoadProgram();
        }

        private void LoadProgram()
        {
            dataGridView1.DataSource = program.SelectProgram();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            LoadProgram();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                int Id = Convert.ToInt32(dr.Cells[0].Value.ToString());
                if (program.DeleteProgram(Id) > 0)
                {
                    MessageBox.Show(CommonVariable.DeleteMessage, MessageTitle.ProgramDetails);
                    LoadProgram();
                }
                else
                {
                    MessageBox.Show(CommonVariable.UnableToSave, MessageTitle.ProgramDetails);
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                string Id = dr.Cells[0].Value.ToString();
               
                AddProgram program = new AddProgram();
                program.ProgramId = Convert.ToInt32(Id);
                program.ShowDialog(); 

                LoadProgram();
            }
            else
            {
                MessageBox.Show("Please select the row to Edit", "Student Details");
            }
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddProgram program = new AddProgram();
            program.ShowDialog();
        }
    }
}
