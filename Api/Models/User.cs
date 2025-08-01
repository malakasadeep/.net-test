namespace Api.Models
{
    public class User
    {
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? Mobile { get; set; }
    public string? Email { get; set; }
    public string? Department { get; set; }
    public string? Designation { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime Updated { get; set; }
    }
}