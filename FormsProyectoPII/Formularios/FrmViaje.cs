using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibProyectoPII;
using Newtonsoft.Json;

namespace FormsProyectoPII
{
    public partial class FrmViaje : Form
    {
        private CreUpReDe creUpReDe;
        private Viaje viaje = new Viaje();
        private Camion camion = new Camion();
        private RutasViaje rv = new RutasViaje();
        private RutasCamion rc = new RutasCamion();

        public event EventHandler alCerrar;

        public FrmViaje(CreUpReDe que, int primero)
        {
            InitializeComponent();
            viaje = new Viaje();
            creUpReDe = que;
  
            //if (primero == 1)
            //    viaje.Id = primero;
            //else
                ProximoId();
        }

        public FrmViaje(Viaje viaje, CreUpReDe que)
        {
            InitializeComponent();
            this.viaje = viaje;
            creUpReDe = que;
        }

        private void BloquearViaje()
        {
            txtDestino.Enabled = false;
            cboCamion.Enabled = false;
            if (camion.Estado == Estados.Ruta)
            {
                btnAceptar.Enabled = false;
            }
        }

        private async void FrmViaje_Load(object sender, EventArgs e)
        {
            await CargarCombo();

            if (camion != null)
                Estado(camion.Estado);

            txtOrigen.Enabled = false;

            if (creUpReDe == CreUpReDe.Update)
            {
                txtOrigen.Text = viaje.Origen;
                txtDestino.Text = viaje.Destino;
                lblViaje.Text = "Viaje Nº: " + viaje.Id;
                BloquearViaje();
                await CargarCargas();
            }

            ChangeCbo();
            cboCamion.Focus();
        }

        private async Task CargarCargas()
        {
            string strTipo;
            try
            {
                var result = await ClienteSingleton.GetInstance().GetAsync(rv.GetCargas + viaje.Id);
                viaje.LCargas = JsonConvert.DeserializeObject<List<Carga>>(result);
            }
            catch
            {
                MessageBox.Show("Falló la conexión");
            }
            
            foreach (Carga c in viaje.LCargas)
            {
                if (c.TipoCarga == TiposDeCarga.Packing)
                    strTipo = "Packing";
                else if (c.TipoCarga == TiposDeCarga.Caja)
                    strTipo = "Caja";
                else
                    strTipo = "Bidon";

                dgvCargas.Rows.Add(new object[] { c.Id, strTipo, c.Peso });
            }
        }

        private async Task CargarCombo()
        {
            List<Camion> lCamiones = new List<Camion>();
            if (creUpReDe == CreUpReDe.Create)
            {
                try
                {
                    var result = await ClienteSingleton.GetInstance().GetAsync(rc.Libres);
                    lCamiones = JsonConvert.DeserializeObject<List<Camion>>(result);
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
                    var result = await ClienteSingleton.GetInstance().GetAsync(rc.CamionById + viaje.IdCamion);
                    camion = JsonConvert.DeserializeObject<Camion>(result);
                    lCamiones.Add(camion);
                }
                catch
                {
                    MessageBox.Show("Falló la conexión");
                }
            }
            cboCamion.DataSource = lCamiones;
            cboCamion.DisplayMember = "Descripcion";
            cboCamion.ValueMember = "Id";
        }

        private async void ProximoId()
        {
            try
            {
                var result = await ClienteSingleton.GetInstance().GetAsync(rv.Id);
                viaje.Id = Convert.ToInt32(result);
                lblViaje.Text = "Viaje Nº: " + viaje.Id.ToString();
            }
            catch
            {
                MessageBox.Show("Falló la conexión");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarAgregar())
            {
                int idCarga;

                if (viaje.LCargas.Count == 0)
                    idCarga = 1;
                else
                    idCarga = viaje.UltimoId();

                TiposDeCarga tipo = (TiposDeCarga)cboTipoCarga.SelectedIndex + 1;
                decimal peso = Convert.ToDecimal(txtPeso.Text);

                Carga carga = new Carga(idCarga, viaje.Id, tipo, peso);

                this.viaje.AgregarDetalle(carga);

                string strTipo;

                if (tipo == TiposDeCarga.Packing)
                    strTipo = "Packing";
                else if (tipo == TiposDeCarga.Caja)
                    strTipo = "Caja";
                else
                    strTipo = "Bidon";

                dgvCargas.Rows.Add(new object[] { idCarga, strTipo, peso });

                ActualizarLabels();
            }
            cboTipoCarga.Focus();
        }

        private void dgvViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCargas.CurrentCell.ColumnIndex == 3)
            {
                viaje.QuitarDetalle(Convert.ToInt32(dgvCargas.CurrentRow.Cells[0].Value));
                dgvCargas.Rows.Remove(dgvCargas.CurrentRow);
                ActualizarLabels();
            }   
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarAceptar())
            {
                await Guardar();

                alCerrar(this, EventArgs.Empty);
                this.Close();
            }
        }

        private async Task Guardar()
        {
            bool loquevino = false;

            if (creUpReDe == CreUpReDe.Create)
            {
                viaje.IdCamion = Convert.ToInt32(cboCamion.SelectedValue);
                viaje.Origen = txtOrigen.Text;
                viaje.Destino = txtDestino.Text;

                try
                {
                    string strViaje = JsonConvert.SerializeObject(viaje);
                    var result = await ClienteSingleton.GetInstance().PostAsync(rv.Alta, strViaje);
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
                    string strViaje = JsonConvert.SerializeObject(viaje);
                    var result = await ClienteSingleton.GetInstance().PutAsync(rv.Actualizar, strViaje);
                    loquevino = JsonConvert.DeserializeObject<bool>(result);
                }
                catch
                {
                    MessageBox.Show("Falló la conexión");
                }
            }
            if (loquevino)
                MessageBox.Show("El viaje se guardo o actualizo con éxito");
            else
                MessageBox.Show("El viaje no se pudo guardar o actualizar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alCerrar(this, EventArgs.Empty);
            this.Close();
        }

        private async void btnPartir_Click(object sender, EventArgs e)
        {
            if (ValidarPartir() && ValidarAceptar())
            {
                if (camion.Estado == Estados.Disponible)
                {
                    await Guardar();

                    camion.Estado = Estados.Ruta;
                    btnPartir.Text = "Arribar";
                    lblEstado.Text = "En Ruta";
                    BloquearCargas(false);
                    BloquearViaje();

                    try
                    {
                        viaje.FechaSalida = DateTime.Today;
                        string strViaje = JsonConvert.SerializeObject(viaje);
                        var result1 = await ClienteSingleton.GetInstance().PutAsync(rv.Partir, strViaje);
                        bool loquevino1 = JsonConvert.DeserializeObject<bool>(result1);
                        if (!loquevino1)
                            MessageBox.Show("El viaje no pudo partir");
                    }
                    catch
                    {
                        MessageBox.Show("Falló la conexión");
                    }
                }
                else
                {
                    camion.Estado = Estados.Disponible;
                    camion.Situado = txtDestino.Text;
                    btnPartir.Text = "Partir";
                    lblEstado.Text = "Disponible";
                    BloquearCargas(true);

                    viaje.FechaLlegada = DateTime.Today;

                    try
                    {
                        string strViaje = JsonConvert.SerializeObject(viaje);
                        var result2 = await ClienteSingleton.GetInstance().PutAsync(rv.Finalizar, strViaje);
                        bool loquevino2 = JsonConvert.DeserializeObject<bool>(result2);

                        if (loquevino2)
                            MessageBox.Show("El viaje finalizo con éxito");
                        else
                            MessageBox.Show("El viaje no pudo ser finalizado");

                        alCerrar(this, EventArgs.Empty);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Falló la conexión");
                    }
                }
                try
                {
                    string strCamion = JsonConvert.SerializeObject(camion);
                    var result = await ClienteSingleton.GetInstance().PutAsync(rc.EstSit, strCamion);
                    string loquevino = JsonConvert.DeserializeObject<string>(result);
                }
                catch
                {
                    MessageBox.Show("Falló la conexión");
                }
            }
        }

        private void Estado(Estados estado)
        {
            if (estado == Estados.Ruta)
            {
                btnPartir.Text = "Arribar";
                lblEstado.Text = "En Ruta";
                BloquearCargas(false);
            }
            else
            {
                btnPartir.Text = "Partir";
                lblEstado.Text = "Disponible";
                BloquearCargas(true);
            }
        }

        private void BloquearCargas(bool b)
        {
            cboTipoCarga.Enabled = b;
            txtPeso.Enabled = b;
            btnAgregar.Enabled = b;
            dgvCargas.Enabled = b;
        }

        private void cboCamion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeCbo();
        }

        private void ChangeCbo()
        {
            this.camion = (Camion)cboCamion.SelectedItem;
            txtOrigen.Text = camion.Situado;
            ActualizarLabels();
        }

        private void ActualizarLabels()
        {
            if (camion != null && viaje != null)
            {
                lblPorcentageCarga.Text = decimal.Round(camion.CalcPorcentageCarga(viaje.CalcPesoCargas()),2).ToString() + " % de carga";
                lblPesoRestante.Text = "Peso restante: " + decimal.Round(camion.CalcCargaResatante(viaje.CalcPesoCargas()),2).ToString();
            }
            else
            {
                lblPorcentageCarga.Text = "0 % de carga";
                lblPesoRestante.Text = "Peso restante: 0";
            }
        }

        private bool ValidarAceptar()
        {
            if (txtDestino.Text == string.Empty)
            {
                MessageBox.Show("Debe rellenar el campo destino", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (dgvCargas.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una carga", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool ValidarAgregar()
        {
            decimal validarPeso = 0;
            if (txtPeso.Text != string.Empty)
                validarPeso = camion.CalcCargaResatante(viaje.CalcPesoCargas() + Convert.ToInt32(txtPeso.Text));

            if (validarPeso < 0)
            {
                MessageBox.Show("La carga es muy pesada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboTipoCarga.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de carga", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtPeso.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un peso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool ValidarPartir()
        {
            if (camion.CalcPorcentageCarga(viaje.CalcPesoCargas()) < 75)
            {
                MessageBox.Show("El camión debe estar a más del 75% para partir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
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
