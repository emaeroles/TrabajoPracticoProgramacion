using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibProyectoPII;
using Newtonsoft.Json;

namespace FormsProyectoPII
{
    public partial class FrmCamion : Form
    {
        private CreUpReDe creUpReDe;
        private Camion camion = new Camion();
        private int _idCamion;
        private RutasCamion rc = new RutasCamion();
        private RutasUsuario ru = new RutasUsuario();

        public event EventHandler alCerrar;

        public FrmCamion(CreUpReDe creUpReDe, int primero)
        {
            InitializeComponent();
            this.creUpReDe = creUpReDe;
            if (primero == 1)
                _idCamion = primero;
            else
                ProximoId();
            btnReparacion.Enabled = false;
            lblReparacion.Visible = false;
        }
        public FrmCamion(CreUpReDe creUpReDe, Camion oCamion)
        {
            InitializeComponent();
            this.creUpReDe = creUpReDe;
            camion = oCamion;
            
            if (Convert.ToInt32(camion.Estado) == 3)
            {
                btnReparacion.Text = "Reparado";
                lblReparacion.Visible = true;
            }
            else
            {
                lblReparacion.Visible = false;
            }
        }

        private void frmAltaCamion_Load(object sender, EventArgs e)
        {
            if (creUpReDe == CreUpReDe.Update)
            {
                lblTitulo.Text = "Modificar un camion";
                txtPatente.Text = camion.Patente.ToString();
                txtMarca.Text = camion.Descripcion.ToString();
                txtPesoMax.Text = camion.PesoMaximo.ToString();
                BloquearCampos();
            }
            CargarCombo();
            txtPatente.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alCerrar(this, EventArgs.Empty);
            this.Close();
        }

        private void BloquearCampos()
        {
            txtPatente.Enabled = false;
            txtMarca.Enabled = false;
            txtPesoMax.Enabled = false;
        }

        private async void CargarCombo()
        {
            List<Usuario> lUsuarios = new List<Usuario>();
            try
            {
                var result = await ClienteSingleton.GetInstance().GetAsync(ru.Camioneros);
                lUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(result);
            }
            catch
            {
                MessageBox.Show("Falló la conexión");
            }
            cboCamionero.DataSource = lUsuarios;
            cboCamionero.DisplayMember = "Nombre";
            cboCamionero.ValueMember = "Id";
            if (creUpReDe == CreUpReDe.Create)
                cboCamionero.SelectedIndex = -1;
        }

        private async void ProximoId()
        {
            try
            {
                var result = await ClienteSingleton.GetInstance().GetAsync(rc.Id);
                _idCamion = Convert.ToInt32(result);
            }
            catch
            {
                MessageBox.Show("Falló la conexión");
            }
        }

        private async void btnReparacion_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(camion.Estado) != 2)
            {
                if (Convert.ToInt32(camion.Estado) == 1)
                {
                    camion.Estado = Estados.Reparacion;
                    btnReparacion.Text = "Reparado";
                    lblReparacion.Visible = true;
                }
                else
                {
                    camion.Estado = Estados.Disponible;
                    btnReparacion.Text = "Reparar";
                    lblReparacion.Visible = false;
                }
                try
                {
                    string strCamion = JsonConvert.SerializeObject(camion);
                    var result = await ClienteSingleton.GetInstance().PutAsync(rc.EstSit, strCamion);
                    bool loquevino = JsonConvert.DeserializeObject<bool>(result);
                    if (!loquevino)
                        MessageBox.Show("El camión no se pudo poner en reparación");
                }
                catch
                {
                    MessageBox.Show("Falló la conexión");
                }
            }
            else
            {
                MessageBox.Show("No se puede reparar porque está en Ruta");
            }
            
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                bool loquevino = false;

                string _descCamion = txtMarca.Text;
                string _patenteCamion = txtPatente.Text;
                int _idCamionero = Convert.ToInt32(cboCamionero.SelectedValue);
                Estados _estadoCamion = Estados.Disponible;
                decimal _pesoMaximo = Convert.ToDecimal(txtPesoMax.Text);
                string _situadoCamion = "Cordoba";

                camion = new Camion(_idCamion, _descCamion, _patenteCamion, _idCamionero,
                                    _estadoCamion, _pesoMaximo, _situadoCamion);

                if (creUpReDe == CreUpReDe.Create)
                {
                    try
                    {
                        string strCamion = JsonConvert.SerializeObject(camion);
                        var result = await ClienteSingleton.GetInstance().PostAsync(rc.Alta, strCamion);
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
                        string strCamion = JsonConvert.SerializeObject(camion);
                        var result = await ClienteSingleton.GetInstance().PutAsync(rc.Actualizar, strCamion);
                        loquevino = JsonConvert.DeserializeObject<bool>(result);
                    }
                    catch
                    {
                        MessageBox.Show("Falló la conexión");
                    }
                }
                if (loquevino)
                    MessageBox.Show("El camion se guardo o actualizo con éxito");
                else
                    MessageBox.Show("El camion no se pudo guardar o actualizar");

                alCerrar(this, EventArgs.Empty);
                this.Close();
            }
        }

        private bool Validar()
        {
            if (txtPatente.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una patente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtMarca.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar la marca del camion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboCamionero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Camionero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtPesoMax.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el Peso Maximo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void txtPesoMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
