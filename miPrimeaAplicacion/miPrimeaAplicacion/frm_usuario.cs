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
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
        }

        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        String accion = "nuevo";
        int posicion = 0;

       
        private void frm_usuario_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void obtenerDatos()
        {
            ds.Clear();
            ds = objConexion.crearDs();
            dt = ds.Tables["usuarios_usss009925"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idUsuario"] };

            grdDatosUsuarios.DataSource = dt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (dt.Rows.Count > 0)
            {
                txtIdUsuario.Text = dt.Rows[posicion]["idUsuario"].ToString();
                txtUsuario.Text = dt.Rows[posicion]["usuario"].ToString();
                txtClave.Text = dt.Rows[posicion]["clave"].ToString();
                txtConfirmarClave.Text = dt.Rows[posicion]["clave"].ToString();
                txtNombre.Text = dt.Rows[posicion]["nombre"].ToString();
                txtDireccion.Text = dt.Rows[posicion]["direccion"].ToString();
                txtTelefono.Text = dt.Rows[posicion]["telefono"].ToString();

                lblRegistros.Text = (posicion + 1) + " de " + dt.Rows.Count;
            }
        }

        private void limpiarControles()
        {
            txtIdUsuario.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void activarDesactivarCtrls(Boolean estado)
        {
            grbDatos.Enabled = estado;
            grbNavegacion.Enabled = !estado;
            btnEliminar.Enabled = !estado;
            txtBuscarUsuarios.Enabled = !estado;
        }

        private bool validarDatos()
        {
            if (txtUsuario.Text.Length < 6 || txtUsuario.Text.Length > 16)
            {
                MessageBox.Show("El nombre de usuario debe tener entre 6 y 16 caracteres.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (txtClave.Text != txtConfirmarClave.Text)
            {
                MessageBox.Show("La contraseña y la confirmación no coinciden.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarClave.Focus();
                return false;
            }

            bool tieneLetra = false;
            bool tieneNumero = false;
            foreach (char c in txtClave.Text)
            {
                if (char.IsLetter(c)) tieneLetra = true;
                if (char.IsNumber(c)) tieneNumero = true;
            }
            if (!tieneLetra || !tieneNumero)
            {
                MessageBox.Show("La contraseña debe contener al menos una letra y un número.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Agregar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";

                accion = "nuevo";
                limpiarControles();
                activarDesactivarCtrls(true);
            }
            else 
            {
                if (!validarDatos()) return;

                String[] usuarios = {
                    txtIdUsuario.Text, txtUsuario.Text, txtClave.Text,
                    txtNombre.Text, txtDireccion.Text, txtTelefono.Text
                };
                String respuesta = objConexion.mantenimiento_usuarios_usss009925(usuarios, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar usuario.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    activarDesactivarCtrls(false);
                    btnAgregar.Text = "Agregar";
                    btnModificar.Text = "Modificar";
                    obtenerDatos();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                activarDesactivarCtrls(true);
                accion = "modificar";
            }
            else // Cancelar
            {
                mostrarDatos();
                activarDesactivarCtrls(false);
                btnAgregar.Text = "Agregar";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar al usuario " + txtNombre.Text + "?",
                "Eliminando usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.mantenimiento_usuarios_usss009925(
                    new String[] { txtIdUsuario.Text, "", "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar usuario.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    obtenerDatos();
                }
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estás en el primer registro.", "Navegación de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estás en el último registro.", "Navegación de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            posicion = dt.Rows.Count - 1;
            mostrarDatos();
        }

        private void txtBuscarUsuarios_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarUsuarios.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtrarDatos(String valor)
        {
            try
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "usuario like '%" + valor + "%' or nombre like '%" + valor + "%'";
                grdDatosUsuarios.DataSource = dv;
                seleccionarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seleccionarUsuario()
        {
            try
            {
                if (grdDatosUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas que mostrar");
                    return;
                }
                String id = grdDatosUsuarios.CurrentRow.Cells["colIdUsuario"].Value.ToString();
                posicion = dt.Rows.IndexOf(dt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
