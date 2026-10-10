
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models;

public class Expense
{
    public int Id { get; set; }

    // Assigned automatically from the signed-in user.
    // It is not part of the form's validation.
    public string UserId { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter a description.")]
    [StringLength(100)]
    public string Description { get; set; } = string.Empty;

    [Range(typeof(decimal), "0.01", "999999999.99",
        ErrorMessage = "Amount must be greater than zero.")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Please select a category.")]
    [StringLength(50)]
    public string Category { get; set; } = string.Empty;

    [Required]
    public DateTime Date { get; set; } = DateTime.Today;

    [StringLength(500)]
    public string? Notes { get; set; }
}
