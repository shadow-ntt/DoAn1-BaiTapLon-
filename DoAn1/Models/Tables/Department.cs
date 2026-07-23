using System.ComponentModel.DataAnnotations;

public class Department
{
    [Key]
    [Required]
    public string DepartmentId { get; set; }
    [Required]
    public string DepartmentCode { get; set; } = string.Empty;

    [Required]
    public string DepartmentName { get; set; } = string.Empty;
}