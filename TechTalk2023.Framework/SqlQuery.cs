using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTalk2023.Framework
{
    static public class SqlQuery
    { 

        static public string GetStudentInfoSelect       = "SELECT Id, [FirstName] ,[LastName],[Age] ,[Address1],[Address2] FROM [dbo].[StudentInfo] where Isdeleted =0 ";
        static public string GetStudentInfoSelectById   = "SELECT Id, [FirstName] ,[LastName],[Age] ,[Address1],[Address2] FROM [dbo].[StudentInfo] where Isdeleted =0 and Id = {0}";
        static public string DeleteStudentInfo          = "UPDATE [dbo].[StudentInfo] SET Isdeleted=1  WHERE Id = {0}"; 
        static public string GetStudentInfoInsert       = "INSERT INTO [dbo].[StudentInfo] ([FirstName] ,[LastName],[Age] ,[Address1],[Address2]) VALUES ('{0}','{1}','{2}','{3}','{4}')";
        static public string GetStudentInfoUpdate       = "UPDATE [dbo].[StudentInfo] SET [FirstName] = '{0}' ,[LastName] = '{1}',[Age] = '{2}',[Address1] = '{3}',[Address2] = '{4}'  WHERE Id = '{5}'";



        static public string GetProgramSelect = "SELECT ProgramId, [ProgramCode] ,[ProgramName],[ProgramType] ,[ProgramDescription],[ProgramYear] FROM [dbo].[ProgramDetails] where IsDelete =0 ";
        static public string GetProgramSelectById = "SELECT ProgramId, [ProgramCode] ,[ProgramName],[ProgramType] ,[ProgramDescription],[ProgramYear] FROM [dbo].[ProgramDetails] where IsDelete =0 and ProgramId = {0}";
        static public string DeleteProgramInfo = "UPDATE [dbo].[ProgramDetails] SET IsDelete=1  WHERE ProgramId = {0}";
        static public string InsertProgram = "INSERT INTO [dbo].[ProgramDetails] ([ProgramCode] ,[ProgramName],[ProgramType] ,[ProgramDescription],[ProgramYear]) VALUES ('{0}','{1}','{2}','{3}','{4}')";
        static public string UpdateProgram = "UPDATE [dbo].[ProgramDetails] SET [ProgramCode] = '{0}' ,[ProgramName] = '{1}',[ProgramType] = '{2}',[ProgramDescription] = '{3}',[ProgramYear] = '{4}'  WHERE ProgramId = '{5}'";



    }
}
