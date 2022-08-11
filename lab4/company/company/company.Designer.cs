namespace company
{
    partial class company
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Departmentname = new System.Windows.Forms.TextBox();
            this.Departmentnumber = new System.Windows.Forms.TextBox();
            this.manegerssn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insertBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateBTN = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.getnameBTN = new System.Windows.Forms.Button();
            this.Dnum = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pname = new System.Windows.Forms.Label();
            this.deleteprojectBTN = new System.Windows.Forms.Button();
            this.projectname = new System.Windows.Forms.TextBox();
            this.companyDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Departmentname
            // 
            this.Departmentname.Location = new System.Drawing.Point(112, 33);
            this.Departmentname.Name = "Departmentname";
            this.Departmentname.Size = new System.Drawing.Size(100, 20);
            this.Departmentname.TabIndex = 0;
            // 
            // Departmentnumber
            // 
            this.Departmentnumber.Location = new System.Drawing.Point(112, 86);
            this.Departmentnumber.Name = "Departmentnumber";
            this.Departmentnumber.Size = new System.Drawing.Size(100, 20);
            this.Departmentnumber.TabIndex = 1;
            // 
            // manegerssn
            // 
            this.manegerssn.Location = new System.Drawing.Point(365, 33);
            this.manegerssn.Name = "manegerssn";
            this.manegerssn.Size = new System.Drawing.Size(100, 20);
            this.manegerssn.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.insertBTN);
            this.groupBox1.Controls.Add(this.Departmentname);
            this.groupBox1.Controls.Add(this.Departmentnumber);
            this.groupBox1.Controls.Add(this.manegerssn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "insert department";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 93);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 1, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "maneger start data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "maneger ssn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Department number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Department name";
            // 
            // insertBTN
            // 
            this.insertBTN.Location = new System.Drawing.Point(546, 61);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(75, 23);
            this.insertBTN.TabIndex = 5;
            this.insertBTN.Text = "insert";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.updateBTN);
            this.groupBox2.Controls.Add(this.salary);
            this.groupBox2.Controls.Add(this.ssn);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 134);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "update  Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "SSN";
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(546, 60);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(75, 23);
            this.updateBTN.TabIndex = 6;
            this.updateBTN.Text = "update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(267, 60);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 20);
            this.salary.TabIndex = 0;
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(66, 60);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(100, 20);
            this.ssn.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.getnameBTN);
            this.groupBox3.Controls.Add(this.Dnum);
            this.groupBox3.Location = new System.Drawing.Point(12, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 134);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "get the first name of the maneger of a specific department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Department number";
            // 
            // getnameBTN
            // 
            this.getnameBTN.Location = new System.Drawing.Point(443, 36);
            this.getnameBTN.Name = "getnameBTN";
            this.getnameBTN.Size = new System.Drawing.Size(104, 23);
            this.getnameBTN.TabIndex = 6;
            this.getnameBTN.Text = "get Manegr name";
            this.getnameBTN.UseVisualStyleBackColor = true;
            this.getnameBTN.Click += new System.EventHandler(this.getnameBTN_Click);
            // 
            // Dnum
            // 
            this.Dnum.Location = new System.Drawing.Point(132, 33);
            this.Dnum.Name = "Dnum";
            this.Dnum.Size = new System.Drawing.Size(100, 20);
            this.Dnum.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox4.Controls.Add(this.pname);
            this.groupBox4.Controls.Add(this.deleteprojectBTN);
            this.groupBox4.Controls.Add(this.projectname);
            this.groupBox4.Location = new System.Drawing.Point(12, 468);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(787, 134);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "delete a Project";
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Location = new System.Drawing.Point(37, 61);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(68, 13);
            this.pname.TabIndex = 7;
            this.pname.Text = "project name";
            // 
            // deleteprojectBTN
            // 
            this.deleteprojectBTN.Location = new System.Drawing.Point(313, 56);
            this.deleteprojectBTN.Name = "deleteprojectBTN";
            this.deleteprojectBTN.Size = new System.Drawing.Size(112, 23);
            this.deleteprojectBTN.TabIndex = 6;
            this.deleteprojectBTN.Text = "delete project";
            this.deleteprojectBTN.UseVisualStyleBackColor = true;
            this.deleteprojectBTN.Click += new System.EventHandler(this.deleteprojectBTN_Click);
            // 
            // projectname
            // 
            this.projectname.Location = new System.Drawing.Point(112, 58);
            this.projectname.Name = "projectname";
            this.projectname.Size = new System.Drawing.Size(100, 20);
            this.projectname.TabIndex = 1;
            this.projectname.TextChanged += new System.EventHandler(this.projectname_TextChanged);
            // 
            // companyDataGrid
            // 
            this.companyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDataGrid.Location = new System.Drawing.Point(12, 598);
            this.companyDataGrid.Name = "companyDataGrid";
            this.companyDataGrid.Size = new System.Drawing.Size(787, 150);
            this.companyDataGrid.TabIndex = 8;
            // 
            // company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 749);
            this.Controls.Add(this.companyDataGrid);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "company";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Departmentname;
        private System.Windows.Forms.TextBox Departmentnumber;
        private System.Windows.Forms.TextBox manegerssn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button getnameBTN;
        private System.Windows.Forms.TextBox Dnum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Button deleteprojectBTN;
        private System.Windows.Forms.TextBox projectname;
        private System.Windows.Forms.DataGridView companyDataGrid;
       public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

