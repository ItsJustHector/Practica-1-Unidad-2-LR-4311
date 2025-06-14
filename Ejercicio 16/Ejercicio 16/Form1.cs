namespace Ejercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //calculadora basica con todas las operaciones basicas

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado = 0;
            string operacion = cmbOperacion.SelectedItem?.ToString();

            if (!double.TryParse(txtNumero1.Text, out numero1) || !double.TryParse(txtNumero2.Text, out numero2))
            {
                lblResultado.Text = "Ingrese números válidos.";
                return;
            }

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 == 0)
                    {
                        lblResultado.Text = "No se puede dividir por cero.";
                        return;
                    }
                    resultado = numero1 / numero2;
                    break;
                default:
                    lblResultado.Text = "Seleccione una operación.";
                    return;
            }

            lblResultado.Text = $"Resultado: {resultado}";
        }
    }
}
