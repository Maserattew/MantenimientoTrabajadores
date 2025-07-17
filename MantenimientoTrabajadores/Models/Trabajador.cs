using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MantenimientoTrabajadores.Models
{
    public class Trabajador
    {
        public int Id { get; set; }

        [Column("TipoDocumento")]
        public string TipoDocumento { get; set; } = string.Empty;

        [Column("NumeroDocumento")]
        public string NumeroDocumento { get; set; } = string.Empty;

        [Column("Nombres")]
        public string Nombres { get; set; } = string.Empty;

        [Column("Sexo")]
        public string Sexo { get; set; } = string.Empty;

        // Claves foráneas con mapeo explícito a columnas
        [Column("IdDepartamento")]
        public int? IdDepartamento { get; set; }

        [Column("IdProvincia")]
        public int? IdProvincia { get; set; }

        [Column("IdDistrito")]
        public int? IdDistrito { get; set; }

        // Propiedades de navegación con ForeignKey apuntando a las FK correctas
        [ForeignKey(nameof(IdDepartamento))]
        public Departamento? Departamento { get; set; }

        [ForeignKey(nameof(IdProvincia))]
        public Provincia? Provincia { get; set; }

        [ForeignKey(nameof(IdDistrito))]
        public Distrito? Distrito { get; set; }
    }
}
