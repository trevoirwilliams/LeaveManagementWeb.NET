using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        [Required]
        [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
        public int NumberOfDays { get; set; }

        [Required]
        [Display(Name = "Allocation Period")]
        public int Period { get; set; }

        public LeaveTypeVM? LeaveType { get; set; }
    }
}