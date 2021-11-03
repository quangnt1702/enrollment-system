using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public class GradeRepository : IGradeRepository
    {
        public IEnumerable<Grade> GetGradeOfStudent(string studentId, int courseId) => GradeDAO.Instance.GetGradeOfStudent(studentId, courseId);

        public void InsertGrade(Grade grade) => GradeDAO.Instance.AddNew(grade);
        public IEnumerable<Grade> GetGradesList() => GradeDAO.Instance.GetGradesList();

    }
}
