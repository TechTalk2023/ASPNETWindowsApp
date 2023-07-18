using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk2023.Models.Input;
using TechTalk2023.Repository;

namespace TechTalk2023.Service
{
    public class ProgramDetailsService
    {
        ProgramRepository programRepository = new ProgramRepository();

        public ProgramDetailsService() { }

        public int SaveProgram(ProgramDetails Program) 
        { 
            int result = 0;
            if(Program != null )
            {
                if(Program.ProgramId==0)
                    result = programRepository.AddProgram (Program);
                else
                    result= programRepository.EditProgram (Program);
            }

            return result;
        }

        public int DeleteProgram(int Id)
        {
            return programRepository.DeleteProgram(Id);
        }

        public DataTable SelectProgram()
        {
            return programRepository.SelectProgram();
        }

        public DataTable SelectProgramById(int id)
        { 
            return programRepository.SelectProgramById(id);
        }
         
    }
}
