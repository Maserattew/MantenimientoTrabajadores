using System.ComponentModel.DataAnnotations.Schema;

namespace MantenimientoTrabajadores.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        [Column("NombreDepartamento")]
        public string Nombre { get; set; } = string.Empty;
    }
}
