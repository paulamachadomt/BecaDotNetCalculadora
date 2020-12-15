using System;

namespace Projeto
{
    class Program
    {
        public static void Main(String[] args)
        {

            string continuar = "s";

            while (continuar.Equals("s"))
            {
                try
                {
                    Calculadora calculadora = new Calculadora();

                    calculadora.LeituraDadosOperacao();

                    calculadora.TrataDadosOperacao();

                    calculadora.Calcular();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Valores inválidos. \n");                    
                }
                Console.Write("Deseja continuar? (S/N) ");
                continuar = Console.ReadLine().ToLower();
                Console.Clear();
            }                                    
        }
    }
}