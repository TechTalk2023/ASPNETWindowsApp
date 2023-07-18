using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk2023.DBEngine;
using TechTalk2023.Framework;
using TechTalk2023.Models.Input;

namespace TechTalk2023.Repository
{
    public class ProgramRepository
    {
        SQLServerHandler sQLServerHandler = new SQLServerHandler();
        public ProgramRepository() { }

        public int AddProgram(ProgramDetails Program)
        {
            return sQLServerHandler.ExecuteNonQuery(string.Format(SqlQuery.InsertProgram, Program.ProgramCode, Program.ProgramName, Program.ProgramType, Program.ProgramDescription, Program.ProgramYear));
        }
        public int EditProgram(ProgramDetails Program)
        {
            return sQLServerHandler.ExecuteNonQuery(string.Format(SqlQuery.UpdateProgram, Program.ProgramCode, Program.ProgramName, Program.ProgramType, Program.ProgramDescription, Program.ProgramYear, Program.ProgramId));
        }
        public int DeleteProgram(int Id)
        {
            return sQLServerHandler.ExecuteNonQuery(string.Format(SqlQuery.DeleteProgramInfo,Id));
        }
        public DataTable SelectProgram()
        {
            DataTable dataTable = new DataTable();
            dataTable = sQLServerHandler.ExecuteTable(SqlQuery.GetProgramSelect);
            return dataTable;
        }

        public DataTable SelectProgramById(int id)
        {
            DataTable dataTable = new DataTable(); 
            dataTable = sQLServerHandler.ExecuteTable(string.Format(SqlQuery.GetProgramSelectById, id));
            return dataTable;
        }
    }
}
