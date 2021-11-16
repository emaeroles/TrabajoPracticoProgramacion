using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibProyectoPII;
using Newtonsoft.Json;

namespace FormsProyectoPII
{
    public partial class FrmCamiones : Form
    {
        private List<Camion> lCamiones = new List<Camion>();
        private RutasCamion rc = new RutasCamion();

        public FrmCamiones()
        {
            InitializeComponent();
        }

        private void frmCamiones_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            dgvCamiones.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int primero = 0;
            if (dgvCamiones.Rows.Count == 0)
                primero = 1;
            pCamiones.Controls.Clear();
            FrmCamion altaCamion = new FrmCamion(CreUpReDe.Create, primero);
            altaCamion.TopLevel = false;
            altaCamion.alCerrar += AlCerrar;
            pCamiones.Controls.Add(altaCamion);
            altaCamion.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCamiones.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningún camion para modificar");
            }
            else
            {
                int _idCamion = Convert.ToInt32(dgvCamiones.CurrentRow.Cells[0].Value);
                string _marcaCamion = Convert.ToString(dgvCamiones.CurrentRow.Cells[1].Value);
                string _patenteCamion = Convert.ToString(dgvCamiones.CurrentRow.Cells[2].Value);
                int _idCmionero = Convert.ToInt32(dgvCamiones.CurrentRow.Cells[3].Value);
                Estados _estadoCamion = (Estados)dgvCamiones.CurrentRow.Cells[4].Value;
                decimal _pesoMaximo = Convert.ToDecimal(dgvCamiones.CurrentRow.Cells[5].Value);
                string _situadoCamion = Convert.ToString(dgvCamiones.CurrentRow.Cells[6].Value);

                Camion oCamion = new Camion(_idCamion, _marcaCamion, _patenteCamion, _idCmionero,
                                            _estadoCamion, _pesoMaximo, _situadoCamion);

                pCamiones.Controls.Clear();
                FrmCamion modCamion = new FrmCamion(CreUpReDe.Update, oCamion);
                modCamion.TopLevel = false;
                modCamion.alCerrar += AlCerrar;
                pCamiones.Controls.Add(modCamion);
                modCamion.Show();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            bool loquevino = false;
            DialogResult dialogResult;
            if (dgvCamiones.Rows.Count > 0)
            {
                dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el Camion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    var result = await ClienteSingleton.GetInstance().DeleteAsync(rc.Baja + Convert.ToInt32(dgvCamiones.CurrentRow.Cells[0].Value));
                    loquevino = JsonConvert.DeserializeObject<bool>(result);
                }
                catch
                {
                    MessageBox.Show("Falló la conexión");
                }
                
                if (loquevino)
                    MessageBox.Show("El camion se eliminó con éxito");
                else
                    MessageBox.Show("El camion no se pudo eliminar");

                CargarGrilla();
            }
        }

        private async void CargarGrilla()
        {
            dgvCamiones.Rows.Clear();
            try
            {
                var result = await ClienteSingleton.GetInstance().GetAsync(rc.Todos);
                lCamiones = JsonConvert.DeserializeObject<List<Camion>>(result);
            }
            catch
            {
                MessageBox.Show("Falló la conexión");
            }

            foreach (Camion oCamion in lCamiones)
            {
                dgvCamiones.Rows.Add(new object[] {oCamion.Id, oCamion.Descripcion, oCamion.Patente,
                                     oCamion.IdCamionero, oCamion.Estado, oCamion.PesoMaximo, oCamion.Situado });
            }
        }

        private void AlCerrar(Object sender, EventArgs e)
        {
            pCamiones.Controls.Clear();
            pCamiones.Controls.Add(gbCamiones);
            CargarGrilla();
        }
    }
}
