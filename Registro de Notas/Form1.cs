namespace Registro_de_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox30_TextChanged(sender, e);
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            double valor1, valor2, valor3, valor4;

            // Validando e convertendo as entradas
            bool valido1 = double.TryParse(textBox6.Text, out valor1);
            bool valido2 = double.TryParse(textBox150.Text, out valor2);
            bool valido3 = double.TryParse(textBox25.Text, out valor3);
            bool valido4 = double.TryParse(textBox20.Text, out valor4);



            // Calculando a média
            double media = (valor1 + valor2 + valor3 + valor4) / 4;

            // Exibindo o resultado no Label ou TextBox
            textBox30.Text = media.ToString();


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox29_TextChanged(sender, e);
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            textBox30_TextChanged(sender, e);
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            textBox30_TextChanged(sender, e);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox30_TextChanged(sender, e);
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            double valor1, valor2, valor3, valor4;

            // Validando e convertendo as entradas
            bool valido1 = double.TryParse(textBox7.Text, out valor1);
            bool valido2 = double.TryParse(textBox14.Text, out valor2);
            bool valido3 = double.TryParse(textBox24.Text, out valor3);
            bool valido4 = double.TryParse(textBox19.Text, out valor4);



            // Calculando a média
            double media = (valor1 + valor2 + valor3 + valor4) / 4;

            // Exibindo o resultado no Label ou TextBox
            textBox29.Text = media.ToString();

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            textBox29_TextChanged(sender, e);
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            textBox29_TextChanged(sender, e);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox29_TextChanged(sender, e);

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            double valor1, valor2, valor3, valor4;

            // Validando e convertendo as entradas
            bool valido1 = double.TryParse(textBox9.Text, out valor1);
            bool valido2 = double.TryParse(textBox13.Text, out valor2);
            bool valido3 = double.TryParse(textBox23.Text, out valor3);
            bool valido4 = double.TryParse(textBox18.Text, out valor4);



            // Calculando a média
            double media = (valor1 + valor2 + valor3 + valor4) / 4;

            // Exibindo o resultado no Label ou TextBox
            textBox28.Text = media.ToString();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            textBox28_TextChanged(sender, e);
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            textBox28_TextChanged(sender, e);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox28_TextChanged(sender, e);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox28_TextChanged(sender, e);
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            double valor1, valor2, valor3, valor4;

            // Validando e convertendo as entradas
            bool valido1 = double.TryParse(textBox8.Text, out valor1);
            bool valido2 = double.TryParse(textBox12.Text, out valor2);
            bool valido3 = double.TryParse(textBox22.Text, out valor3);
            bool valido4 = double.TryParse(textBox17.Text, out valor4);



            // Calculando a média
            double media = (valor1 + valor2 + valor3 + valor4) / 4;

            // Exibindo o resultado no Label ou TextBox
            textBox27.Text = media.ToString();

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            textBox27_TextChanged(sender, e);
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            textBox27_TextChanged(sender, e);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox27_TextChanged(sender, e);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox27_TextChanged(sender, e);
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            double valor1, valor2, valor3, valor4;

            // Validando e convertendo as entradas
            bool valido1 = double.TryParse(textBox10.Text, out valor1);
            bool valido2 = double.TryParse(textBox11.Text, out valor2);
            bool valido3 = double.TryParse(textBox21.Text, out valor3);
            bool valido4 = double.TryParse(textBox16.Text, out valor4);



            // Calculando a média
            double media = (valor1 + valor2 + valor3 + valor4) / 4;

            // Exibindo o resultado no Label ou TextBox
            textBox26.Text = media.ToString();

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            textBox26_TextChanged(sender, e);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            textBox26_TextChanged(sender, e);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox26_TextChanged(sender, e);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox26_TextChanged(sender, e);
        }

        private void textBox15_TextChanged_1(object sender, EventArgs e)
        {
            double valor1, valor2, valor3, valor4, valor5;

            // Validando e convertendo as entradas
            bool valido1 = double.TryParse(textBox30.Text, out valor1);
            bool valido2 = double.TryParse(textBox29.Text, out valor2);
            bool valido3 = double.TryParse(textBox28.Text, out valor3);
            bool valido4 = double.TryParse(textBox27.Text, out valor4);
            bool valido5 = double.TryParse(textBox26.Text, out valor5);



            // Calculando a média
            double media = (valor1 + valor2 + valor3 + valor4 + valor5) / 4;

            // Exibindo o resultado no Label ou TextBox
            textBox15.Text = media.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox37.Text + ", Série: " + textBox38.Text + ", Instituição: " + textBox40.Text + ", Sua média geral foi " + textBox15.Text);
        }
    }
}
