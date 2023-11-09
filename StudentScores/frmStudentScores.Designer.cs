namespace StudentScores
{
    partial class frmStudentScores
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
            btnAddNew = new Button();
            label1 = new Label();
            lstStudents = new ListBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label2 = new Label();
            lblScoreTotal = new Label();
            lblScoreCount = new Label();
            label4 = new Label();
            lblAverage = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(260, 27);
            btnAddNew.Margin = new Padding(2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "&Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Students";
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(12, 27);
            lstStudents.Margin = new Padding(2);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(229, 79);
            lstStudents.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(260, 54);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(260, 83);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(260, 174);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 119);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "Score total:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.BorderStyle = BorderStyle.Fixed3D;
            lblScoreTotal.Location = new Point(203, 119);
            lblScoreTotal.Margin = new Padding(2, 0, 2, 0);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new Size(38, 15);
            lblScoreTotal.TabIndex = 7;
            lblScoreTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScoreCount
            // 
            lblScoreCount.BorderStyle = BorderStyle.Fixed3D;
            lblScoreCount.Location = new Point(203, 148);
            lblScoreCount.Margin = new Padding(2, 0, 2, 0);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(38, 15);
            lblScoreCount.TabIndex = 9;
            lblScoreCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 148);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Score count:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAverage
            // 
            lblAverage.BorderStyle = BorderStyle.Fixed3D;
            lblAverage.Location = new Point(203, 178);
            lblAverage.Margin = new Padding(2, 0, 2, 0);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(38, 15);
            lblAverage.TabIndex = 11;
            lblAverage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 178);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 10;
            label6.Text = "Average:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmStudentScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(351, 208);
            Controls.Add(lblAverage);
            Controls.Add(label6);
            Controls.Add(lblScoreCount);
            Controls.Add(label4);
            Controls.Add(lblScoreTotal);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lstStudents);
            Controls.Add(label1);
            Controls.Add(btnAddNew);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmStudentScores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Scores";
            Load += frmStudentScores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNew;
        private Label label1;
        private ListBox lstStudents;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Label label2;
        private Label lblScoreTotal;
        private Label lblScoreCount;
        private Label label4;
        private Label lblAverage;
        private Label label6;
    }
}