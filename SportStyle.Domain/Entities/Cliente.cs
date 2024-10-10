using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace SportStyle.Domain.Entities;

[Table("Cliente")]
public class Cliente
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
    protected int CodigoRecuperacion {get; set;}

    [Required]
    [StringLength(50)]
    public string  Direccion {get; set;}=string.Empty;

    [Required]
    public bool Bloqueado {get; set;}
    public Cliente(string email, string password,int telefono, string nameUSuario, string nombre, int DNI, int CodigoRecuperacion,string direccion, bool bloqueado)
    {
        Email = email;
        Password = password;
        Telefono = telefono;
        this.nameUSuario = nameUSuario;
        Nombre = nombre;
        this.DNI = DNI;
        this.CodigoRecuperacion = CodigoRecuperacion;
        Direccion = direccion;
        Bloqueado = bloqueado;
    }
}
