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
    public partial class Velocidade : Form
    {
        public Velocidade()
        {
            InitializeComponent();
        }

        //variavel para conversões
        double resultado;

        //button1 com o valor "1"
        private void button1_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "1";
            }
            else
            {
                labelNumero.Text += "1";
            }
        }
        //button2 com o valor "2"
        private void button2_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "2";
            }
            else
            {
                labelNumero.Text += "2";
            }
        }
        //button3 com o valor "3"
        private void button3_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "3";
            }
            else
            {
                labelNumero.Text += "3";
            }
        }
        //button4 com o valor "4"
        private void button4_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "4";
            }
            else
            {
                labelNumero.Text += "4";
            }
        }
        //button5 com o valor "5"
        private void button5_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "5";
            }
            else
            {
                labelNumero.Text += "5";
            }
        }
        //button6 com o valor "6"
        private void button6_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "6";
            }
            else
            {
                labelNumero.Text += "6";
            }
        }
        //button7 com o valor "7"
        private void button7_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "7";
            }
            else
            {
                labelNumero.Text += "7";
            }
        }
        //button8 com o valor "8"
        private void button8_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "8";
            }
            else
            {
                labelNumero.Text += "8";
            }
        }
        //button9 com o valor "9"
        private void button9_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "9";
            }
            else
            {
                labelNumero.Text += "9";
            }
        }
        //button0 com o valor "0"
        private void button0_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += "0";
            }
            else
            {
                labelNumero.Text += "0";
            }
        }
        //buttonVirgula com o valor ","
        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text == "0")
            {
                labelNumero.Text = string.Empty;
                labelNumero.Text += ",";
            }
            else
            {
                labelNumero.Text += ",";
            }
        }

        /// <summary>
        /// No caso de carregar no botão clear "C", irá lipar os seguintes labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelNumero.Text = "0";
            labelVelocidade.Text = "0";
        }

        /// <summary>
        /// botão para apagar número a número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (labelNumero.Text.Length > 1)
            {
                labelNumero.Text = labelNumero.Text.Substring(0, labelNumero.Text.Length - 1);
            }
            else
            {
                labelNumero.Text = string.Empty;
            }
        }

        /// <summary>
        /// Ao carregar no botão converter irá fazer as seguintes conversões
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConverter_Click(object sender, EventArgs e)
        {
            //converter de m/s para Km/h
            if ((comboBox1.SelectedItem.ToString() == "Metros por segundo") && comboBox2.SelectedItem.ToString() == "Quilómetros por hora")
            {
                labelVelocidade.Text = string.Empty;
                resultado = Convert.ToDouble(labelNumero.Text) * 3.600000;
                labelVelocidade.Text += resultado;
            }
            //converter de m/s para m/h
            else if ((comboBox1.SelectedItem.ToString() == "Metros por segundo") && comboBox2.SelectedItem.ToString() == "Milhas por hora")
            {
                labelVelocidade.Text = string.Empty;
                resultado = Convert.ToDouble(labelNumero.Text) / 2.236936;
                labelVelocidade.Text += resultado;
            }
            //converter de km/s para m/s
            else if ((comboBox1.SelectedItem.ToString() == "Quilómetros por hora") && comboBox2.SelectedItem.ToString() == "Metros por segundo")
            {
                labelVelocidade.Text = string.Empty;
                resultado = Convert.ToDouble(labelNumero.Text) / 3.600000;
                labelVelocidade.Text += resultado;
            }
            //converter de km/s para m/h
            else if ((comboBox1.SelectedItem.ToString() == "Quilómetros por hora") && comboBox2.SelectedItem.ToString() == "Milhas por hora")
            {
                labelVelocidade.Text = string.Empty;
                resultado = Convert.ToDouble(labelNumero.Text) * 1.609344;
                labelVelocidade.Text += resultado;
            }
            //converter de m/h para m/s
            else if ((comboBox1.SelectedItem.ToString() == "Milhas por hora") && comboBox2.SelectedItem.ToString() == "Metros por segundo")
            {
                labelVelocidade.Text = string.Empty;
                resultado = Convert.ToDouble(labelNumero.Text) * 2.236936;
                labelVelocidade.Text += resultado;
            }
            //converter de m/h para km/h
            else if ((comboBox1.SelectedItem.ToString() == "Milhas por hora") && comboBox2.SelectedItem.ToString() == "Quilómetros por hora")
            {
                labelVelocidade.Text = string.Empty;
                resultado = Convert.ToDouble(labelNumero.Text) * 1.609344;
                labelVelocidade.Text += resultado;
            }
        }
    }
}
