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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFindAll
            // 
            this.ButtonFindAll.Location = new System.Drawing.Point(42, 72);
            this.ButtonFindAll.Name = "ButtonFindAll";
            this.ButtonFindAll.Size = new System.Drawing.Size(112, 34);
            this.ButtonFindAll.TabIndex = 0;
            this.ButtonFindAll.Text = "查询全部";
            this.ButtonFindAll.UseVisualStyleBackColor = true;
            this.ButtonFindAll.Click += new System.EventHandler(this.ButtonFindAll_Click);
            // 
            // DataGridViewStudentData
            // 
            this.DataGridViewStudentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudentData.Location = new System.Drawing.Point(42, 222);
            this.DataGridViewStudentData.Name = "DataGridViewStudentData";
            this.DataGridViewStudentData.RowHeadersWidth = 62;
            this.DataGridViewStudentData.RowTemplate.Height = 32;
            this.DataGridViewStudentData.Size = new System.Drawing.Size(995, 364);
            this.DataGridViewStudentData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 646);
            this.Controls.Add(this.DataGridViewStudentData);
            this.Controls.Add(this.ButtonFindAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonFindAll;
        private DataGridView DataGridViewStudentData;
    }
}