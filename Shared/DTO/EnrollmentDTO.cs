using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCTOBER.Shared.DTO
{
     public class EnrollmentDTO
    {
        [Precision(8)]
        public int CourseNo { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        public decimal? Cost { get; set; }
        [Precision(8)]
        public int? Prerequisite { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
        [Key]
        [Precision(8)]
        public int SchoolId { get; set; }
        [Precision(8)]
        public int? PrerequisiteSchoolId { get; set; }
    }
}
