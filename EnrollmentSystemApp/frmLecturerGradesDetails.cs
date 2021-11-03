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
        public Grade grade { get; set; }
        IGradeRepository gradeRepository = new GradeRepository();
        private void LecturerGradesDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            txtProgress.Text = grade.ProgressTest.ToString();
            txtMidterm.Text = grade.MidTermTest.ToString();
            txtPratical.Text = grade.PracticalTest.ToString();
            txtFinal.Text = grade.FinalTest.ToString();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
                                         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update course");
            }

        }
    }
}
