using Microsoft.Maui.Controls;
using System;

namespace Convert
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private double ConverterDistancia(double valor, string unidadeDe, string unidadePara)
        {
            if (unidadeDe == "Metros")
            {
                if (unidadePara == "Quilômetros") return valor / 1000;
                if (unidadePara == "Milhas") return valor * 0.000621371;
                return valor;
            }
            if (unidadeDe == "Quilômetros")
            {
                if (unidadePara == "Metros") return valor * 1000;
                if (unidadePara == "Milhas") return valor * 0.621371;
                return valor;
            }
            if (unidadeDe == "Milhas")
            {
                if (unidadePara == "Metros") return valor / 0.000621371;
                if (unidadePara == "Quilômetros") return valor / 0.621371;
                return valor;
            }

            return 0;
        }

        private double ConverterPeso(double valor, string unidadeDe, string unidadePara)
        {
            if (unidadeDe == "Gramas")
            {
                if (unidadePara == "Quilogramas") return valor / 1000;
                if (unidadePara == "Libras") return valor * 0.00220462;
                return valor;
            }
            if (unidadeDe == "Quilogramas")
            {
                if (unidadePara == "Gramas") return valor * 1000;
                if (unidadePara == "Libras") return valor * 2.20462;
                return valor;
            }
            if (unidadeDe == "Libras")
            {
                if (unidadePara == "Gramas") return valor / 0.00220462;
                if (unidadePara == "Quilogramas") return valor / 2.20462;
                return valor;
            }

            return 0;
        }

        private double ConverterTemperatura(double valor, string unidadeDe, string unidadePara)
        {
            if (unidadeDe == "Celsius")
            {
                if (unidadePara == "Fahrenheit") return valor * 9 / 5 + 32;
                if (unidadePara == "Kelvin") return valor + 273.15;
                return valor;
            }
            if (unidadeDe == "Fahrenheit")
            {
                if (unidadePara == "Celsius") return (valor - 32) * 5 / 9;
                if (unidadePara == "Kelvin") return (valor - 32) * 5 / 9 + 273.15;
                return valor;
            }
            if (unidadeDe == "Kelvin")
            {
                if (unidadePara == "Celsius") return valor - 273.15;
                if (unidadePara == "Fahrenheit") return (valor - 273.15) * 9 / 5 + 32;
                return valor;
            }

            return 0;
        }

        private void AoConverterDistancia(object sender, EventArgs e)
        {
            if (double.TryParse(entradaDistancia.Text, out double valor))
            {
                string unidadeDe = seletorDistanciaDe.SelectedItem?.ToString() ?? "Metros";
                string unidadePara = seletorDistanciaPara.SelectedItem?.ToString() ?? "Metros";
                double resultado = ConverterDistancia(valor, unidadeDe, unidadePara);
                resultadoDistanciaLabel.Text = $"Resultado: {resultado} {unidadePara}";
            }
            else
            {
                resultadoDistanciaLabel.Text = "Por favor, insira um valor numérico válido.";
            }
        }

        private void AoConverterPeso(object sender, EventArgs e)
        {
            if (double.TryParse(entradaPeso.Text, out double valor))
            {
                string unidadeDe = seletorPesoDe.SelectedItem?.ToString() ?? "Gramas";
                string unidadePara = seletorPesoPara.SelectedItem?.ToString() ?? "Gramas";
                double resultado = ConverterPeso(valor, unidadeDe, unidadePara);
                resultadoPesoLabel.Text = $"Resultado: {resultado} {unidadePara}";
            }
            else
            {
                resultadoPesoLabel.Text = "Por favor, insira um valor numérico válido.";
            }
        }

        private void AoConverterTemperatura(object sender, EventArgs e)
        {
            if (double.TryParse(entradaTemperatura.Text, out double valor))
            {
                string unidadeDe = seletorTemperaturaDe.SelectedItem?.ToString() ?? "Celsius";
                string unidadePara = seletorTemperaturaPara.SelectedItem?.ToString() ?? "Celsius";
                double resultado = ConverterTemperatura(valor, unidadeDe, unidadePara);
                resultadoTemperaturaLabel.Text = $"Resultado: {resultado} {unidadePara}";
            }
            else
            {
                resultadoTemperaturaLabel.Text = "Por favor, insira um valor numérico válido.";
            }
        }
    }
}
