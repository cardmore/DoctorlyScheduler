using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctorly.Domain.Main.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int EventAppointmentID { get; set; }
        public int DoctorID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string Comments { get; set; }
    }
}
