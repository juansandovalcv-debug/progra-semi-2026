namespace cambio_de_divisas
{
    public partial class Form1 : Form
    {

        double[] valores = {1.0, 0.92, 0.78, 18.50, 940.0, 4050.0, 155.0, 7.25 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int de = cbOrigen.SelectedIndex;
                int a = cbConvertida.SelectedIndex;

                double cantidad = double.Parse(tbCantidad.Text);
                double respuesta = (cantidad / valores[de]) * valores[a];

                lblResultado.Text = respuesta.ToString("n2");
            }
            catch
            {
                lblResultado.Text = "La operacion no se pudo completar, utliliza caracteres numericos validos.";
            }
        }
    } 
}
