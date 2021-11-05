using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystemApp
{
    public partial class frmLecturerGradesDetails : Form
    {
        public frmLecturerGradesDetails()
        {
            InitializeComponent();

        }
        public string UserID { get; set; }
        public int CourseID { get; set; }
        IGradeRepository gradeRepository = new GradeRepository();
        private void LecturerGradesDetails_Load(object sender, EventArgs e)
        {
            Grade grade = gradeRepository.GetGradeByID(UserID, CourseID);
            txtCourseID.Text = grade.CourseId.ToString();
            txtID.Text = grade.StudentId.ToString();
            txtProgress.Text = grade.ProgressTest.ToString();
            txtMidterm.Text = grade.MidTermTest.ToString();
            txtPratical.Text = grade.PracticalTest.ToString();
            txtFinal.Text = grade.FinalTest.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Grade grade = gradeRepository.GetGradeByID(UserID, CourseID);
            try
            {
                var g = new Grade
                {
                    GradeId = grade.GradeId,
                    CourseId = grade.CourseId,
                    StudentId = grade.StudentId,
                };
                if (CheckNull(txtProgress.Text))
                {
                    g.ProgressTest = Convert.ToDouble(txtProgress.Text);
                    gradeRepository.UpdateGrade(g);
                    if (Convert.ToDouble(txtProgress.Text) < 0 || Convert.ToDouble(txtProgress.Text) > 10)
                    {
                        MessageBox.Show("Grades bettween [0;10]");
                        return;
                    }
                }
                if (CheckNull(txtPratical.Text))
                {
                    g.PracticalTest = Convert.ToDouble(txtPratical.Text);
                    gradeRepository.UpdateGrade(g);
                    if (Convert.ToDouble(txtPratical.Text) < 0 || Convert.ToDouble(txtPratical.Text) > 10)
                    {
                        MessageBox.Show("Grades bettween [0;10]");
                        return;
                    }
                }
                if (CheckNull(txtMidterm.Text))
                {
                    g.MidTermTest = Convert.ToDouble(txtMidterm.Text);
                    gradeRepository.UpdateGrade(g);
                    if (Convert.ToDouble(txtMidterm.Text) < 0 || Convert.ToDouble(txtMidterm.Text) > 10)
                    {
                        MessageBox.Show("Grades bettween [0;10]");
                        return;
                    }
                }
                if (CheckNull(txtFinal.Text))
                {
                    g.FinalTest = Convert.ToDouble(txtFinal.Text);
                    gradeRepository.UpdateGrade(g);
                    if (Convert.ToDouble(txtFinal.Text) < 0 || Convert.ToDouble(txtFinal.Text) > 10)
                    {
                        MessageBox.Show("Grades bettween [0;10]");
                        return;
                    }
                }
                if (txtProgress.Text == "" && txtMidterm.Text == ""
                    && txtPratical.Text == "" && txtFinal.Text == "")
                {
                    gradeRepository.UpdateGrade(g);
                }
                MessageBox.Show("Update success", "Update course");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update course");
            }

        }
        public bool CheckNull(string text)
        {
            bool check = false;
            if (text != "")
            {
                return true;
            }
            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
