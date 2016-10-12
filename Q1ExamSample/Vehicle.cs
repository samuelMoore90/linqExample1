using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1ExamSample
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public int ServiceID { get; set; }
        public string VehicleType { get; set; }
        public int RegistrationYear { get; set; }
    }

    public class VehicleService
    {
        public int ServiceID { get; set; }
        public int Mileage { get; set; }
        public int MLS { get; set; }
        public int RFA { get; set; }
    }
}
