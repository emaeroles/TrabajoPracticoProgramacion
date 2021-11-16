using System;
using System.Text;
using System.Windows.Forms;
using LibProyectoPII;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace FormsProyectoPII
{
    public partial class FrmUsuario : Form
    {
        private CreUpReDe creUpReDe;
        private int _idUsuario;
        private Usuario usuario = new Usuario();
        private RutasUsuario ru = new RutasUsuario();

        public event EventHandler alCerrar;

        public FrmUsuario(CreUpReDe que, int primero)
        {
            InitializeComponent();
            creUpReDe = que;
            if (primero == 1)
                _idUsuario = primero;
            else
                ProximoId();
        }
        public FrmUsuario(CreUpReDe que, Usuario oUsuario)
        {
            InitializeComponent();
            creUpReDe = que;
            usuario = oUsuario;
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            if (creUpReDe == CreUpReDe.Update)
            {
                lblAltaUsuario.Text = "Modificar un usuario";
                _idUsuario = usuario.Id;
                txtApellido.Text = usuario.Apellido;
                txtNombre.Text = usuario.Nombre;
                txtTelefono.Text = usuario.Telefono;
                txtDocumento.Text = usuario.Documento;
                if (usuario.TipoUsuario == 1)
                    cboTipo.SelectedIndex = 0;
                else
                    cboTipo.SelectedIndex = 1;
                txtUsername.Text = usuario.UserName;
            }
            txtNombre.Focus();
        }

        private async void ProximoId()
        {
            try
            {
                var result = await ClienteSingleton.GetInstance().GetAsync(ru.Id);
                _idUsuario = Convert.ToInt32(result);
            }
            catch
            {
                MessageBox.Show("Falló la conexión");
            }
        }

        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                bool loquevino = false;

                string _userUsuario;
                string _passUsuario;
                string _nombreUsuario = txtNombre.Text;
                string _apellidoUsuario = txtApellido.Text;
                string _telefonoUsuario = txtTelefono.Text;
                int _tipoUsuario = cboTipo.SelectedIndex + 1;
                string _documentoUsuario = txtDocumento.Text;
                if(txtUsername.Text == string.Empty)
                    _userUsuario = "0";
                else
                    _userUsuario = txtUsername.Text;
                if (txtPassword.Text == string.Empty)
                    _passUsuario = "0";
                else
                    _passUsuario = GetSHA256(txtPassword.Text);

                usuario = new Usuario(_idUsuario, _nombreUsuario, _apellidoUsuario, _telefonoUsuario,
                                      _documentoUsuario, _tipoUsuario, _userUsuario, _passUsuario);

                if (creUpReDe == CreUpReDe.Create)
                {
                    try
                    {
                        string strUsuario = JsonConvert.SerializeObject(usuario);
                        var result = await ClienteSingleton.GetInstance().PostAsync(ru.Alta, strUsuario);
                        loquevino = JsonConvert.DeserializeObject<bool>(result);
                    }
                    catch
                    {
                        MessageBox.Show("Falló la conexión");
                    }
                }
                else
                {
                    try
                    {
                        string strUsuario = JsonConvert.SerializeObject(usuario);
                        var result = await ClienteSingleton.GetInstance().PutAsync(ru.Actualizar, strUsuario);
                        loquevino = JsonConvert.DeserializeObject<bool>(result);
                    }
                    catch
                    {
                        MessageBox.Show("Falló la conexión");
                    }
                }
                if (loquevino)
                    MessageBox.Show("El usuario se guardo o actualizo con éxito");
                else
                    MessageBox.Show("El usuario no se pudo guardar o actualizar");

                alCerrar(this, EventArgs.Empty);
                this.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alCerrar(this, EventArgs.Empty);
            this.Close();
        }

        private bool Validar()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un apellido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un numero de telefono", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDocumento.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if ((txtUsername.Text == string.Empty || txtUsername.Text.Length < 5) && creUpReDe == CreUpReDe.Create)
            {
                MessageBox.Show("Debe ingresar un nombre de usuario valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if ((txtPassword.Text == string.Empty || txtPassword.Text.Length < 6) && creUpReDe == CreUpReDe.Create)
            {
                MessageBox.Show("Debe ingresar una contraseña valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtUsername.Text != string.Empty && txtUsername.Text.Length < 5 && creUpReDe == CreUpReDe.Update)
            {
                MessageBox.Show("Debe ingresar un nombre de usuario valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtPassword.Text != string.Empty && txtPassword.Text.Length < 6 && creUpReDe == CreUpReDe.Update)
            {
                MessageBox.Show("Debe ingresar una contraseña valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
