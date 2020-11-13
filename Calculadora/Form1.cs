using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //variaveis
        string operador1 = string.Empty;
        string operador2 = string.Empty;
        double numero1, numero2, resultado;
        string operador;
        double pi = Math.PI;
        string copiar;

        /// <summary>
        /// botão soma, irá converter as variáveis para double e calcualr a subtração a partir do método Subtrair().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSoma_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            labelResultado.Text = string.Empty;
            operador = "+";
            labelHistorico.Text = operador1 + operador;
        }

        /// <summary>
        /// botão subtrair, irá converter as variáveis para double e calcualr a subtração a partir do método Subtrair().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubtrair_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            labelResultado.Text = string.Empty;
            operador = "-";
            labelHistorico.Text = operador1 + operador;
        }

        /// <summary>
        /// botão multiplicar, irá converter as variáveis para double e calcualr a multiplicação a partir do método Multiplicar().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            labelResultado.Text = string.Empty;
            operador = "x";
            labelHistorico.Text = operador1 + operador;
        }

        /// <summary>
        /// botão dividir, irá converter as variáveis para double e calcualr a divisão a partir do método Divisao().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            labelResultado.Text = string.Empty;
            operador = "÷";
            labelHistorico.Text = operador1 + operador;
        }

        /// <summary>
        /// No caso de carregar no botão clear "C", irá lipar os seguintes labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "0";
            labelHistorico.Text = "";
        }

        //button1 com o valor "1"
        private void button1_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "1";
            }
            else
            {
                labelResultado.Text += "1";
            }
        }
        //button2 com o valor "2"
        private void button2_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "2";
            }
            else
            {
                labelResultado.Text += "2";
            }
        }
        //button3 com o valor "3"
        private void button3_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "3";
            }
            else
            {
                labelResultado.Text += "3";
            }
        }
        //button4 com o valor "4"
        private void button4_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "4";
            }
            else
            {
                labelResultado.Text += "4";
            }
        }
        //button5 com o valor "5"
        private void button5_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "5";
            }
            else
            {
                labelResultado.Text += "5";
            }
        }
        //button6 com o valor "6"
        private void button6_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "6";
            }
            else
            {
                labelResultado.Text += "6";
            }
        }
        //button7 com o valor "7"
        private void button7_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "7";
            }
            else
            {
                labelResultado.Text += "7";
            }
        }
        //button8 com o valor "8"
        private void button8_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "8";
            }
            else
            {
                labelResultado.Text += "8";
            }
        }
        //button9 com o valor "9"
        private void button9_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "9";
            }
            else
            {
                labelResultado.Text += "9";
            }
        }
        //button0 com o valor "0"
        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = string.Empty;
                labelResultado.Text += "0";
            }
            else
            {
                labelResultado.Text += "0";
            }
        }
        //buttonVirgula com o valor ","
        private void buttonVirgula_Click(object sender, EventArgs e)
        {          
            labelResultado.Text += ",";
        }

        /// <summary>
        /// buttonPi, botão para aparecer o valor do Pi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPi_Click_1(object sender, EventArgs e)
        {
            labelResultado.Text = string.Empty;
            operador1 = Convert.ToString(pi);
            labelResultado.Text += operador1;
            labelHistorico.Text += Convert.ToString(pi);
        }

        /// <summary>
        /// buttonRaiz, botão para fazer a raiz quadrada de um número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRaiz_Click(object sender, EventArgs e)
        {          
            operador1 = labelResultado.Text;
            if (labelResultado.Text == "")
            {
                labelResultado.Text = "ERROR";
            }
            else
            {
                double raizQuadrada = Math.Sqrt(Convert.ToDouble(operador1));
                labelResultado.Text = "";
                labelResultado.Text = Convert.ToString(raizQuadrada);
                labelHistorico.Text = $"√{operador1}";
            }
        }

        /// <summary>
        /// buttonElevar, botão para calcular o quadrado de um numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonElevar2_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            if (labelResultado.Text == "")
            {
                labelResultado.Text = "ERROR";
            }
            else
            {
                double elevar = Math.Pow(Convert.ToDouble(operador1), 2);
                labelResultado.Text = Convert.ToString(elevar);
                labelHistorico.Text = $"{operador1}^2";
            }
        }

        /// <summary>
        /// buttonSeno, botão para calcular o seno de um número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeno_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            if (labelResultado.Text == "")
            {
                labelResultado.Text = "ERROR";
            }
            //calcular o seno
            else
            {
                double seno = Math.Sin(Convert.ToDouble(operador1) * (Math.PI / 180f));
                labelResultado.Text = Convert.ToString(seno);
                labelHistorico.Text += $"sin({operador1})";
            }
        }

        /// <summary>
        /// buttonCosseno, botão para calcular o cosseno de um número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCosseno_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            if (labelResultado.Text == "")
            {
                labelResultado.Text = "ERROR";
            }
            //calcular o cosseno
            else
            {
                double cosseno = Math.Cos(Convert.ToDouble(operador1) * (Math.PI / 180f));
                labelResultado.Text = Convert.ToString(cosseno);
                labelHistorico.Text += $"cos({operador1})";
            }
        }

        /// <summary>
        /// buttonTangente, botão para calcular a tangente de um número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTangente_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            if (labelResultado.Text == "")
            {
                labelResultado.Text = "ERROR";
            }
            //calcular a tangente
            else
            {
                double tangente = Math.Tan(Convert.ToDouble(operador1) * (Math.PI / 180f));
                labelResultado.Text = Convert.ToString(tangente);
                labelHistorico.Text += $"tan({operador1})";
            }
        }

        /// <summary>
        /// buttonSeno, botão para calcular a seno - 1 de um número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSenoMenosUm_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            if (labelResultado.Text == "")
            {
                labelResultado.Text = "ERROR";
            }
            //calcular o seno-1
            else
            {
                double seno = Math.Asin(Convert.ToDouble(operador1) * (Math.PI / 180f));
                labelResultado.Text = Convert.ToString(seno);
                labelHistorico.Text += $"sin-1({operador1})";
            }
        }

        /// <summary>
        /// buttonCosseno, botão para calcular a cosseno - 1 de um número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCossenoMenosUm_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            if (labelResultado.Text == "")
            {
                labelResultado.Text = "ERROR";
            }
            //calcular o cosseno-1
            else
            {
                double cosseno = Math.Acos(Convert.ToDouble(operador1) * (Math.PI / 180f));
                labelResultado.Text = Convert.ToString(cosseno);
                labelHistorico.Text += $"cos-1({operador1})";
            }
        }

        /// <summary>
        /// buttonTangente, botão para calcular a tangente - 1 de um número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTangenteMenosUm_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            if (labelResultado.Text == "")
            {
                labelResultado.Text = "ERROR";
            }
            //calcular o tangente-1
            else
            {
                double cosseno = Math.Atan(Convert.ToDouble(operador1) * (Math.PI / 180f));
                labelResultado.Text = Convert.ToString(cosseno);
                labelHistorico.Text += $"tan-1({operador1})";
            }
        }

        /// <summary>
        /// Menu para copiar e colar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Copiar o número
            if (labelResultado.Text != string.Empty)
            {
                copiar = labelResultado.Text;
            }
            else
            {
                copiar = string.Empty;
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Colar o número
            if (copiar != string.Empty)
            {
                labelResultado.Text = copiar;
            }
            else
            {
                copiar = string.Empty;
                labelResultado.Text = "0";
            }
        }

        /// <summary>
        /// botão para apagar número a número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text.Length > 1)
            {
                labelResultado.Text = labelResultado.Text.Substring(0, labelResultado.Text.Length - 1);
            }
            else
            {
                labelResultado.Text = string.Empty;
            }
        }

        /// <summary>
        /// Ao carregar no botão igual irá fazer as seguintes operações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            operador2 = labelResultado.Text;
            labelHistorico.Text = operador1 + operador + operador2 + " =";;

            //Se o labelResultado tiver o seguinte código irá fazer as contas 
            if (labelResultado.Text != operador1 + operador + operador2)
            {
               //Contas 
               switch (operador)
               {
                    //operação soma
                    case "+":
                        //Se receber o operador1 em string, retorna o numero1 em double
                        if (Double.TryParse(operador1, out numero1) == true)
                        {
                            //Se receber o operador2 em string, retorna o numero2 em double
                            if (Double.TryParse(operador2, out numero2) == true)
                            {
                                resultado = numero1 + numero2;
                                labelResultado.Text = resultado.ToString();
                            }
                            //Se não da erro, exemplo: 1 + =
                            else
                            {
                                labelResultado.Text = "ERROR";
                            }
                        }
                        //Se não da erro, exemplo: + =
                        else
                        {
                            labelResultado.Text = "ERROR";
                        }
                        break;
                   //operação multiplicação
                   case "x":
                        //Se receber o operador1 em string, retorna o numero1 em double
                        if (Double.TryParse(operador1, out numero1) == true)
                        {
                            //Se receber o operador2 em string, retorna o numero2 em double
                            if (Double.TryParse(operador2, out numero2) == true)
                            {
                                resultado = numero1 * numero2;
                                labelResultado.Text = resultado.ToString();
                            }
                            //Se não da erro, exemplo: 1 * =
                            else
                            {
                                labelResultado.Text = "ERROR";
                            }
                        }
                        //Se não da erro, exemplo: * =
                        else
                        {
                            labelResultado.Text = "ERROR";
                        }
                        break;
                   //operação divisão
                   case "÷":
                       //Se o numero2 for diferente de 0 irá fazer a conta
                       if (operador2 != "0")
                       {
                            //Se receber o operador1 em string, retorna o numero1 em double
                            if (Double.TryParse(operador1, out numero1) == true)
                            {
                                //Se receber o operador2 em string, retorna o numero2 em double
                                if (Double.TryParse(operador2, out numero2) == true)
                                {
                                    resultado = numero1 / numero2;
                                    labelResultado.Text = resultado.ToString();
                                }
                                //Se não da erro, exemplo: 1 / =
                                else
                                {
                                    labelResultado.Text = "ERROR";
                                }
                            }
                            //Se não da erro, exemplo: / =
                            else
                            {
                                labelResultado.Text = "ERROR";
                            }
                        }
                       //se não irá dar erro
                       else
                       {
                           labelResultado.Text = "ERROR";
                       }
                       break;
                   //operação subtração
                   case "-":
                        //Se receber o operador1 em string, retorna o numero1 em double
                        if (Double.TryParse(operador1, out numero1) == true)
                        {
                            //Se receber o operador2 em string, retorna o numero2 em double
                            if (Double.TryParse(operador2, out numero2) == true)
                            {
                                resultado = numero1 - numero2;
                                labelResultado.Text = resultado.ToString();
                            }
                            //Se não da erro, exemplo: 1 - =
                            else
                            {
                                labelResultado.Text = "ERROR";
                            }
                        }
                        //Se não da erro, exemplo: - =
                        else
                        {
                            labelResultado.Text = "ERROR";
                        }
                        break;
               }
            }
            //Se não estiver nada escrito no labelResultado
            else
            {
                labelResultado.Text += "ERROR";
            }
        }

        /// <summary>
        /// Form Temperatura, para converter temperaturas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicializei a vriavel temperatura do tipo Temperatura e chamei a form Conversor Temperatura
            Temperatura temperatura = new Temperatura();
            temperatura.Show();
        }

        /// <summary>
        /// buttonPercentagem, para calcular a percentagem de um número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPercentagem_Click(object sender, EventArgs e)
        {
            operador1 = labelResultado.Text;
            if (labelResultado.Text == "")
            {
                labelResultado.Text = "ERROR";
            }
            else
            {
                double percentagem = Convert.ToDouble(operador1) / 100;
                labelResultado.Text = "";
                labelResultado.Text = Convert.ToString(percentagem);
                labelHistorico.Text = $"{operador1}%";
            }
        }

        /// <summary>
        /// Form Velocidade, para velocidades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void velocidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicializei a vriavel velocidade do tipo Velocidade e chamei a form velocidade
            Velocidade velocidade = new Velocidade();
            velocidade.Show();
        }

        /// <summary>
        /// Form Ajuda, para ajudas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicializei a vriavel ajuda do tipo Ajuda e chamei a form ajuda
            Acerca acerca = new Acerca();
            acerca.Show();
        }
    }
}
