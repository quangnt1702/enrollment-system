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
    public partial class frmAdminSubject : Form
    {
        ISubjectRepository subjectRepository = new SubjectRepository();
        public frmAdminSubject()
        {
            InitializeComponent();
        }

        private void frmAdminSubject_Load(object sender, EventArgs e)
        {
            LoadSubjectList();
        }

        public void LoadSubjectList()
        {
            try
            {
                var subjects = subjectRepository.GetSubjects();
                var list = (from s in subjects
                            select new
                            {
                                ID = s.SubjectId,
                                Name = s.SubjectName,
                                Courses = subjectRepository.GetNumberCourseBySubject(s.SubjectId)
            }).ToList();

                dgvSubject.DataSource = null;
                dgvSubject.DataSource = list;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load subject list");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectName.Text;
            var subjects = subjectRepository.GetSubjects();
            foreach (var s in subjects)
            {
                if(subjectName == s.SubjectName)
                {
                    MessageBox.Show("The subject is already exist", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadSubjectList();
                    return;
                }else if (string.IsNullOrWhiteSpace(subjectName))
                {
                    MessageBox.Show("PLease fill subject name", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadSubjectList();
                    return;
                }
                else
                {
                    Subject subject = new Subject
                    {
                        SubjectName = subjectName
                    };
                    subjectRepository.AddSubject(subject);
                    MessageBox.Show("Add subject successfully!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubjectList();
                    return;
                }
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var listSearch = subjectRepository.GetSubjects().Where(c => c.SubjectName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            try
            {
                var list = (from c in listSearch
                            select new
                            {
                                ID = c.SubjectId,
                                Name = c.SubjectName,
                                Course = subjectRepository.GetNumberCourseBySubject(c.SubjectId)
                            }).ToList();
                dgvSubject.DataSource = null;
                dgvSubject.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search course buy name");
            }
        }
    }
}
