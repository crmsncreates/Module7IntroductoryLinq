namespace Module7IntroductoryLinq
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
            lblProgram = new Label();
            lblMinimumGpa = new Label();
            lblStudentIdOrName = new Label();
            txtProgram = new TextBox();
            nudGPA = new NumericUpDown();
            txtStudentIdOrName = new TextBox();
            btnShowAll = new Button();
            btnFilterProgram = new Button();
            btnFilterGPA = new Button();
            btnSearch = new Button();
            btnSortByLastName = new Button();
            btnSortByGPA = new Button();
            dgvStudents = new DataGridView();
            lblAverageGPA = new Label();
            lblResultCount = new Label();
            ((System.ComponentModel.ISupportInitialize)nudGPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(12, 9);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(69, 20);
            lblProgram.TabIndex = 0;
            lblProgram.Text = "Program:";
            // 
            // lblMinimumGpa
            // 
            lblMinimumGpa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMinimumGpa.AutoSize = true;
            lblMinimumGpa.Location = new Point(289, 9);
            lblMinimumGpa.Name = "lblMinimumGpa";
            lblMinimumGpa.Size = new Size(71, 20);
            lblMinimumGpa.TabIndex = 1;
            lblMinimumGpa.Text = "Min. GPA:";
            // 
            // lblStudentIdOrName
            // 
            lblStudentIdOrName.AutoSize = true;
            lblStudentIdOrName.Location = new Point(12, 45);
            lblStudentIdOrName.Name = "lblStudentIdOrName";
            lblStudentIdOrName.Size = new Size(144, 20);
            lblStudentIdOrName.TabIndex = 2;
            lblStudentIdOrName.Text = "Student ID or Name:";
            // 
            // txtProgram
            // 
            txtProgram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProgram.Location = new Point(87, 6);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(196, 27);
            txtProgram.TabIndex = 3;
            txtProgram.WordWrap = false;
            // 
            // nudGPA
            // 
            nudGPA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudGPA.DecimalPlaces = 2;
            nudGPA.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudGPA.Location = new Point(366, 6);
            nudGPA.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudGPA.Name = "nudGPA";
            nudGPA.Size = new Size(62, 27);
            nudGPA.TabIndex = 4;
            // 
            // txtStudentIdOrName
            // 
            txtStudentIdOrName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentIdOrName.Location = new Point(162, 42);
            txtStudentIdOrName.Name = "txtStudentIdOrName";
            txtStudentIdOrName.Size = new Size(266, 27);
            txtStudentIdOrName.TabIndex = 3;
            txtStudentIdOrName.WordWrap = false;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(12, 75);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(94, 29);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnFilterProgram
            // 
            btnFilterProgram.Location = new Point(112, 75);
            btnFilterProgram.Name = "btnFilterProgram";
            btnFilterProgram.Size = new Size(123, 29);
            btnFilterProgram.TabIndex = 5;
            btnFilterProgram.Text = "Filter Program";
            btnFilterProgram.UseVisualStyleBackColor = true;
            btnFilterProgram.Click += btnFilterProgram_Click;
            // 
            // btnFilterGPA
            // 
            btnFilterGPA.Location = new Point(241, 75);
            btnFilterGPA.Name = "btnFilterGPA";
            btnFilterGPA.Size = new Size(90, 29);
            btnFilterGPA.TabIndex = 5;
            btnFilterGPA.Text = "Filter GPA";
            btnFilterGPA.UseVisualStyleBackColor = true;
            btnFilterGPA.Click += btnFilterGPA_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(337, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSortByLastName
            // 
            btnSortByLastName.Location = new Point(12, 110);
            btnSortByLastName.Name = "btnSortByLastName";
            btnSortByLastName.Size = new Size(144, 29);
            btnSortByLastName.TabIndex = 5;
            btnSortByLastName.Text = "Sort by Last Name";
            btnSortByLastName.UseVisualStyleBackColor = true;
            btnSortByLastName.Click += btnSortByLastName_Click;
            // 
            // btnSortByGPA
            // 
            btnSortByGPA.Location = new Point(162, 110);
            btnSortByGPA.Name = "btnSortByGPA";
            btnSortByGPA.Size = new Size(110, 29);
            btnSortByGPA.TabIndex = 5;
            btnSortByGPA.Text = "Sort by GPA";
            btnSortByGPA.UseVisualStyleBackColor = true;
            btnSortByGPA.Click += btnSortByGPA_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 145);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(409, 361);
            dgvStudents.TabIndex = 6;
            // 
            // lblAverageGPA
            // 
            lblAverageGPA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAverageGPA.AutoSize = true;
            lblAverageGPA.Location = new Point(12, 541);
            lblAverageGPA.Name = "lblAverageGPA";
            lblAverageGPA.Size = new Size(129, 20);
            lblAverageGPA.TabIndex = 7;
            lblAverageGPA.Text = "Average GPA: 4.00";
            // 
            // lblResultCount
            // 
            lblResultCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblResultCount.AutoSize = true;
            lblResultCount.Location = new Point(12, 513);
            lblResultCount.Name = "lblResultCount";
            lblResultCount.Size = new Size(197, 20);
            lblResultCount.TabIndex = 7;
            lblResultCount.Text = "Results: {} matching studenrs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 570);
            Controls.Add(lblResultCount);
            Controls.Add(lblAverageGPA);
            Controls.Add(dgvStudents);
            Controls.Add(btnSearch);
            Controls.Add(btnFilterGPA);
            Controls.Add(btnFilterProgram);
            Controls.Add(btnSortByGPA);
            Controls.Add(btnSortByLastName);
            Controls.Add(btnShowAll);
            Controls.Add(nudGPA);
            Controls.Add(txtStudentIdOrName);
            Controls.Add(txtProgram);
            Controls.Add(lblStudentIdOrName);
            Controls.Add(lblMinimumGpa);
            Controls.Add(lblProgram);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudGPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProgram;
        private Label lblMinimumGpa;
        private Label lblStudentIdOrName;
        private TextBox txtProgram;
        private NumericUpDown nudGPA;
        private TextBox txtStudentIdOrName;
        private Button btnShowAll;
        private Button btnFilterProgram;
        private Button btnFilterGPA;
        private Button btnSearch;
        private Button btnSortByLastName;
        private Button btnSortByGPA;
        private DataGridView dgvStudents;
        private Label lblAverageGPA;
        private Label lblResultCount;
    }
}
