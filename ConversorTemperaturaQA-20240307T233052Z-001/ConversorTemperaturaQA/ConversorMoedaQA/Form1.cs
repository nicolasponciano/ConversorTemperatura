namespace ConversorMoedaQA
{

    public partial class Form1 : Form
    {
        Temperatura novaTemperatura = new Temperatura();
        public Form1()
        {
            InitializeComponent();
       
        }

        

        private void btnConverter_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarRadioButtons();
        }
        private void InicializarRadioButtons()
        {
            rbCelsius.Checked = true; // Defina Celsius como padrão

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica qual escala de temperatura está selecionada
            if (rbCelsius.Checked)
            {
                double temperaturaCelsius = Convert.ToDouble(txtValor.Text);
                double temperaturaFahrenheit = Celsius(temperaturaCelsius);
                txtConvertido.Text = $"{temperaturaCelsius} °C = {temperaturaFahrenheit} °F";
            }
            else if (rbFahrenheit.Checked)
            {
                double temperaturaFahrenheit = Convert.ToDouble(txtValor.Text);
                double temperaturaCelsius = Fahrenheit(temperaturaFahrenheit);
                txtConvertido.Text = $"{temperaturaFahrenheit} °F = {temperaturaCelsius} °C";
            }
            else if (rbKelvin.Checked)
            {
                double temperaturaCelsius = Convert.ToDouble(txtValor.Text);
                double temperaturaKelvin = Kelvin(temperaturaCelsius);
                txtConvertido.Text = $"{temperaturaCelsius} °C = {temperaturaKelvin} K";
            }

            TemperaturaBLL.ValidarDados(novaTemperatura);

            if (Erro.TemErro)
            {
                MessageBox.Show(Erro.Mensagem);
            }

            else
            {
                /*                txtConvertido.Text = novaTemperatura.converteCelsius();
                                txtConvertido.Text = novaTemperatura.converteFahrenheit();
                                txtConvertido.Text = novaTemperatura.converteKelvin();*/
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtConvertido.Clear();
        }
    }
}

