using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibProyectoPII;
using Newtonsoft.Json;

namespace FormsProyectoPII
{
    public partial class FrmViajes : Form
    {
        private RutasCamion rc = new RutasCamion();
        private RutasViaje rv = new RutasViaje();
        private List<Viaje> lViajes = new List<Viaje>();

        public FrmViajes()
        {
            InitializeComponent();
        }

        private void frmViajes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            dgvViajes.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int primero = 0;
            //if (dgvViajes.Rows.Count == 0)
            //    primero = 1;
            pViajes.Controls.Clear();
            FrmViaje altaViaje = new FrmViaje(CreUpReDe.Create, primero);
            altaViaje.TopLevel = false;
            altaViaje.alCerrar += AlCerrar;
            pViajes.Controls.Add(altaViaje);
            altaViaje.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvViajes.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningún viaje para modificar");
            }
            else
            {
                int _id = Convert.ToInt32(dgvViajes.CurrentRow.Cells[0].Value);
                int _idCamion = Convert.ToInt32(dgvViajes.CurrentRow.Cells[1].Value);
                string _origen = Convert.ToString(dgvViajes.CurrentRow.Cells[2].Value);
                string _destino = Convert.ToString(dgvViajes.CurrentRow.Cells[3].Value);

                Viaje viaje = new Viaje(_id, _idCamion, _origen, _destino);

                pViajes.Controls.Clear();
                FrmViaje modViaje = new FrmViaje(viaje, CreUpReDe.Update);
                modViaje.TopLevel = false;
                modViaje.alCerrar += AlCerrar;
                pViajes.Controls.Add(modViaje);
                modViaje.Show();
            }
        }

        private void AlCerrar(Object sender, EventArgs e)
        {
            pViajes.Controls.Clear();
            pViajes.Controls.Add(gbViajes);
            CargarGrilla();
        }

        private async void CargarGrilla()
        {
            dgvViajes.Rows.Clear();
            try
            {
                var result = await ClienteSingleton.GetInstance().GetAsync(rv.Viajes);
                lViajes = JsonConvert.DeserializeObject<List<Viaje>>(result);
            }
            catch
            {
                MessageBox.Show("Falla de conexion");
            }

            foreach (Viaje viaje in lViajes)
            {
                dgvViajes.Rows.Add(new object[] { viaje.Id, viaje.IdCamion, viaje.Origen, viaje.Destino  });
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (dgvViajes.Rows.Count > 0)
            {
                dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el Viaje?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("No existe ningún viaje para eliminar");
                dialogResult = DialogResult.No;
            }

            if (dialogResult == DialogResult.Yes && dgvViajes.Rows.Count > 0)
            {
                try
                {
                    Viaje viaje = BuscarViaje();

                    var result = await ClienteSingleton.GetInstance().GetAsync(rc.CamionById + viaje.IdCamion.ToString());
                    Camion camion = JsonConvert.DeserializeObject<Camion>(result);

                    if (camion.Estado == Estados.Disponible)
                    {
                        viaje.FechaLlegada = DateTime.Today;

                        string strViaje = JsonConvert.SerializeObject(viaje);
                        var result2 = await ClienteSingleton.GetInstance().PutAsync(rv.Finalizar, strViaje);
                        string loquevino = JsonConvert.DeserializeObject<string>(result2);

                        if (loquevino == "true")
                            MessageBox.Show("El viaje se eliminó con éxito");
                        else
                            MessageBox.Show("El viaje no se pudo eliminar");

                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("El viaje no se puede eliminar, porque el camión está en ruta");
                    }
                }
                catch
                {
                    MessageBox.Show("Falló la conexión");
                }
            }
        }

        private Viaje BuscarViaje()
        {
            Viaje viaje = new Viaje();
            foreach (Viaje v in lViajes)
            {
                if (v.Id == Convert.ToInt32(dgvViajes.CurrentRow.Cells[0].Value))
                {
                    viaje = v;
                }
            }
            return viaje;
        }
    }
}
