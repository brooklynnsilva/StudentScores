﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class frmUpdateStudent : Form
    {
        public frmUpdateStudent()
        {
            InitializeComponent();
        }

        List<int> scoresList = new();

        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {
            string student = Tag?.ToString() ?? "";
            string[] nameAndScores = student.Split('|');

            foreach (string s in nameAndScores)
            {
                bool isScore = Int32.TryParse(s, out int score);

                if (isScore)
                {
                    scoresList.Add(score);
                }

                else
                {
                    lblName.Text = s;
                }
            }

            DisplayScores();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form addForm = new frmAddUpdateScore();
            DialogResult result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int score = (int)addForm.Tag;
                scoresList.Add(score);
                DisplayScores();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstStudentScores.SelectedIndex;

            if (selectedIndex > -1)
            {
                Form updateForm = new frmAddUpdateScore
                {
                    Text = "Update Score",
                    Tag = lstStudentScores.SelectedItem
                };

                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int score = (int)updateForm.Tag;
                    scoresList.RemoveAt(selectedIndex);
                    scoresList.Insert(selectedIndex, score);
                    DisplayScores();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (scoresList.Count > 0)
            {
                scoresList.RemoveAt(lstStudentScores.SelectedIndex);
                DisplayScores();
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            scoresList.Clear();
            lstStudentScores.Items.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string studentScores = lblName.Text;

            foreach (int score in scoresList)
            {
                studentScores += $"|{score}";
            }

            Tag = studentScores;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayScores()
        {
            lstStudentScores.Items.Clear();

            if (scoresList.Count > 0)
            {
                foreach (int score in scoresList)
                {
                    lstStudentScores.Items.Add(score);
                }

                lstStudentScores.SelectedIndex = 0;
            }
        }
    }
}
