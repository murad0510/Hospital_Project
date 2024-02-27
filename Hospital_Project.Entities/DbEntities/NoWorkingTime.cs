using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities.DbEntities
{
    public class NoWorkingTime
    {
        public int Id { get; set; }
        public string? DoctorId { get; set; }
        public DateTime Day { get; set; }
    }
}