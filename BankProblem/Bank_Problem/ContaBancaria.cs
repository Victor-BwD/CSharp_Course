using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Problem
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria()
        {

        }

        public ContaBancaria(int numerodaconta, string titular)
        {
            NumeroDaConta = numerodaconta;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numerodaconta, string titular, double depositoIncial) : this(numerodaconta, titular)
        {
            Deposito(depositoIncial);
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia;
            Saldo -= 5.0;
        }



        public override string ToString()
        {
            return "Conta " + NumeroDaConta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2");
        }
    }
}
