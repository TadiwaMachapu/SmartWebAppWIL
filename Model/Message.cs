using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartWebAPI.Model
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }

        [Required]
        public int SenderId { get; set; }

        [ForeignKey("SenderId")]
        public User Sender { get; set; }

        [Required]
        public int RecipientId { get; set; }

        [ForeignKey("RecipientId")]
        public User Recipient { get; set; }

        public string MessageText { get; set; }

        public DateTime SentAt { get; set; } = DateTime.Now;
    }
}
