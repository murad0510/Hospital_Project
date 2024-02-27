using HospitalProject.Core.DataAccess;
using HospitalProject.Entities.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.Abstract
{
    public interface IPatientDal:IEntityRepository<Patient>
    {
    }
}
