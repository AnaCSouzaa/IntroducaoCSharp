public class ContaCorrente // acessada de qualquer lugar do código 
{
    public string Titular; //atributos da classe (características)
    public int Agencia;
    public int Numero;
    public double Saldo;

    public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo) 
    //construtor: possui as informações necessárias para a criação de um objeto dentro de uma classe. 
    //Nesse caso, precisa haver, necessariamente, o titular, agência, número e saldo para criação da conta corrente. 
    {
        this.Titular = Titular; //o segundo Titular é considerado variável
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Saldo = Saldo;
    }

} 