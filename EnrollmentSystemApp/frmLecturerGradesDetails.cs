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
                if (CheckNullAndMoreThanZero(txtProgress.Text))
                {
                    g.ProgressTest = Convert.ToDouble(txtProgress.Text);
                    gradeRepository.UpdateGrade(g);
                }
                if (CheckNullAndMoreThanZero(txtPratical.Text))
                {
                    g.PracticalTest = Convert.ToDouble(txtPratical.Text);
                    gradeRepository.UpdateGrade(g);
                }
                if (CheckNullAndMoreThanZero(txtMidterm.Text))
                {
                    g.MidTermTest = Convert.ToDouble(txtMidterm.Text);
                    gradeRepository.UpdateGrade(g);
                }
                if (CheckNullAndMoreThanZero(txtFinal.Text))
                {
                    g.FinalTest = Convert.ToDouble(txtFinal.Text);
                    gradeRepository.UpdateGrade(g);
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
        public bool CheckNullAndMoreThanZero(string text)
        {
            bool check = false;
            if (text != "")
            {
                if (Convert.ToDouble(text) >= 0 && Convert.ToDouble(text) <= 10)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Grades bettween [0;10]");
                }
            }
            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
