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
        }//查询所有表
    }
}
