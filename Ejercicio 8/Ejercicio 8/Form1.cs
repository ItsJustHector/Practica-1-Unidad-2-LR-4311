namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        private int contador;

        public Form1()
        {
            InitializeComponent();
            int contador = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = this.contador++;
            label1.Text = "Contador: " + this.contador.ToString();
        }
    }
}
