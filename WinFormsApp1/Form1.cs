using System.Reflection.Emit;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         metros, cm, pulgadas, pies, varas, yardas, km, millas
        */
        double[] valores = { 1, 100, 39.3701, 3.28084, 1.1963, 1.09361, 0.001, 0.000621371 };
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int de = cboDe.SelectedIndex, a = cboA.SelectedIndex;
                double cantidad = double.Parse(tbCantidad.Text);

                double respuesta = valores[a] / valores[de] * cantidad;
                lblRespuesta.Text = respuesta.ToString("N2");
            }
            catch 
            {
                lblRespuesta.Text = "La operación falló, utiliza caracteres numéricos válidos";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
