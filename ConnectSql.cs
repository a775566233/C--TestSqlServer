using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestDataGridView
{
    public class ConnectSql
    {
        public static string ConnectionBuilder()
        {
            SqlConnectionStringBuilder ConnectionBuilder = new SqlConnectionStringBuilder();
            ConnectionBuilder.UserID = "StuAd";
            ConnectionBuilder.Password = "123456";
            ConnectionBuilder.DataSource = "127.0.0.1";
            ConnectionBuilder.InitialCatalog = "Students";
            return ConnectionBuilder.ToString();
        }//构建所有数据库的登录信息字符串
        public static void OpenSql()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionBuilder());
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex) 
            { 
                if (MessageBox.Show("是否查看详情错误信息？", "数据库连接错误", MessageBoxButtons.OKCancel,MessageBoxIcon.Error) == DialogResult.OK)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }//打开数据库
        public static void CloseSql() 
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionBuilder());
            sqlConnection.Close();
        }//关闭数据库

    }
}
