using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGridView
{
    internal class OperateSql//执行sql语句的类
    {
        public static string FindAllStudentInformation()
        {
            ConnectSql.OpenSql();
            string FindAllStudentInformation = "select * from Student_Information_Table";
            return FindAllStudentInformation;
        }//查询学生表的所有内容
        public static string FindDependStudentNumber(string studentNumber)
        {
            ConnectSql.OpenSql();
            string FindDependStudentNumber = "Select * From Student_Information_Table Where Sno = " + "'" + studentNumber + "'";
            return FindDependStudentNumber;
        }//在表中查询某一学生
        public static string AddStudentForSql(List<string> StudentInformation)
        {
            ConnectSql.OpenSql();
            string AddStudentForSql = "insert into Student_Information_Table values(";
            for (int _i = 0; _i < StudentInformation.Count; _i++) 
            {
                if (_i == 3)
                {
                    AddStudentForSql += StudentInformation[_i];
                }
                else
                {
                    AddStudentForSql += "'" + StudentInformation[_i] + "'";
                }
                if (_i + 1 != StudentInformation.Count)
                {
                    AddStudentForSql += ",";
                }
            }
            AddStudentForSql += ")";
            return AddStudentForSql;
        }//在表中添加某一学生
        public static string DeleteStudentInformation(string studentNumber) 
        {
            string DeleteStudentInformation = "Delete From Student_Information_Table Where Sno = " + "'" + studentNumber + "'";
            return DeleteStudentInformation;
        }//删除表中某一位学生
        public static string UpdateStudentInformation(List<string> StudentInformation, List<string> RowsName, string StuNum)
        {
            ConnectSql.OpenSql();
            string AddStudentForSql = "Update Student_Information_Table set ";
            for (int _i = 0; _i < StudentInformation.Count; _i++)
            {
                if (RowsName[_i] != "Sage")
                {
                    AddStudentForSql += RowsName[_i]  + "=" + "'" + StudentInformation[_i] + "'";
                }
                else
                {
                    AddStudentForSql += RowsName[_i] + "=" + StudentInformation[_i];
                }
                if (_i + 1 != StudentInformation.Count)
                {
                    AddStudentForSql += ", ";
                }
            }
            AddStudentForSql += "Where Sno = '" + StuNum.ToString() + "'";
            return AddStudentForSql;
        }//在学生表修改学生信息
    }
}
