namespace PRACTICA_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(textBox1.Text);

            if (edad < 12.0) MessageBox.Show(" Niño ");

            else
                if (edad < 18.0) MessageBox.Show(" Adolescente ");

            else
                 if (edad < 60.0) MessageBox.Show(" Adulto ");

            else
                 if (edad > 60.0) MessageBox.Show(" Adulto mayor ");
        }

    }
}