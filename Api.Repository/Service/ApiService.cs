using Api.Repository.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository.Service
{
    public class ApiService : IApiService
    {
        private AWContext _context;

        public ApiService(AWContext context)
        {
            _context = context;
        }

        public virtual async Task<IEnumerable<Department>> GetHRDepartment(int DeptId)
        {
            return await _context.Departments
                            .Include(his => his.EmployeeDepartmentHistories)
                            .Where(p => p.DepartmentId == DeptId)
                            .AsNoTracking()
                            .ToListAsync();
        }
    }
}
