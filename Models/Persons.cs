using System.ComponentModel.DataAnnotations;
namespace RepositoryAPIs.Models;

public class Persons
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string NombreCompleto { get; set; }
    [Required]
    public string Email { get; set; }
}