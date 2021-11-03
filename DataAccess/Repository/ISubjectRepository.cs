using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetSubjects();
        int GetNumberCourseBySubject(int subjectId);
        void AddSubject(Subject subject);
    }
}
