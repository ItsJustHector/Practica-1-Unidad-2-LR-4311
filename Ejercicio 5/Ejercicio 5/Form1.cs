namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Has seleccionado la opci�n 1.";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Has seleccionado la opci�n 2.";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Has seleccionado la opci�n 3.";
            }
            else
            {
                label1.Text = "No has seleccionado ninguna opci�n.";
            }
        }
    }
}
