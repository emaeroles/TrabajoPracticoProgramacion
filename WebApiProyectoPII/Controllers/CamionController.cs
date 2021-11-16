using Microsoft.AspNetCore.Mvc;
using LibProyectoPII;

namespace WebApiProyectoPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamionController : ControllerBase
    {
        private IGestorCamion gestorCamion;

        public CamionController(AbstractServiceFactory  serviceFactory)
        {
            gestorCamion = serviceFactory.CrearGestorCamion();
        }

        [HttpGet("Camiones")]
        public ActionResult GetCamiones()
        {
            return Ok(gestorCamion.ListaCamiones(Camiones.Todos));
        }

        [HttpGet("Camion{id}")]
        public ActionResult GetCamion(int id)
        {
            if (id <= 0)
                return BadRequest("Parametro Invalido");
            return Ok(gestorCamion.GetCamion(id));
        }

        [HttpGet("CamionesLibres")]
        public ActionResult GetCamionesLibres()
        {
            return Ok(gestorCamion.ListaCamiones(Camiones.Libres));
        }

        [HttpGet("Id")]
        public ActionResult GetId()
        {
            return Ok(gestorCamion.ProximoId());
        }

        [HttpDelete("Baja{id}")]
        public ActionResult BejaCamion(int id)
        {
            if (id <= 0)
                return BadRequest("Parametro Invalido");
            return Ok(gestorCamion.Baja(id));
        }

        [HttpPost("Alta")]
        public ActionResult AltaCamion(Camion camion)
        {
            if (camion == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorCamion.CreateUpdate(camion, CreUpReDe.Create));
        }

        [HttpPut("Actualizar")]
        public ActionResult UpdateCamion(Camion camion)
        {
            if (camion == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorCamion.CreateUpdate(camion, CreUpReDe.Update));
        }

        [HttpPut("CambioEstadoSituado")]
        public ActionResult CambioEstadoSituado(Camion camion)
        {
            if (camion == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorCamion.CambioEstadoSutuado(camion.Id, camion.Estado, camion.Situado));
        }
    }
}
