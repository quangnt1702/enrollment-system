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
            { if(double.Parse(txtProgress.Text)>=0&& double.Parse(txtMidterm.Text) >=0&& double.Parse(txtPratical.Text) >=0&& double.Parse(txtFinal.Text) >=0)
                {
                    var g = new Grade
                    {
                        GradeId = grade.GradeId,
                        CourseId = grade.CourseId,
                        StudentId = grade.StudentId,
                        ProgressTest = double.Parse(txtProgress.Text),
                        MidTermTest = double.Parse(txtMidterm.Text),
                        PracticalTest = double.Parse(txtPratical.Text),
                        FinalTest = double.Parse(txtFinal.Text)
                    };
                    gradeRepository.UpdateGrade(g);
                    MessageBox.Show("Update Successfully");
                } else
                {
                    MessageBox.Show("Grades cannot be negative");
                }              
                                          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update course");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
        
    }
}
