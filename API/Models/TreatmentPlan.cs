using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prn_dentistry.API.Models
{
  public class TreatmentPlan
  {
    [Key]
    public int PlanID { get; set; }

    [ForeignKey("Customer")]
    public int CustomerID { get; set; }
    public Customer Customer { get; set; }

    [ForeignKey("Dentist")]
    public int DentistID { get; set; }
    public Dentist Dentist { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Frequency { get; set; }
    public DateTime NextAppointmentDate { get; set; }
  }
}