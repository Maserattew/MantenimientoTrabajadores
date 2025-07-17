using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MantenimientoTrabajadores.Models;

namespace MantenimientoTrabajadores.Controllers
{
    public class TrabajadoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrabajadoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new TrabajadorViewModel
            {
                ListaTrabajadores = _context.Trabajadores
                    .Include(t => t.Departamento)
                    .Include(t => t.Provincia)
                    .Include(t => t.Distrito)
                    .ToList()
            };

            ViewBag.Departamentos = _context.Departamentos.ToList();
            ViewBag.Provincias = _context.Provincias.ToList();
            ViewBag.Distritos = _context.Distritos.ToList();

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Obtener(int id)
        {
            var trabajador = _context.Trabajadores.Find(id);
            if (trabajador == null) return NotFound();

            return Json(trabajador);
        }

        [HttpPost]
        public IActionResult Create(Trabajador model)
        {
            if (!ModelState.IsValid)
            {
                var errores = ModelState
                    .Where(e => e.Value?.Errors.Count > 0)
                    .Select(e => $"{e.Key}: {string.Join(", ", e.Value!.Errors.Select(err => err.ErrorMessage))}");

                return BadRequest("Errores de validación:\n" + string.Join("\n", errores));
            }

            try
            {
                _context.Trabajadores.Add(model);
                _context.SaveChanges();
                return Ok();
            }
            catch (DbUpdateException ex)
            {
                // Captura errores típicos de base de datos (clave foránea, nulo, etc.)
                var inner = ex.InnerException?.Message ?? ex.Message;
                return BadRequest("Error de base de datos:\n" + inner);
            }
            catch (Exception ex)
            {
                // Captura cualquier otro error inesperado
                return BadRequest("Error inesperado:\n" + ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Edit(Trabajador model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var trabajador = _context.Trabajadores.Find(model.Id);
            if (trabajador == null) return NotFound();

            trabajador.TipoDocumento = model.TipoDocumento;
            trabajador.NumeroDocumento = model.NumeroDocumento;
            trabajador.Nombres = model.Nombres;
            trabajador.Sexo = model.Sexo;
            trabajador.IdDepartamento = model.IdDepartamento;
            trabajador.IdProvincia = model.IdProvincia;
            trabajador.IdDistrito = model.IdDistrito;

            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var trabajador = _context.Trabajadores.Find(id);
            if (trabajador == null) return NotFound();

            _context.Trabajadores.Remove(trabajador);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult TablaParcial(string? sexo)
        {
            var query = _context.Trabajadores
                .Include(t => t.Departamento)
                .Include(t => t.Provincia)
                .Include(t => t.Distrito)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(sexo))
                query = query.Where(t => t.Sexo == sexo);

            var lista = query.ToList();
            return PartialView("_TablaTrabajadoresPartial", lista);
        }
    }
}
