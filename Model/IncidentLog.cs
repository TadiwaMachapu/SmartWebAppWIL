using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartWebAPI.Model
{
    public class IncidentLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogId { get; set; }

        [Required]
        public int IncidentId { get; set; }

        [ForeignKey("IncidentId")]
        public Incident Incident { get; set; }

        public DateTime LogTime { get; set; } = DateTime.Now;

        [StringLength(255)]
        public string ActionDescription { get; set; }
    }
}
