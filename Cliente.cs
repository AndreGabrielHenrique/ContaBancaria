public class Cliente
{
    public string separador=new string('-',50);
    public string Nome{get;set;}
    public int NumeroDaConta{get;set;}
    public double Saldo{get;private set;}
    public double Deposito{get;set;}
    public double Saque{get;set;}    
    public Cliente(string nome,int numerodaconta)
    {
        Nome=nome;
        NumeroDaConta=numerodaconta;        
    }
    public Cliente(string nome,int numerodaconta,double saldo):this(nome,numerodaconta)
    {
        Saldo=saldo;        
    }
    
    public void RealizarDeposito(double Deposito)
    {
        Saldo+=Deposito;
        Extrato();
    }
    public void RealizarSaque(double Saque)
    {
        Saldo-=Saque-5;
        Extrato();
    }
    private void Extrato()
    {
        System.Console.WriteLine($"{separador}\nNome:                   {Nome}\nNúmero da conta:        {NumeroDaConta}\nSaldo:                  {Saldo:c}\n{separador}");
    }
}