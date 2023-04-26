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
            //������������ݼ�����ʽΪ����Ҫִ�е����ݿ���䣬���ݿ�������Ϣ�ַ�����
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
            DataGridViewStudentData.Columns[0].HeaderText = "ѧ��";
            DataGridViewStudentData.Columns[1].HeaderText = "����";
            DataGridViewStudentData.Columns[2].HeaderText = "�Ա�";
            DataGridViewStudentData.Columns[3].HeaderText = "����";
            DataGridViewStudentData.Columns[4].HeaderText = "����ϵ";
        }
    }
}