using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("UsuarioNoValido")]
public class UsuarioNoValido 
{
    
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCliente {get; set;}
    [Required]
    [StringLength(50)]
    public string Email {get; set;}=string.Empty;

    [Required]
    [StringLength(50)]
    public string Password {get; set;}=string.Empty;
    [Required]
    public int Telefono {get; set;}

    [Required]
    [StringLength(50)]
    public string nameUSuario {get; set;}=string.Empty;

    [Required]
    [StringLength(50)]
    public string Nombre {get; set;}=string.Empty;

    [Required]
    [StringLength(50)]
    public string Apellido {get; set;}=string.Empty;

    [Required]
    protected int DNI {get; set;}

    [Required]
    protected int codigoRecuperacion {get; set;}

    [Required]
    [StringLength(50)]
    public string  Direccion {get; set;}=string.Empty;

}
