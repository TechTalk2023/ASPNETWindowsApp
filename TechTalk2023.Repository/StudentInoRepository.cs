using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk2023.DBEngine;
using TechTalk2023.Framework;

namespace TechTalk2023.Repository
{
    public class StudentInoRepository
    {
        SQLServerHandler sQLServerHandler = new SQLServerHandler();
        public StudentInoRepository() { }

        public int AddStudentInfo(Models.StudentInfos studentInfo)
        {
            return sQLServerHandler.ExecuteNonQuery(string.Format(SqlQuery.GetStudentInfoInsert, studentInfo.FirstName, studentInfo.LastName, studentInfo.Age, studentInfo.Address1, studentInfo.Address2));
        }
        public int EditStudentInfo(Models.StudentInfos studentInfo)
        {
            return sQLServerHandler.ExecuteNonQuery(string.Format(SqlQuery.GetStudentInfoUpdate, studentInfo.FirstName, studentInfo.LastName, studentInfo.Age, studentInfo.Address1, studentInfo.Address2,studentInfo.Id));
        }
        public int DeleteStudentInfo(int Id)
        {
            return sQLServerHandler.ExecuteNonQuery(string.Format(SqlQuery.DeleteStudentInfo,Id));
        }
        public DataTable SelectStudentInfo()
        {
            DataTable dataTable = new DataTable();
            dataTable = sQLServerHandler.ExecuteTable(SqlQuery.GetStudentInfoSelect);
            return dataTable;
        }

        public DataTable SelectStudentInfoById(int id)
        {
            DataTable dataTable = new DataTable(); 
            dataTable = sQLServerHandler.ExecuteTable(string.Format(SqlQuery.GetStudentInfoSelectById, id));
            return dataTable;
        }
    }
}
