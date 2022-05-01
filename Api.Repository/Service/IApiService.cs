using Api.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository.Service
{
    public interface IApiService
    {
        public abstract Task<IEnumerable<Department>> GetHRDepartment(int DeptId);
    }
}
