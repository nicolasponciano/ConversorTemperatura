namespace ConversorMoedaQA
{

    public partial class Form1 : Form
    {
        Temperatura novaTemperatura = new Temperatura();
        public Form1()
        {
            InitializeComponent();
            InicializarRadioButtons();
        }

        private void InicializarRadioButtons()
        {
            rbCelsius.Checked = true; // Defina Celsius como padrão

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (rbCelsius.Checked)
            {
                txtConvertido.Text = novaTemperatura.converteCelsius();
            }
            else if (rbFahrenheit.Checked)
            {
                txtConvertido.Text = novaTemperatura.converteFahrenheit();
            }
            else if (rbKelvin.Checked)
            {
                txtConvertido.Text = novaTemperatura.converteKelvin();
                
            }

            TemperaturaBLL.ValidarDados(novaTemperatura);

            if (Erro.TemErro)
            {
                MessageBox.Show(Erro.Mensagem);
            }

            else
            {
                txtConvertido.Text = novaTemperatura.converteCelsius();
                txtConvertido.Text = novaTemperatura.converteFahrenheit();
                txtConvertido.Text = novaTemperatura.converteKelvin();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtConvertido.Clear();

        }
    }
}

