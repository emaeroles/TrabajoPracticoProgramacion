using Microsoft.AspNetCore.Mvc;
using LibProyectoPII;

namespace WebApiProyectoPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IGestorUsuario gestorUsuario;
        
        public UsuarioController(AbstractServiceFactory serviceFactory)
        {
            gestorUsuario = serviceFactory.CrearGestorUsuario();
        }

        [HttpGet("Todos")]
        public ActionResult GetTodosLosUsuarios()
        {
            return Ok(gestorUsuario.ListaUsuarios(TiposUsers.Todos));
        }

        [HttpGet("Camioneros")]
        public ActionResult GetCamioneros()
        {
            return Ok(gestorUsuario.ListaUsuarios(TiposUsers.Camioneros));
        }

        [HttpPost("Logueo")]
        public ActionResult GetLogueo(Logueo logueo)
        {
            if (logueo == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorUsuario.Logueo(logueo.UserName, logueo.Password));
        }

        [HttpGet("Id")]
        public ActionResult GetId()
        {
            return Ok(gestorUsuario.ProximoId());
        }

        [HttpDelete("Baja{id}")]
        public ActionResult BejaUsuario(int id)
        {
            if (id <= 0)
                return BadRequest("Parametro Invalido");
            return Ok(gestorUsuario.Baja(id));
        }

        [HttpPost("Alta")]
        public ActionResult AltaUsuario(Usuario usuario)
        {
            if (usuario == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorUsuario.CreateUpdate(usuario, CreUpReDe.Create));
        }

        [HttpPut("Actualizar")]
        public ActionResult UpdateUsuario(Usuario usuario)
        {
            if (usuario == null)
                return BadRequest("No se encontraron parametros");
            return Ok(gestorUsuario.CreateUpdate(usuario, CreUpReDe.Update));
        }
    }
}
