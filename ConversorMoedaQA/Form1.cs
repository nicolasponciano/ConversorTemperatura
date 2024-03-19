using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ConversorMoedaQA
{
    public partial class Form1 : Form
    {
        private bool temaEscuro = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (!rbCelsius.Checked && !rbFahrenheit.Checked && !rbKelvin.Checked)
            {
                MessageBox.Show("Selecione uma opção de conversão.", "Erro");
                return;
            }
            if (double.TryParse(txtValor.Text, out double celsius))
            {
                Temperatura temperatura = new Temperatura { Valor = celsius };
                TemperaturaBLL.ValidarDados(temperatura);

                if (!Erro.TemErro)
                {
                    double resultado = 0;
                    string unidade = "";

                    if (rbCelsius.Checked)
                    {
                        resultado = temperatura.Valor;
                        unidade = "Celsius";
                    }
                    else if (rbFahrenheit.Checked)
                    {
                        resultado = temperatura.ConverterParaFahrenheit();
                        unidade = "Fahrenheit";
                    }
                    else if (rbKelvin.Checked)
                    {
                        resultado = temperatura.ConverterParaKelvin();
                        unidade = "Kelvin";
                    }

                    ExibirResultado(resultado, unidade);
                }
                else
                {
                    MessageBox.Show(Erro.Mensagem, "Erro");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor de temperatura válido em Celsius.", "Erro");
            }
        }

        private void ExibirResultado(double resultado, string unidade)
        {
            txtConvertido.Text = $"{resultado} {unidade}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtConvertido.Clear();
        }

        private void btnAlterarTema_Click(object sender, EventArgs e)
        {
            AlterarTema();
            DefinirEstilo();
        }

        private void AlterarTema()
        {
            temaEscuro = !temaEscuro;
        }

        private void DefinirEstilo()
        {
            if (temaEscuro)
            {
                // Estilo para o tema escuro
                this.BackColor = Color.FromArgb(31, 31, 31);
                this.ForeColor = Color.White;
                txtValor.BackColor = Color.FromArgb(45, 45, 48);
                txtValor.ForeColor = Color.White;
                txtConvertido.BackColor = Color.FromArgb(45, 45, 48);
                txtConvertido.ForeColor = Color.White;
                btnConverter.BackColor = Color.FromArgb(0, 122, 204);
                btnConverter.ForeColor = Color.White;
                btnAlterarTema.BackColor = Color.FromArgb(0, 122, 204);
                btnAlterarTema.ForeColor = Color.White;
                btnLimpar.BackColor = Color.FromArgb(0, 122, 204);
                btnLimpar.ForeColor = Color.White;
                label3.BackColor = Color.FromArgb(31, 31, 31);
                label3.ForeColor = Color.White;
            }
            else
            {
                // Estilo para o tema claro
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;
                txtValor.BackColor = SystemColors.Window;
                txtValor.ForeColor = SystemColors.WindowText;
                txtConvertido.BackColor = SystemColors.Window;
                txtConvertido.ForeColor = SystemColors.WindowText;
                btnConverter.BackColor = SystemColors.Control;
                btnConverter.ForeColor = SystemColors.ControlText;
                btnAlterarTema.BackColor = SystemColors.Control;
                btnAlterarTema.ForeColor = SystemColors.ControlText;
                btnLimpar.BackColor = SystemColors.Control;
                btnLimpar.ForeColor = SystemColors.ControlText;
                label3.BackColor = SystemColors.Control;
                label3.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
