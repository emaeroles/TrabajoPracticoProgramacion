using Microsoft.AspNetCore.Mvc;
using LibProyectoPII;

namespace WebApiProyectoPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViajeController : ControllerBase
    {
        private IGestorViaje gestorViaje;

        public ViajeController(AbstractServiceFactory serviceFactory)
        {
            gestorViaje = serviceFactory.CrearGestorViaje();
        }

        [HttpGet("Viajes")]
        public ActionResult GetViaje()
        {
            return Ok(gestorViaje.ListaViajes());
        }

        [HttpGet("Id")]
        public ActionResult GetId()
        {
            return Ok(gestorViaje.ProximoId());
        }

        [HttpGet("Cargas{id}")]
        public ActionResult GetCargas(int id)
        {
            return Ok(gestorViaje.ListaCargas(id));
        }

        [HttpPut("Finalizar")]
        public ActionResult FinalizarViaje(Viaje viaje)
        {
            if (viaje == null)
                return BadRequest("Parametro Invalido");
            return Ok(gestorViaje.FinalizarViaje(viaje.Id, viaje.FechaLlegada));
        }

        [HttpPost("Alta")]
        public ActionResult AltaViaje(Viaje viaje)
        {
            if (viaje == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorViaje.CreateUpdate(viaje, CreUpReDe.Create));
        }

        [HttpPut("Actualizar")]
        public ActionResult UpdateViaje(Viaje viaje)
        {
            if (viaje == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorViaje.CreateUpdate(viaje, CreUpReDe.Update));
        }

        [HttpPut("Partir")]
        public ActionResult UpdateUsuario(Viaje viaje)
        {
            if (viaje == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorViaje.Partir(viaje.Id, viaje.FechaSalida));
        }

        [HttpDelete("DescargarCarga")]
        public ActionResult DescargarCarga(Carga carga)
        {
            if (carga == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorViaje.DescargarCarga(carga.IdViaje, carga.Id));
        }

        [HttpDelete("DescargarCamion{id}")]
        public ActionResult DescargarCamion(int id)
        {
            if (id <= 0)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorViaje.DescargarCamion(id));
        }
       
    }
}
