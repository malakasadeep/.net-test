using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        
        [Required]
        [Display(Name = "Full Name")]
        [StringLength(100)]
        public string? FullName { get; set; }
        
        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string? Email { get; set; }
        
        [Required]
        [StringLength(100)]
        public string? Position { get; set; }
        
        [Required]
        [StringLength(100)]
        public string? Department { get; set; }
        
        [Phone]
        [StringLength(20)]
        public string? Phone { get; set; }
        
        [Required]
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        
        [StringLength(100)]
        [Display(Name = "Updated By")]
        public string? UpdatedBy { get; set; }
        
        [Display(Name = "Last Updated")]
        public DateTime Updated { get; set; }
    }
}