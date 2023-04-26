using System.Data.SqlClient;
using System.Data;
namespace TestDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonFindAll_Click(object sender, EventArgs e)
        {
            //创建并填充数据集，格式为：（要执行的数据库语句，数据库连接信息字符串）
            SqlDataAdapter adapter = new SqlDataAdapter(OperateSql.FindAllStudentInformation(), ConnectSql.ConnectionBuilder());
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "FindAllStudent");
            AmendDataGridViewStudentDataHeaderText();
            DataGridViewStudentData.DataSource = dataSet.Tables["FindAllStudent"];
            ConnectSql.CloseSql();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
        }
        
        private void AmendDataGridViewStudentDataHeaderText()
        {            
            DataGridViewStudentData.Columns[0].HeaderText = "学号";
            DataGridViewStudentData.Columns[1].HeaderText = "名字";
            DataGridViewStudentData.Columns[2].HeaderText = "性别";
            DataGridViewStudentData.Columns[3].HeaderText = "年龄";
            DataGridViewStudentData.Columns[4].HeaderText = "所在系";
        }
    }
}