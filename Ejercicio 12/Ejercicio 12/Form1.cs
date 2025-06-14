namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double celcius = double.Parse(textBox1.Text);
                double fahrenheit = (celcius * 9 / 5) + 32;
                label1.Text = $"{celcius} °C = {fahrenheit} °F";
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
           
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                MessageBox.Show("Solo se permiten Numeros", "Aviso");
                e.Handled = true;
                return;
            }
        }
    }
}
