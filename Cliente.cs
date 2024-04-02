public class Cliente
{
    //Variáveis
    public string separador=new string('-',70);
    public string Nome{get;set;}
    public string NumeroDaConta{get;set;}
    public double Saldo{get;private set;}
    public double Deposito{get;set;}
    public double Saque{get;set;}   
    //Construtores 
    public Cliente(string nome,string numerodaconta)
    {
        Nome=nome;
        NumeroDaConta=numerodaconta;        
    }
    public Cliente(string nome,string numerodaconta,double saldo):this(nome,numerodaconta)
    {
        Saldo=saldo;        
    }
    //Funções
    //Algoritmo para realizar depósito de dinheiro na conta, no final mostrando os dados no extrato
    public void RealizarDeposito(double deposito)
    {
        Saldo+=deposito;
        Extrato();
    }
    //Algoritmo para realizar saque de dinheiro na conta, no final mostrando os dados no extrato
    public void RealizarSaque(double Saque)
    {
        Saldo-=Saque-5;
        Extrato();
    }
    //Extrato bancário, com atribuição privada para evitar manuseio dos dados
    private void Extrato()
    {
        System.Console.WriteLine($"{separador}\nNome:                   {Nome}\nNúmero da conta:        {NumeroDaConta}\nSaldo:                  {Saldo:c}\n{separador}");
    }
}