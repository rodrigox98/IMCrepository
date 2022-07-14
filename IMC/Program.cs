using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Ente com a idade: ");
            int idade = (int)Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Entre com peso");
            float peso = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Peso da pessoa: " + peso);

            Console.WriteLine("Entre com a altura");
            float altura = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Altura da pessoa: {altura}");



            float result = peso / (altura * altura);

            Console.WriteLine("Olá " + nome + ", sua idade é " + idade + " anos e aqui está seu IMC");
            if (result < 18.5)
            {
                Console.WriteLine("Magrinho, seu IMC é: " + result);
            }else if(result >= 18 && result < 25)
            {
                Console.WriteLine("Normal, seu IMC é: " + result);
            }else if(result >= 25 && result <30)
            {
                Console.WriteLine("Sobrepeso, seu IMC é: " + result);
            }else if(result >=30 && result < 40)
            {
                Console.WriteLine("Obesidade, seu IMC é: " + result);
            }
            else
            {
                Console.WriteLine("Obesidade Grave, seu IMC é: " + result);
            }

        }
    }
}
