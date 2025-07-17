using System.Collections.Generic;

namespace MantenimientoTrabajadores.Models
{
    public class TrabajadorViewModel
    {
        public List<Trabajador> ListaTrabajadores { get; set; } = new();

        // Agrega esta propiedad si la necesitas en el formulario
        public Trabajador NuevoTrabajador { get; set; } = new();
    }
}
