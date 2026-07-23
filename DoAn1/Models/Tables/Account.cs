using DoAn1.Models.Tables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Account
{
    [Key]
    public int AccountId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Acc { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Pass { get; set; } = string.Empty;

    public int EmployeeId { get; set; }

    public Employee Employee { get; set; } = null!;
}