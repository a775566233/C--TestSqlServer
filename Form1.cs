using System.Data.SqlClient;
using System.Data;
namespace TestDataGridView
{
    public partial class Form1 : Form
    {
        //DataGridViewCheckBoxColumn checkBoxSelect = new DataGridViewCheckBoxColumn();
        public Form1()
        {
            InitializeComponent();
        }
        private void AmendDataGridViewStudentDataHeaderText()
        {
            DataGridViewStudentData.Columns[0].HeaderText = "学号";
            DataGridViewStudentData.Columns[1].HeaderText = "名字";
            DataGridViewStudentData.Columns[2].HeaderText = "性别";
            DataGridViewStudentData.Columns[3].HeaderText = "年龄";
            DataGridViewStudentData.Columns[4].HeaderText = "所在系";
        }//修改gridview的标题

        private void CreateFillStuDataIntegration(string DatabaseStatement)
        {
            //创建并填充数据集，格式为：（要执行的数据库语句，数据库连接信息字符串）
            SqlDataAdapter adapter = new SqlDataAdapter(DatabaseStatement, ConnectSql.ConnectionBuilder());
            DataSet dataSet = new DataSet();
            //AddCheckboxOnFirstDataGridView();//加载选择控件，必须先加载再填充，不然会导致列名混乱
            adapter.Fill(dataSet, "FindAllStudent");
            DataGridViewStudentData.DataSource = dataSet.Tables["FindAllStudent"];
            ConnectSql.CloseSql();
        }//创建并填充数据集

        private void FindAllStuInformation() 
        {
            CreateFillStuDataIntegration(OperateSql.FindAllStudentInformation());
            AmendDataGridViewStudentDataHeaderText();
        }//显示所有学生信息

        /*private void AddCheckboxOnFirstDataGridView()
        {
            checkBoxSelect.HeaderText = " ";
            checkBoxSelect.Name = "选择";
            checkBoxSelect.DataPropertyName = "checkbox";
            checkBoxSelect.ReadOnly = false;
            checkBoxSelect.TrueValue = true;
            checkBoxSelect.FalseValue = false;
            DataGridViewStudentData.Columns.Add(checkBoxSelect);
        }//加载选择控件*/
        private void ButtonFindAll_Click(object sender, EventArgs e)
        {
            FindAllStuInformation();
        }

        private bool JudgeInputStudent(List<string> studentInformation)
        {
            if (TextBoxInputStuNum.Text == "")
            {
                MessageBox.Show("学号为空","提交错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(TextBoxInputStuNum.Text);
            }
            if (TextBoxInputStuName.Text == "")
            {
                MessageBox.Show("姓名为空", "提交错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(TextBoxInputStuName.Text);
            }
            if (ComboBoxSelectStuSex.SelectedIndex == -1)
            {
                MessageBox.Show("未选择性别", "提交错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(ComboBoxSelectStuSex.SelectedItem.ToString()!);
            }
            if (TextBoxInputStuAge.Text == "")
            {
                MessageBox.Show("未输入年龄", "提交错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(TextBoxInputStuAge.Text);
            }
            if (TextBoxInputStuDeaprtment.Text == "")
            {
                MessageBox.Show("未输入所属院系", "提交错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(TextBoxInputStuDeaprtment.Text);
                return true;
            }
        }//检测学生输入的信息是否完整并将其收集

        private void ClearInput()
        {
            TextBoxInputStuNum.Text = string.Empty;//相当于""
            TextBoxInputStuName.Text = string.Empty;
            TextBoxInputStuAge.Text = string.Empty;
            ComboBoxSelectStuSex.SelectedIndex = -1;
            TextBoxInputStuDeaprtment.Text = string.Empty;

        }//清空输入的学生信息

        private void Form1_Load(object sender, EventArgs e)
        {
            //AddCheckboxOnFirstDataGridView();
        }
        private void ButtonDependStuNumFind_Click(object sender, EventArgs e)
        {
            CreateFillStuDataIntegration(OperateSql.FindDependStudentNumber(TextBoxInputStuNum.Text));
        }//依靠学号查询学生

        private void ButtonAddStu_Click(object sender, EventArgs e)
        {
            List<string> studentInformation = new List<string>();
            if (JudgeInputStudent(studentInformation) == false)
            {
                return;
            }
            CreateFillStuDataIntegration(OperateSql.AddStudentForSql(studentInformation));
            studentInformation.Clear();
            ClearInput();
            FindAllStuInformation();
        }//添加学生

        private void ButtonDelectStuInformation_Click(object sender, EventArgs e)
        {
            if (TextBoxInputStuNum.Text != string.Empty)
            {
                CreateFillStuDataIntegration(OperateSql.DeleteStudentInformation(TextBoxInputStuNum.Text));
            }
            else if (DataGridViewStudentData.SelectedRows.Count > 0)
            {
                CreateFillStuDataIntegration(OperateSql.DeleteStudentInformation(DataGridViewStudentData.SelectedRows[0].Cells["Sno"].Value.ToString()!));
            }
            else
            {
                MessageBox.Show("未输入或选择学生","删除错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            FindAllStuInformation();
        }

        private void DataGridViewStudentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxInputStuNum.Text = DataGridViewStudentData.SelectedRows[0].Cells["Sno"].Value.ToString()!;
            TextBoxInputStuName.Text = DataGridViewStudentData.SelectedRows[0].Cells["Sname"].Value.ToString()!;
            if (DataGridViewStudentData.SelectedRows[0].Cells["Ssex"].Value.ToString()! == "男")
            {
                ComboBoxSelectStuSex.SelectedIndex = 0;
            }
            else
            {
                ComboBoxSelectStuSex.SelectedIndex = 1;
            }
            TextBoxInputStuAge.Text = DataGridViewStudentData.SelectedRows[0].Cells["Sage"].Value.ToString()!;
            TextBoxInputStuDeaprtment.Text = DataGridViewStudentData.SelectedRows[0].Cells["Sdept"].Value.ToString()!;
        }//将在DataGridView控件中选择的的项填入上方相应控件里

        private void ButtonAlter_Click(object sender, EventArgs e)
        {
            if (TextBoxInputStuNum.Text == string.Empty || TextBoxInputStuName.Text == string.Empty ||
                ComboBoxSelectStuSex.SelectedIndex == -1 || TextBoxInputStuAge.Text == string.Empty ||
                TextBoxInputStuDeaprtment.Text == string.Empty)
            {
                MessageBox.Show("填写的学生信息不全","修改错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            List<string> StuInformation = new List<string>();
            List<string> RowsName = new List<string>();
            if (CheckStuInformation(TextBoxInputStuName.Text, "Sname"))
            {
                StuInformation.Add(TextBoxInputStuName.Text);
                RowsName.Add("Sname");
            }
            if (CheckStuInformation(ComboBoxSelectStuSex.SelectedItem.ToString()!, "Ssex"))
            {
                StuInformation.Add(ComboBoxSelectStuSex.SelectedItem.ToString()!);
                RowsName.Add("Ssex");
            }
            if (CheckStuInformation(TextBoxInputStuAge.Text, "Sage"))
            {
                StuInformation.Add(TextBoxInputStuAge.Text);
                RowsName.Add("Sage");
            }
            if (CheckStuInformation(TextBoxInputStuDeaprtment.Text, "Sdept"))
            {
                StuInformation.Add(TextBoxInputStuDeaprtment.Text);
                RowsName.Add("Sdept");
            }
            CreateFillStuDataIntegration(OperateSql.UpdateStudentInformation(StuInformation, RowsName, DataGridViewStudentData.SelectedRows[0].Cells["Sno"].Value.ToString()!));
            FindAllStuInformation();
        }//修改学生数据

        private bool CheckStuInformation(string StuInformation, string RowsName) 
        {
            if (StuInformation == DataGridViewStudentData.SelectedRows[0].Cells[RowsName].Value.ToString()!)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//检查数据是否更改
    }
}