using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion objConexion = new Conexion();
                DataSet ds = objConexion.crearDs();
                DataTable dt = ds.Tables["usuarios_usss009925"];

               
                bool encontrado = false;
                string nombreUsuario = "";

                foreach (DataRow fila in dt.Rows)
                {
                    if (fila["usuario"].ToString() == txtUsuario.Text &&
                        fila["clave"].ToString() == txtClave.Text)
                    {
                        encontrado = true;
                        nombreUsuario = fila["nombre"].ToString();
                        break;
                    }
                }

                if (encontrado)
                {  
                    MessageBox.Show("¡Bienvenido(a) " + nombreUsuario + "!",
                        "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    frmPrincipal objPrincipal = new frmPrincipal();
                    objPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Acceso denegado.",
                        "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Text = "";
                    txtClave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
