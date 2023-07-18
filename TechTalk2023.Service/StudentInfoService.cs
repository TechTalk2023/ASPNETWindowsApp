using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk2023.Repository;

namespace TechTalk2023.Service
{
    public class StudentInfoService
    {
        StudentInoRepository studentInoRepository = new StudentInoRepository();

        public StudentInfoService() { }

        public int SaveStudentInfo(Models.StudentInfos studentInfo) 
        { 
            int result = 0;
            if(studentInfo != null )
            {
                if(studentInfo.Id==0)
                    result =studentInoRepository.AddStudentInfo(studentInfo);
                else
                    result= studentInoRepository.EditStudentInfo(studentInfo);
            } 
            return result;
        }

        public int DeleteStudentInfo(int Id)
        {
            return studentInoRepository.DeleteStudentInfo(Id);
        }

        public DataTable SelectStudentInfo()
        {
            return studentInoRepository.SelectStudentInfo();
        }

        public DataTable SelectStudentInfoById(int id)
        { 
            return studentInoRepository.SelectStudentInfoById(id);
        }
         
    }
}
