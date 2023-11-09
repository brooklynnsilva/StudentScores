namespace StudentScores
{
    partial class frmAddUpdateScore
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
            txtScore = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Score:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(80, 20);
            txtScore.Margin = new Padding(4, 3, 4, 3);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(107, 23);
            txtScore.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(134, 62);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 62);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmAddUpdateScore
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(222, 97);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(txtScore);
            Controls.Add(label1);
            Name = "frmAddUpdateScore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Score";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtScore;
        private Button btnCancel;
        private Button btnAdd;
    }
}