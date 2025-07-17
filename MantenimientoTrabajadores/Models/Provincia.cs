using System.ComponentModel.DataAnnotations.Schema;

namespace MantenimientoTrabajadores.Models
{
    public class Provincia
    {
        public int Id { get; set; }

        [Column("IdDepartamento")]
        public int? IdDepartamento { get; set; }

        [Column("NombreProvincia")]
        public string Nombre { get; set; } = string.Empty;

        [ForeignKey(nameof(IdDepartamento))]
        public Departamento? Departamento { get; set; }
    }
}
