public class Cliente
{
    public string separador=new string('-',50);
    private string _nome;
    private string _numerodaconta;
    private double _depositoinicial;
    public double Saldo{get;private set;}
    private double _deposito;
    private double _saque;
    public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value)||value.Length<5)
                {
                    Console.WriteLine("Nome em branco ou com menos de 5 caracteres.");
                    return;                    
                }
            _nome=value;
            }
        }
    public string NumeroDaConta
        {
            get
            {
                return _numerodaconta;
            }
            set
            {
                if(value.Length<7||value.Length>7)
                {
                    Console.WriteLine("Número da conta não pode ter menos ou mais de 7 digitos.");
                    return;
                }
            _numerodaconta=value;
            }
        }
    public double DepositoInicial
    {
        get
        {
            return _depositoinicial;
        }
        set
        {
            if(value<=0)
            {
                Console.WriteLine("Depósito inicial não pode estar vazio ou negativo.");
                return;
            }             
        _depositoinicial=value;
        }
    }
    public double Deposito
    {
        get
        {
            return _deposito;
        }
        set
        {
            if(value<=0)
            {
                Console.WriteLine("Depósito não pode estar vazio ou negativo.");
                return;
            }                
        _deposito=value;
        }
    }
    public double Saque
    {
        get
        {
            return _saque;
        }
        set
        {
            if(value<=0)
            {
                Console.WriteLine("Saque não pode estar vazio ou negativo.");
                return;
            }                
         _saque=value;
        }
    }
    public void CriarConta()
    {
        System.Console.WriteLine(separador);
        System.Console.WriteLine("Digite o nome");
        Nome=Console.ReadLine();
        System.Console.WriteLine("Digite o número da conta");
        NumeroDaConta=Console.ReadLine();
        System.Console.WriteLine("Deseja realizar um depósito inicial?");
        string fazerdepositoinicial=Console.ReadLine();
        if(fazerdepositoinicial=="Sim"||fazerdepositoinicial=="SIM"||fazerdepositoinicial=="sim")
        {
            System.Console.WriteLine("Digite o valor do depósito inicial");
            DepositoInicial=double.Parse(Console.ReadLine());
        }
        Saldo+=DepositoInicial;
    }
    public void RealizarDeposito()
    {
        System.Console.WriteLine("Digite o valor do depósito");
        Deposito=double.Parse(Console.ReadLine());
        Saldo+=Deposito;
    }
    public void RealizarSaque()
    {
        System.Console.WriteLine("Digite o valor do saque (com taxa de 5 reais)");
        Saque=double.Parse(Console.ReadLine());
        Saldo-=Saque-5;
    }
    public override string ToString()
    {
        string mensagem=$"{separador}\nNome:                   {Nome}\nNúmero da conta:        {NumeroDaConta}\nSaldo:                  {Saldo:c}\n{separador}";
        return mensagem;
    }
}