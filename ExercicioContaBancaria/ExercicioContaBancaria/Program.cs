using System;
using System.Globalization;

namespace ExercicioContaBancaria {
    class Program {
        static void Main(string[] args) {
            // criando a conta
            ContaBancaria conta;

            // perguntas iniciais
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            // validação de deposito inicial
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, nome, depInicial);

                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }
            else {
                conta = new ContaBancaria(numero, nome);

                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }

            // perguntas finais
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
