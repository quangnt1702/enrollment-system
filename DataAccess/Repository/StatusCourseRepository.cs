using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public class StatusCourseRepository : IStatusCourseRepository
    {
        public IEnumerable<StatusCourse> GetStatuses() => StatusCourseDAO.Instance.GetStatusCourseList();
    }
}
