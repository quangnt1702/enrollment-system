using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        public void AddSubject(Subject subject) => SubjectDAO.Instance.AddSubject(subject);

        public int GetNumberCourseBySubject(int subjectId) => SubjectDAO.Instance.GetNumberCourseBySubject(subjectId);

        public IEnumerable<Subject> GetSubjects() => SubjectDAO.Instance.GetSubjectList();
    }
}
