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
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        double resultado;

        private void buttonCoverter_Click(object sender, EventArgs e)
        {
            //converter de celsius para kelvin
            if (radioButtonCelsius1.Checked && radioButtonKelvin2.Checked)
            {
                labelConversao.Text = string.Empty;
                resultado = Convert.ToDouble(textBoxTemperatura.Text) + 273.15;
                labelConversao.Text += resultado;
            }
            //converter de celsius para fahrenteit
            else if (radioButtonCelsius1.Checked && radioButtonFahrenheit2.Checked)
            {
                labelConversao.Text = string.Empty;
                resultado = Convert.ToDouble(textBoxTemperatura.Text) * 1.800 + 32;
                labelConversao.Text += resultado;
            }
            //converter de kelvin para celsius
            else if(radioButtonKelvin1.Checked && radioButtonCelsius2.Checked)
            {
                labelConversao.Text = string.Empty;
                resultado = Convert.ToDouble(textBoxTemperatura.Text) - 273.15;
                labelConversao.Text += resultado;
            }
            //converter de kelvin para fahrenteit
            else if (radioButtonKelvin1.Checked && radioButtonFahrenheit2.Checked)
            {
                labelConversao.Text = string.Empty;
                resultado = (Convert.ToDouble(textBoxTemperatura.Text) - 273.15) * 1.800 + 32;
                labelConversao.Text += resultado;
            }
            //converter de fahrenteit para kelvin
            else if (radioButtonFahrenheit1.Checked && radioButtonKelvin2.Checked)
            {
                labelConversao.Text = string.Empty;
                resultado = (Convert.ToDouble(textBoxTemperatura.Text) - 32) / 1.800 + 273.15;
                labelConversao.Text += resultado;
            }
            //converter de fahrenteit para celsius
            else if (radioButtonFahrenheit1.Checked && radioButtonCelsius2.Checked)
            {
                labelConversao.Text = string.Empty;
                resultado = (Convert.ToDouble(textBoxTemperatura.Text) - 32) / 1.800;
                labelConversao.Text += resultado;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTemperatura.Clear();
            labelConversao.Text = "0";
        }
    }
}
