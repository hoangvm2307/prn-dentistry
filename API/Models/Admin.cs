using System.ComponentModel.DataAnnotations;

namespace prn_dentistry.API.Models
{
  public class Admin
  {
    [Key]
    public int AdminID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
  }
}