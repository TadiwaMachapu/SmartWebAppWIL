using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartWebAPI.Model
{
    public class Incident
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IncidentId { get; set; }

        [Required]
        public int ReporterId { get; set; }

        [ForeignKey("ReporterId")]
        public User Reporter { get; set; }

        [Required]
        [StringLength(50)]
        public string IncidentType { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime ReportedAt { get; set; } = DateTime.Now;

        // Navigation property for IncidentLogs
        public ICollection<IncidentLog> Logs { get; set; }
    }
}
