namespace StudentScores
{
    partial class frmUpdateStudent
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
            label1 = new Label();
            lblName = new Label();
            label3 = new Label();
            lstStudentScores = new ListBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnClearScores = new Button();
            btnCancel = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // lblName
            // 
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Location = new Point(62, 9);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(270, 27);
            lblName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 54);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Scores:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstStudentScores
            // 
            lstStudentScores.FormattingEnabled = true;
            lstStudentScores.ItemHeight = 15;
            lstStudentScores.Location = new Point(62, 54);
            lstStudentScores.Margin = new Padding(4, 3, 4, 3);
            lstStudentScores.Name = "lstStudentScores";
            lstStudentScores.Size = new Size(174, 124);
            lstStudentScores.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(244, 54);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(244, 87);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(244, 120);
            btnRemove.Margin = new Padding(4, 3, 4, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(88, 27);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(244, 153);
            btnClearScores.Margin = new Padding(4, 3, 4, 3);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(88, 27);
            btnClearScores.TabIndex = 5;
            btnClearScores.Text = "Clear &Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            btnClearScores.Click += btnClearScores_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(244, 195);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(148, 195);
            btnOK.Margin = new Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(88, 27);
            btnOK.TabIndex = 7;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // frmUpdateStudent
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(360, 230);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(btnClearScores);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lstStudentScores);
            Controls.Add(label3);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "frmUpdateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Student Score";
            Load += frmUpdateStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label label3;
        private ListBox lstStudentScores;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnClearScores;
        private Button btnCancel;
        private Button btnOK;
    }
}