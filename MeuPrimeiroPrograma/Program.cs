using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaAna = new ContaCorrente ("Ana", 123, 456, 1000); //passa a existir um novo objeto do tipo conta corrente 
           Console.WriteLine("A conta é do(a): " +contaAna.Titular+ ", a agência é: " +contaAna.Agencia+ ", o número é: " +contaAna.Numero+ " e o saldo é: " +contaAna.Saldo+ "."); 
           bool sacarContaAna = contaAna.Sacar(500); //o tipo da variável tem que ser do mesmo que o retorno atribuído ao método
           Console.WriteLine("A conta é do(a): " +contaAna.Titular+ ", a agência é: " +contaAna.Agencia+ ", o número é: " +contaAna.Numero+ " e o saldo é: " +contaAna.Saldo+ "."); 

           ContaCorrente contaBernardo = new ContaCorrente ("Bernardo", 123, 321, 190);  
           Console.WriteLine("A conta é do(a): " +contaBernardo.Titular+ ", a agência é: " +contaBernardo.Agencia+ ", o número é: " +contaBernardo.Numero+ " e o saldo é: " +contaBernardo.Saldo+ "."); 
           bool sacarContaBernardo = contaBernardo.Sacar(50);
           Console.WriteLine("A conta é do(a): " +contaBernardo.Titular+ ", a agência é: " +contaBernardo.Agencia+ ", o número é: " +contaBernardo.Numero+ " e o saldo é: " +contaBernardo.Saldo+ "."); 

           ContaCorrente contaCarlos = new ContaCorrente ("Carlos", 123, 562, 500);  
           Console.WriteLine("A conta é do(a): " +contaCarlos.Titular+ ", a agência é: " +contaCarlos.Agencia+ ", o número é: " +contaCarlos.Numero+ " e o saldo é: " +contaCarlos.Saldo+ "."); 
           bool sacarContaCarlos = contaCarlos.Sacar(500);
           Console.WriteLine("A conta é do(a): " +contaCarlos.Titular+ ", a agência é: " +contaCarlos.Agencia+ ", o número é: " +contaCarlos.Numero+ " e o saldo é: " +contaCarlos.Saldo+ "."); 

        }
    }
} 