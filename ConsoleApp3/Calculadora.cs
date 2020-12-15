using System;
using System.Globalization;

namespace Projeto
{
    public class Calculadora
    {
        private double Valor1 { get; set; }
        private double Valor2 { get; set; }
        private string Operador { get; set; }
        private double Resultado { get; set; }
        private string DadosDigitadosOperacao { get; set; }
        public bool Error { get; set; }


        public Calculadora(double valor1, double valor2, string operador, double resultado, string dadosDigitadosOperacao, bool error)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            Operador = operador;
            Resultado = resultado;
            DadosDigitadosOperacao = dadosDigitadosOperacao;
            Error = false;
        }

        public Calculadora()
        {
        }

        public void LeituraDadosOperacao()
        {
            Console.WriteLine("=====================Calculadora C#=====================");
            Console.WriteLine();
            System.Console.WriteLine("Digite a operação que deseja calcular (Ex: 20+45)  \nOperadores disponíveis: +   -  /   *  \nAperte Enter para calcular");
            Console.WriteLine();
            DadosDigitadosOperacao = Console.ReadLine();
        }

        private void IdentificaOperador()
        {
            if (DadosDigitadosOperacao.Contains("+"))
            {
                Operador = "+";
            }
            if (DadosDigitadosOperacao.Contains("-"))
            {
                Operador = "-";
            }
            if (DadosDigitadosOperacao.Contains("/"))
            {
                Operador = "/";
            }
            if (DadosDigitadosOperacao.Contains("*"))
            {
                Operador = "*";
            }
        }

        public void TrataDadosOperacao()
        {
            IdentificaOperador();
            string[] caracteresOperacao = DadosDigitadosOperacao.Split(Operador[0]);
            Valor1 = double.Parse(caracteresOperacao[0], CultureInfo.InvariantCulture);
            Valor2 = double.Parse(caracteresOperacao[1], CultureInfo.InvariantCulture);
            if (Valor2 == 0)
            {
                Error = true;
                Console.WriteLine("Impossível divisão por zero!");
            }
        }

        public void Calcular()
        {
            if (!Error)
            {
                switch (Operador)
                {
                    case "+":
                        Resultado = Valor1 + Valor2;
                        break;
                    case "-":
                        Resultado = Valor1 - Valor2;
                        break;
                    case "/":
                        Resultado = Valor1 / Valor2;
                        break;
                    case "*":
                        Resultado = Valor1 * Valor2;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Resultado: " + Resultado.ToString("F2"));
                Console.ReadLine();
            }
        }
    }
}