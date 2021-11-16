using System;
using System.Collections.Generic;
using System.Data;

namespace LibProyectoPII
{
    class DaoUsuario : IDaoUsuario
    {
        public bool CreateUpdate(Usuario usuario, CreUpReDe que)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id", usuario.Id);
            parametros.Add("@nombre", usuario.Nombre);
            parametros.Add("@apellido", usuario.Apellido);
            parametros.Add("@telefono", usuario.Telefono);
            parametros.Add("@documento", usuario.Documento);
            parametros.Add("@id_tipo_usuario", usuario.TipoUsuario);
            parametros.Add("@user", usuario.UserName);
            parametros.Add("@pass", usuario.Password);

            if(que == CreUpReDe.Create)
                return HelperDao.ObtenerInstancia().EjectProcSimple("PA_INSERTAR_USUARIO", parametros);
            else
                return HelperDao.ObtenerInstancia().EjectProcSimple("PA_UPDATE_USUARIO", parametros);
        }

        public List<Usuario> ListaUsuarios(TiposUsers tipo)
        {
            List<Usuario> lUsuarios = new List<Usuario>();
            DataTable tabla = new DataTable();

            if(tipo == TiposUsers.Todos)
                tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_OBTENER_USUARIOS");
            else
                tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_OBTENER_CAMIONEROS_SIN_CAMION");

            foreach (DataRow row in tabla.Rows)
            {
                Usuario usuario = new Usuario(Convert.ToInt32(row["id_usuario"]),
                                              Convert.ToString(row["nombre"]),
                                              Convert.ToString(row["apellido"]),
                                              Convert.ToString(row["telefono"]),
                                              Convert.ToString(row["documento"]),
                                              Convert.ToInt32(row["id_tipo_usuario"]));

                lUsuarios.Add(usuario);
            }
            return lUsuarios;
        }

        public bool Logueo(string userName, string password)
        {
            DataTable tabla = new DataTable();

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@usuario", userName);
            parametros.Add("@pass", password);

            tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_LOGIN_USUARIO", parametros);

            if (Convert.ToInt32(tabla.Rows[0][0]) == 1)
            {
                return true;
            }
            return false;
        }

        public int ProximoId()
        {
            DataTable tabla = new DataTable();
            tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_PROXIMO_ID_USUARIO");
            int id = Convert.ToInt32(tabla.Rows[0][0]) + 1;
            return id;
        }

        public bool Baja(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id", id);
            return HelperDao.ObtenerInstancia().EjectProcSimple("PA_BAJA_USUARIO", parametros);
        }
    }
}
