using HospitalProject.Core.DataAccess.EntityFramework;
using HospitalProject.DataAccess.Abstract;
using HospitalProject.Entities.Data;
using HospitalProject.Entities.DbEntities;

namespace HospitalProject.DataAccess.Concrete.EntityFramework
{
    public class EFDoctorDal: EFEntityFrameworkRepositoryBase<Doctor, CustomIdentityDbContext>, IDoctorDal
    {
    }
}
