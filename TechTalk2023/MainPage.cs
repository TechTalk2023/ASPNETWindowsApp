using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechTalk2023.Features.ProgramDetails;
using TechTalk2023.Features.StudentInfo;

namespace TechTalk2023
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studnetInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInfo     viewStudentInfo = new ViewStudentInfo();
            viewStudentInfo.MdiParent = this;
            viewStudentInfo.Show();
        }

        private void programDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProgramDetails viewStudentInfo = new ViewProgramDetails();
            viewStudentInfo.MdiParent = this;
            viewStudentInfo.Show();
        }
    }
}
