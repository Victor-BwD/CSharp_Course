using System;
using System.Globalization;

namespace Bank_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao banco VICTOR! Por favor, digite as informações abaixo...");
            //declarar a classe aqui em cima para usa-la fora do if
            ContaBancaria conta;


            Console.Write("Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());//criar a variavel para receber o numero da conta
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();//criar a variavel para receber o titular
            Console.Write("Depósito inicial? (s/n)");
            char resp = char.Parse(Console.ReadLine()); //criar a variavel para receber a resposta
            if (resp == 's' || resp == 'S') //se a resposta for igual a sim
            {
                Console.Write("Entre com o valor do depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial); //cria o constructor com 3 argumentos para receber o valor do deposito

            }
            else
            {
                conta = new ContaBancaria(numero, titular);// caso for não então cria o constructor de 2 argumentos para ter o saldo 0
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor de depósito: ");
            double dep = double.Parse(Console.ReadLine()); //cria a variavel para receber o valor do deposito
            conta.Deposito(dep); // passa como parametro a variavel para a função na classe
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);// printa a classe

            Console.WriteLine();
            Console.Write("Entre com o valor do saque: ");
            double saque = double.Parse(Console.ReadLine()); //cria a variavel para receber o valor do deposito
            conta.Deposito(saque); // passa como parametro a variavel para a função na classe
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);// printa a classe




        }
    }
}
