using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompartido
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(string _nombre, String _email, string _telefono)
        {
            Nombre = _nombre;
            Email = _email;
            Telefono = _telefono;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "El email no tiene un formato válido")]
        public string Email { get; set; } = string.Empty;
        [Phone(ErrorMessage = "El email no tiene un formato válido")]
        public string Telefono { get; set; }
    }
}