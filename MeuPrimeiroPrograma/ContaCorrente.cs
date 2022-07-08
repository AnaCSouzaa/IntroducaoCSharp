public class ContaCorrente 
// instanciar = criar objetos dentro de uma determinada classe, torná-la concreta
// public = acessada de qualquer lugar do código 
{
    public string Titular; //atributos da classe (características)
    public int Agencia;
    public int Numero;
    public double Saldo;

    public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo) 
    //segue o nome da classe 
    //construtor: possui as informações necessárias para a criação de um objeto dentro de uma classe. 
    //Nesse caso, precisa haver, necessariamente, o titular, a agência,o  número e o saldo para criação da conta corrente. 
    {
        this.Titular = Titular; //o primeiro Titular é o atributo e o segundo é a variável 
        this.Agencia = Agencia;
        this.Numero = Numero; // this = representa o objeto que está sendo manipulado
        this.Saldo = Saldo;
    }

    public bool Sacar(double valorSaque)
    //método = sempre será verbo
    // entre o tipo do método,'public', e o método, 'Sacar', há a informação do tipo de retorno.
    // só há método quando houver um objeto atrelado a ele, por isso pode-se utilizar o 'this' para referenciar algum objeto 
    {
        if (this.Saldo >= valorSaque)
        {
            this.Saldo = this.Saldo - valorSaque;
            return true;
        }
        return false;
    }

    public bool Depositar(double valorDeposito)
    //método = sempre será verbo
    // entre o tipo do método,'public', e o método, 'Sacar', há a informação do tipo de retorno.
    // só há método quando houver um objeto atrelado a ele, por isso pode-se utilizar o 'this' para referenciar algum objeto 
    {
        if (valorDeposito > 0)
        {
            this.Saldo = this.Saldo + valorDeposito;
            return true;
        }
        return false;
    }

} 