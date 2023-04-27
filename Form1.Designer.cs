namespace TestDataGridView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonFindAll = new System.Windows.Forms.Button();
            this.DataGridViewStudentData = new System.Windows.Forms.DataGridView();
            this.ButtonDependStuNumFind = new System.Windows.Forms.Button();
            this.LabelTipsStuNum = new System.Windows.Forms.Label();
            this.TextBoxInputStuNum = new System.Windows.Forms.TextBox();
            this.LabelTipsStuName = new System.Windows.Forms.Label();
            this.TextBoxInputStuName = new System.Windows.Forms.TextBox();
            this.LabelTipsStuSelectSex = new System.Windows.Forms.Label();
            this.ComboBoxSelectStuSex = new System.Windows.Forms.ComboBox();
            this.SabelTipsStuInputDepart = new System.Windows.Forms.Label();
            this.TextBoxInputStuDeaprtment = new System.Windows.Forms.TextBox();
            this.ButtonAddStu = new System.Windows.Forms.Button();
            this.LabelTipsInputStuAge = new System.Windows.Forms.Label();
            this.TextBoxInputStuAge = new System.Windows.Forms.TextBox();
            this.ButtonDeleteStuInformation = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ButtonAlter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFindAll
            // 
            this.ButtonFindAll.Location = new System.Drawing.Point(762, 159);
            this.ButtonFindAll.Name = "ButtonFindAll";
            this.ButtonFindAll.Size = new System.Drawing.Size(127, 34);
            this.ButtonFindAll.TabIndex = 0;
            this.ButtonFindAll.Text = "查询全部";
            this.ButtonFindAll.UseVisualStyleBackColor = true;
            this.ButtonFindAll.Click += new System.EventHandler(this.ButtonFindAll_Click);
            // 
            // DataGridViewStudentData
            // 
            this.DataGridViewStudentData.AllowUserToResizeColumns = false;
            this.DataGridViewStudentData.AllowUserToResizeRows = false;
            this.DataGridViewStudentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudentData.Location = new System.Drawing.Point(42, 222);
            this.DataGridViewStudentData.Name = "DataGridViewStudentData";
            this.DataGridViewStudentData.RowHeadersWidth = 62;
            this.DataGridViewStudentData.RowTemplate.Height = 32;
            this.DataGridViewStudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStudentData.Size = new System.Drawing.Size(995, 364);
            this.DataGridViewStudentData.TabIndex = 1;
            this.DataGridViewStudentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudentData_CellClick);
            // 
            // ButtonDependStuNumFind
            // 
            this.ButtonDependStuNumFind.Location = new System.Drawing.Point(910, 159);
            this.ButtonDependStuNumFind.Name = "ButtonDependStuNumFind";
            this.ButtonDependStuNumFind.Size = new System.Drawing.Size(127, 34);
            this.ButtonDependStuNumFind.TabIndex = 2;
            this.ButtonDependStuNumFind.Text = "根据学号查询";
            this.ButtonDependStuNumFind.UseVisualStyleBackColor = true;
            this.ButtonDependStuNumFind.Click += new System.EventHandler(this.ButtonDependStuNumFind_Click);
            // 
            // LabelTipsStuNum
            // 
            this.LabelTipsStuNum.AutoSize = true;
            this.LabelTipsStuNum.Location = new System.Drawing.Point(42, 21);
            this.LabelTipsStuNum.Name = "LabelTipsStuNum";
            this.LabelTipsStuNum.Size = new System.Drawing.Size(82, 24);
            this.LabelTipsStuNum.TabIndex = 5;
            this.LabelTipsStuNum.Text = "学生学号";
            // 
            // TextBoxInputStuNum
            // 
            this.TextBoxInputStuNum.Location = new System.Drawing.Point(147, 21);
            this.TextBoxInputStuNum.Name = "TextBoxInputStuNum";
            this.TextBoxInputStuNum.Size = new System.Drawing.Size(150, 30);
            this.TextBoxInputStuNum.TabIndex = 6;
            // 
            // LabelTipsStuName
            // 
            this.LabelTipsStuName.AutoSize = true;
            this.LabelTipsStuName.Location = new System.Drawing.Point(423, 24);
            this.LabelTipsStuName.Name = "LabelTipsStuName";
            this.LabelTipsStuName.Size = new System.Drawing.Size(82, 24);
            this.LabelTipsStuName.TabIndex = 7;
            this.LabelTipsStuName.Text = "学生姓名";
            // 
            // TextBoxInputStuName
            // 
            this.TextBoxInputStuName.Location = new System.Drawing.Point(511, 21);
            this.TextBoxInputStuName.Name = "TextBoxInputStuName";
            this.TextBoxInputStuName.Size = new System.Drawing.Size(150, 30);
            this.TextBoxInputStuName.TabIndex = 8;
            // 
            // LabelTipsStuSelectSex
            // 
            this.LabelTipsStuSelectSex.AutoSize = true;
            this.LabelTipsStuSelectSex.Location = new System.Drawing.Point(777, 27);
            this.LabelTipsStuSelectSex.Name = "LabelTipsStuSelectSex";
            this.LabelTipsStuSelectSex.Size = new System.Drawing.Size(82, 24);
            this.LabelTipsStuSelectSex.TabIndex = 9;
            this.LabelTipsStuSelectSex.Text = "学生性别";
            // 
            // ComboBoxSelectStuSex
            // 
            this.ComboBoxSelectStuSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSelectStuSex.FormattingEnabled = true;
            this.ComboBoxSelectStuSex.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComboBoxSelectStuSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.ComboBoxSelectStuSex.Location = new System.Drawing.Point(890, 24);
            this.ComboBoxSelectStuSex.Name = "ComboBoxSelectStuSex";
            this.ComboBoxSelectStuSex.Size = new System.Drawing.Size(147, 32);
            this.ComboBoxSelectStuSex.TabIndex = 10;
            // 
            // SabelTipsStuInputDepart
            // 
            this.SabelTipsStuInputDepart.AutoSize = true;
            this.SabelTipsStuInputDepart.Location = new System.Drawing.Point(387, 97);
            this.SabelTipsStuInputDepart.Name = "SabelTipsStuInputDepart";
            this.SabelTipsStuInputDepart.Size = new System.Drawing.Size(82, 24);
            this.SabelTipsStuInputDepart.TabIndex = 11;
            this.SabelTipsStuInputDepart.Text = "所属院系";
            // 
            // TextBoxInputStuDeaprtment
            // 
            this.TextBoxInputStuDeaprtment.Location = new System.Drawing.Point(511, 91);
            this.TextBoxInputStuDeaprtment.Name = "TextBoxInputStuDeaprtment";
            this.TextBoxInputStuDeaprtment.Size = new System.Drawing.Size(150, 30);
            this.TextBoxInputStuDeaprtment.TabIndex = 12;
            // 
            // ButtonAddStu
            // 
            this.ButtonAddStu.Location = new System.Drawing.Point(762, 89);
            this.ButtonAddStu.Name = "ButtonAddStu";
            this.ButtonAddStu.Size = new System.Drawing.Size(127, 34);
            this.ButtonAddStu.TabIndex = 13;
            this.ButtonAddStu.Text = "添加学生";
            this.ButtonAddStu.UseVisualStyleBackColor = true;
            this.ButtonAddStu.Click += new System.EventHandler(this.ButtonAddStu_Click);
            // 
            // LabelTipsInputStuAge
            // 
            this.LabelTipsInputStuAge.AutoSize = true;
            this.LabelTipsInputStuAge.Location = new System.Drawing.Point(42, 94);
            this.LabelTipsInputStuAge.Name = "LabelTipsInputStuAge";
            this.LabelTipsInputStuAge.Size = new System.Drawing.Size(82, 24);
            this.LabelTipsInputStuAge.TabIndex = 14;
            this.LabelTipsInputStuAge.Text = "学生年龄";
            // 
            // TextBoxInputStuAge
            // 
            this.TextBoxInputStuAge.Location = new System.Drawing.Point(147, 89);
            this.TextBoxInputStuAge.Name = "TextBoxInputStuAge";
            this.TextBoxInputStuAge.Size = new System.Drawing.Size(150, 30);
            this.TextBoxInputStuAge.TabIndex = 15;
            // 
            // ButtonDeleteStuInformation
            // 
            this.ButtonDeleteStuInformation.Location = new System.Drawing.Point(910, 89);
            this.ButtonDeleteStuInformation.Name = "ButtonDeleteStuInformation";
            this.ButtonDeleteStuInformation.Size = new System.Drawing.Size(127, 34);
            this.ButtonDeleteStuInformation.TabIndex = 16;
            this.ButtonDeleteStuInformation.Text = "删除学生";
            this.ButtonDeleteStuInformation.UseVisualStyleBackColor = true;
            this.ButtonDeleteStuInformation.Click += new System.EventHandler(this.ButtonDelectStuInformation_Click);
            // 
            // ButtonAlter
            // 
            this.ButtonAlter.Location = new System.Drawing.Point(614, 159);
            this.ButtonAlter.Name = "ButtonAlter";
            this.ButtonAlter.Size = new System.Drawing.Size(127, 34);
            this.ButtonAlter.TabIndex = 17;
            this.ButtonAlter.Text = "修改";
            this.ButtonAlter.UseVisualStyleBackColor = true;
            this.ButtonAlter.Click += new System.EventHandler(this.ButtonAlter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 601);
            this.Controls.Add(this.ButtonAlter);
            this.Controls.Add(this.ButtonDeleteStuInformation);
            this.Controls.Add(this.TextBoxInputStuAge);
            this.Controls.Add(this.LabelTipsInputStuAge);
            this.Controls.Add(this.ButtonAddStu);
            this.Controls.Add(this.TextBoxInputStuDeaprtment);
            this.Controls.Add(this.SabelTipsStuInputDepart);
            this.Controls.Add(this.ComboBoxSelectStuSex);
            this.Controls.Add(this.LabelTipsStuSelectSex);
            this.Controls.Add(this.TextBoxInputStuName);
            this.Controls.Add(this.LabelTipsStuName);
            this.Controls.Add(this.TextBoxInputStuNum);
            this.Controls.Add(this.LabelTipsStuNum);
            this.Controls.Add(this.ButtonDependStuNumFind);
            this.Controls.Add(this.DataGridViewStudentData);
            this.Controls.Add(this.ButtonFindAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonFindAll;
        private DataGridView DataGridViewStudentData;
        private Button ButtonDependStuNumFind;
        private Label LabelTipsStuNum;
        private TextBox TextBoxInputStuNum;
        private Label LabelTipsStuName;
        private TextBox TextBoxInputStuName;
        private Label LabelTipsStuSelectSex;
        private ComboBox ComboBoxSelectStuSex;
        private Label SabelTipsStuInputDepart;
        private TextBox TextBoxInputStuDeaprtment;
        private Button ButtonAddStu;
        private Label LabelTipsInputStuAge;
        private TextBox TextBoxInputStuAge;
        private Button ButtonDeleteStuInformation;
        private SaveFileDialog saveFileDialog1;
        private Button ButtonAlter;
    }
}