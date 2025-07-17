using System.ComponentModel.DataAnnotations.Schema;

namespace MantenimientoTrabajadores.Models
{
    public class Distrito
    {
        public int Id { get; set; }

        [Column("IdProvincia")]
        public int? IdProvincia { get; set; }

        [Column("NombreDistrito")]
        public string Nombre { get; set; } = string.Empty;

        [ForeignKey(nameof(IdProvincia))]
        public Provincia? Provincia { get; set; }
    }
}
