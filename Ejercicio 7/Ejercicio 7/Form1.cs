namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _ = listBox1.Items.Add("Blue Lock");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem?.ToString();
            label1.Text = selectedItem;
        }
    }
}
