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
        public IEnumerable<Subject> GetSubjects()
        {
            return SubjectDAO.Instance.GetSubjectList();
        }
    }
}
