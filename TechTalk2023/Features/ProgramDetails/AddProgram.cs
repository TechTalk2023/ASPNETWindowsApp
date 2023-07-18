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
using TechTalk2023.Service;

namespace TechTalk2023.Features.ProgramDetails
{
    public partial class AddProgram : Form
    {
        ProgramDetailsService program = new ProgramDetailsService();

        public int ProgramId = 0;
        public AddProgram()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            Models.Input.ProgramDetails studentInfo = new Models.Input.ProgramDetails();
            studentInfo.ProgramId = ProgramId;
            studentInfo.ProgramCode = codeValue.Text;
            studentInfo.ProgramName = nameValue.Text;
            studentInfo.ProgramType = typeValue.Text;
            studentInfo.ProgramDescription = desValue.Text;
            studentInfo.ProgramYear = Convert.ToInt16(txtYear.Text);

            if (program.SaveProgram(studentInfo) > 0)
            {
                MessageBox.Show(CommonVariable.SaveMessage, MessageTitle.ProgramDetails);


                this.Close();
            }
            else
                MessageBox.Show(CommonVariable.UnableToSave, MessageTitle.ProgramDetails);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProgram_Load(object sender, EventArgs e)
        {
            if (ProgramId > 0)
            {


                DataTable table = program.SelectProgramById(ProgramId);


                if (table != null && table.Rows.Count > 0)
                {
                    codeValue.Text = table.Rows[0]["ProgramCode"].ToString();
                    nameValue.Text = table.Rows[0]["ProgramName"].ToString();
                    typeValue.Text = table.Rows[0]["ProgramType"].ToString();
                    desValue.Text = table.Rows[0]["ProgramDescription"].ToString();
                    txtYear.Text = table.Rows[0]["ProgramYear"].ToString();
                }
                 
            }
        }
    }
}
