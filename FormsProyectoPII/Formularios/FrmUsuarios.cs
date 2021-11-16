using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibProyectoPII;
using Newtonsoft.Json;

namespace FormsProyectoPII
{
    public partial class FrmUsuarios : Form
    {
        private List<Usuario> lUsuarios = new List<Usuario>();
        private RutasUsuario ru = new RutasUsuario();

        public FrmUsuarios()
        {
            InitializeComponent();
            dgvUsuarios.Focus();
            lUsuarios = new List<Usuario>();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int primero = 0;
            if (dgvUsuarios.Rows.Count == 0)
                primero = 1;
            pUsuarios.Controls.Clear();
            FrmUsuario altaUsuario = new FrmUsuario(CreUpReDe.Create, primero);
            altaUsuario.TopLevel = false;
            altaUsuario.alCerrar += AlCerrar;
            pUsuarios.Controls.Add(altaUsuario);
            altaUsuario.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningún usuario para modificar");
            }
            else
            {
                int _idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                string _nombreUsuario = Convert.ToString(dgvUsuarios.CurrentRow.Cells[1].Value);
                string _apellidoUsuario = Convert.ToString(dgvUsuarios.CurrentRow.Cells[2].Value);
                int _tipoUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[6].Value);
                string _telefonoUsuario = Convert.ToString(dgvUsuarios.CurrentRow.Cells[4].Value);
                string _passwordUsuario = "";
                string _userUsuario = "";
                string _documentoUsuario = Convert.ToString(dgvUsuarios.CurrentRow.Cells[5].Value);


                Usuario oUsuario = new Usuario(_idUsuario, _nombreUsuario, _apellidoUsuario, _telefonoUsuario,
                                               _documentoUsuario, _tipoUsuario, _userUsuario, _passwordUsuario);

                pUsuarios.Controls.Clear();
                FrmUsuario modUsuario = new FrmUsuario(CreUpReDe.Update, oUsuario);
                modUsuario.TopLevel = false;
                modUsuario.alCerrar += AlCerrar;
                pUsuarios.Controls.Add(modUsuario);
                modUsuario.Show();
            }
        }

        private async void btnElminar_Click(object sender, EventArgs e)
        {
            bool loquevino = false;
            DialogResult dialogResult;
            if (dgvUsuarios.Rows.Count > 0)
            {
                dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el Usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("No existe ningún viaje para eliminar");
                dialogResult = DialogResult.No;
            }

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var result = await ClienteSingleton.GetInstance().DeleteAsync(ru.Baja + Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
                    loquevino = JsonConvert.DeserializeObject<bool>(result);
                }
                catch
                {
                    MessageBox.Show("Falló la conexión");
                }
                
                if (loquevino)
                    MessageBox.Show("El usuario se eliminó con éxito");
                else
                    MessageBox.Show("El usuarios no se pudo eliminar");

                CargarGrilla();
            }
        }

        private void AlCerrar(Object sender, EventArgs e)
        {
            pUsuarios.Controls.Clear();
            pUsuarios.Controls.Add(gbUsuarios);
            CargarGrilla();
        }

        private async void CargarGrilla()
        {
            string tipoUser;
            dgvUsuarios.Rows.Clear();
            try
            {
                var result = await ClienteSingleton.GetInstance().GetAsync(ru.Todos);
                lUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(result);
            }
            catch
            {
                MessageBox.Show("Falló la conexión");
            }
            
            foreach (Usuario usuario in lUsuarios)
            {
                if (usuario.TipoUsuario == 1)
                    tipoUser = "Administrador";
                else
                    tipoUser = "Camionero";
                dgvUsuarios.Rows.Add(new object[] { usuario.Id, usuario.Nombre, usuario.Apellido,
                tipoUser,usuario.Telefono, usuario.Documento,usuario.TipoUsuario }); 
            }
        }
    }
}
