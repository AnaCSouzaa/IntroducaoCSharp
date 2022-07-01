public class ContaCorrente // acessada de qualquer lugar do código 
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
        this.Titular = Titular; //o segundo Titular é considerado variável 
        this.Agencia = Agencia;
        this.Numero = Numero; // this = representa o objeto que está sendo manipulado
        this.Saldo = Saldo;
    }

    public bool Sacar(double valorSaque) // entre o tipo do método,'public', e o método, 'Sacar', há a informação do tipo de retorno.
    {
        if (Saldo >= valorSaque)
        {
            Saldo = Saldo - valorSaque;
            return true;
        }
        return false;
    }

} 