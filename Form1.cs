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
            DataGridViewStudentData.Columns[0].HeaderText = "ѧ��";
            DataGridViewStudentData.Columns[1].HeaderText = "����";
            DataGridViewStudentData.Columns[2].HeaderText = "�Ա�";
            DataGridViewStudentData.Columns[3].HeaderText = "����";
            DataGridViewStudentData.Columns[4].HeaderText = "����ϵ";
        }//�޸�gridview�ı���

        private void CreateFillStuDataIntegration(string DatabaseStatement)
        {
            //������������ݼ�����ʽΪ����Ҫִ�е����ݿ���䣬���ݿ�������Ϣ�ַ�����
            SqlDataAdapter adapter = new SqlDataAdapter(DatabaseStatement, ConnectSql.ConnectionBuilder());
            DataSet dataSet = new DataSet();
            //AddCheckboxOnFirstDataGridView();//����ѡ��ؼ��������ȼ�������䣬��Ȼ�ᵼ����������
            adapter.Fill(dataSet, "FindAllStudent");
            DataGridViewStudentData.DataSource = dataSet.Tables["FindAllStudent"];
            ConnectSql.CloseSql();
        }//������������ݼ�

        private void FindAllStuInformation() 
        {
            CreateFillStuDataIntegration(OperateSql.FindAllStudentInformation());
            AmendDataGridViewStudentDataHeaderText();
        }//��ʾ����ѧ����Ϣ

        /*private void AddCheckboxOnFirstDataGridView()
        {
            checkBoxSelect.HeaderText = " ";
            checkBoxSelect.Name = "ѡ��";
            checkBoxSelect.DataPropertyName = "checkbox";
            checkBoxSelect.ReadOnly = false;
            checkBoxSelect.TrueValue = true;
            checkBoxSelect.FalseValue = false;
            DataGridViewStudentData.Columns.Add(checkBoxSelect);
        }//����ѡ��ؼ�*/
        private void ButtonFindAll_Click(object sender, EventArgs e)
        {
            FindAllStuInformation();
        }

        private bool JudgeInputStudent(List<string> studentInformation)
        {
            if (TextBoxInputStuNum.Text == "")
            {
                MessageBox.Show("ѧ��Ϊ��","�ύ����",MessageBoxButtons.OK,MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(TextBoxInputStuNum.Text);
            }
            if (TextBoxInputStuName.Text == "")
            {
                MessageBox.Show("����Ϊ��", "�ύ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(TextBoxInputStuName.Text);
            }
            if (ComboBoxSelectStuSex.SelectedIndex == -1)
            {
                MessageBox.Show("δѡ���Ա�", "�ύ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(ComboBoxSelectStuSex.SelectedItem.ToString()!);
            }
            if (TextBoxInputStuAge.Text == "")
            {
                MessageBox.Show("δ��������", "�ύ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(TextBoxInputStuAge.Text);
            }
            if (TextBoxInputStuDeaprtment.Text == "")
            {
                MessageBox.Show("δ��������Ժϵ", "�ύ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentInformation.Clear();
                return false;
            }
            else
            {
                studentInformation.Add(TextBoxInputStuDeaprtment.Text);
                return true;
            }
        }//���ѧ���������Ϣ�Ƿ������������ռ�

        private void ClearInput()
        {
            TextBoxInputStuNum.Text = string.Empty;//�൱��""
            TextBoxInputStuName.Text = string.Empty;
            TextBoxInputStuAge.Text = string.Empty;
            ComboBoxSelectStuSex.SelectedIndex = -1;
            TextBoxInputStuDeaprtment.Text = string.Empty;

        }//��������ѧ����Ϣ

        private void Form1_Load(object sender, EventArgs e)
        {
            //AddCheckboxOnFirstDataGridView();
        }
        private void ButtonDependStuNumFind_Click(object sender, EventArgs e)
        {
            CreateFillStuDataIntegration(OperateSql.FindDependStudentNumber(TextBoxInputStuNum.Text));
        }//����ѧ�Ų�ѯѧ��

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
        }//���ѧ��

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
                MessageBox.Show("δ�����ѡ��ѧ��","ɾ������",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            FindAllStuInformation();
        }

        private void DataGridViewStudentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxInputStuNum.Text = DataGridViewStudentData.SelectedRows[0].Cells["Sno"].Value.ToString()!;
            TextBoxInputStuName.Text = DataGridViewStudentData.SelectedRows[0].Cells["Sname"].Value.ToString()!;
            if (DataGridViewStudentData.SelectedRows[0].Cells["Ssex"].Value.ToString()! == "��")
            {
                ComboBoxSelectStuSex.SelectedIndex = 0;
            }
            else
            {
                ComboBoxSelectStuSex.SelectedIndex = 1;
            }
            TextBoxInputStuAge.Text = DataGridViewStudentData.SelectedRows[0].Cells["Sage"].Value.ToString()!;
            TextBoxInputStuDeaprtment.Text = DataGridViewStudentData.SelectedRows[0].Cells["Sdept"].Value.ToString()!;
        }//����DataGridView�ؼ���ѡ��ĵ��������Ϸ���Ӧ�ؼ���

        private void ButtonAlter_Click(object sender, EventArgs e)
        {
            if (TextBoxInputStuNum.Text == string.Empty || TextBoxInputStuName.Text == string.Empty ||
                ComboBoxSelectStuSex.SelectedIndex == -1 || TextBoxInputStuAge.Text == string.Empty ||
                TextBoxInputStuDeaprtment.Text == string.Empty)
            {
                MessageBox.Show("��д��ѧ����Ϣ��ȫ","�޸Ĵ���",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
        }//�޸�ѧ������

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
        }//��������Ƿ����
    }
}