 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ProyectoCompartido
{
    public class Proveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "El email no tiene un formato válido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La dirección es obligatoria")]
        public string Direccion { get; set; } = string.Empty;

        [Phone]
        public string Telefono { get; set; } = string.Empty;

        // Navegación hacia los productos del proveedor
        [JsonIgnore]
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
       
        public Proveedor() { }
        public Proveedor(string nombre, string email, string direccion, string telefono)
        {
            Nombre = nombre;
            Email = email;
            Direccion = direccion;
            Telefono = telefono;            
        }

    }
}
