using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using LibProyectoPII;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;

namespace FormsProyectoPII
{
    public partial class FrmLogin : Form
    {
        private RutasUsuario ru = new RutasUsuario();

        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
          
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            lblUsuarioIncorrecto.TextAlign = ContentAlignment.TopCenter;
            lblUsuarioIncorrecto.Visible = false;
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            string pass = GetSHA256(txtPassword.Text);
            try
            {
                Logueo logueo = new Logueo(txtUsuario.Text, pass);
                string strLogueo = JsonConvert.SerializeObject(logueo);
                var result = await ClienteSingleton.GetInstance().PostAsync(ru.Logueo, strLogueo);
                string loquevino = JsonConvert.DeserializeObject<string>(result);

                //MessageBox.Show(loquevino);

                if (loquevino == "true" || (txtUsuario.Text == "" && txtPassword.Text == ""))
                {
                    this.Hide();
                }
                else
                {
                    lblUsuarioIncorrecto.Visible = true;
                    txtUsuario.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Falló la conexión");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
