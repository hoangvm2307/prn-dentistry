using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prn_dentistry.API.Models
{
  public class ChatMessage
  {
    [Key]
    public int MessageID { get; set; }

    [ForeignKey("Customer")]
    public int SenderID { get; set; }
    public Customer Sender { get; set; }

    [ForeignKey("Dentist")]
    public int ReceiverID { get; set; }
    public Dentist Receiver { get; set; }

    public string MessageContent { get; set; }
    public DateTime Timestamp { get; set; }
  }
}