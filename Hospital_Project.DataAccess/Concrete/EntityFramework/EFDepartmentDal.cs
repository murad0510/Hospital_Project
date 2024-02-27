//using Hospital.Core.DataAccess.EntityFramework;
//using Hospital.DataAccess.Abstract;
//using Hospital.Entities.Data;
//using HospitalProject.Entities.DbEntities;
using HospitalProject.Core.DataAccess.EntityFramework;
using HospitalProject.DataAccess.Abstract;
using HospitalProject.Entities.Data;
using HospitalProject.Entities.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.Concrete.EntityFramework
{
    public class EFDepartmentDal : EFEntityFrameworkRepositoryBase<Department, CustomIdentityDbContext>, IDepartmentDal
    {
    }
}
