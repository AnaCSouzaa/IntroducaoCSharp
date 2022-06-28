using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaAna = new ContaCorrente ("Ana", 123, 456, 1000); //passa a existir um novo objeto do tipo conta corrente 
           Console.WriteLine("A conta é do(a): " +contaAna.Titular+ ", a agência é: " +contaAna.Agencia+ " e o número é: " +contaAna.Numero+ "."); 
           
           ContaCorrente contaBernardo = new ContaCorrente ("Bernardo", 123, 321, 190);  
           Console.WriteLine("A conta é do(a): " +contaBernardo.Titular+ ", a agência é: " +contaBernardo.Agencia+ " e o número é: " +contaBernardo.Numero+ "."); 

           ContaCorrente contaCarlos = new ContaCorrente ("Carlos", 123, 562, 500);  
           Console.WriteLine("A conta é do(a): " +contaCarlos.Titular+ ", a agência é: " +contaCarlos.Agencia+ " e o número é: " +contaCarlos.Numero+ "."); 

        }
    }
} 