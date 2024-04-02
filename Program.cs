/*Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta,
e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito inicial, entretanto, é opcional,
ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito
e o saldo inicial da conta será, naturalmente, zero. Importante: uma vez que uma conta bancária foi aberta,
o número da conta nunca poderá ser alterado. Já o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento,
por exemplo). Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso.
O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de $ 5.00.
Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de depósito inicial.
Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.*/
//Variáveis
string separador=new string('-',70);
string nome,fazerdepositoinicial,numerodaconta,Deposito,Saque;
//Lógica aplicada
System.Console.WriteLine(separador);
InserirNome();
Cliente c1;  
System.Console.WriteLine(separador);
Console.ReadKey();
Console.Clear();
InserirDeposito();
Console.ReadKey();
Console.Clear();
InserirSaque();
Console.ReadKey();
Console.Clear();
//Funções
//Inserir nome do cliente, com estrutura de condição para validar o input
void InserirNome()
{
    System.Console.WriteLine("Digite o nome");
    nome=Console.ReadLine();
    if(string.IsNullOrWhiteSpace(nome)||nome.Length<5)
    {
        System.Console.WriteLine($"Nome do cliente em branco ou com menos de cinco caracteres, favor reinserir.\n{separador}");
        InserirNome();
    }
    else
    {
        System.Console.WriteLine(separador);
        InserirNumeroDaConta();    
    }
}
//Inserir número da conta, com estrutura de condição para validar o input
void InserirNumeroDaConta()
{
    System.Console.WriteLine("Digite o número da conta");
    numerodaconta=Console.ReadLine();
    bool validar=numerodaconta.Length==7&&numerodaconta.All(char.IsDigit);
    if(validar==false)
    {
        System.Console.WriteLine($"Número com menos ou mais de 7 digitos, em branco ou com caracteres, favor reinserir.\n{separador}");
        InserirNumeroDaConta();
    }
    else
    {
        System.Console.WriteLine(separador);
        PerguntarDepositoInicial();
    }    
}
//Inserir depósito inicial ou não, com estrutura de condição para o usuário decidir
void PerguntarDepositoInicial()
{
    System.Console.WriteLine("Deseja realizar um depósito inicial?");
    fazerdepositoinicial=Console.ReadLine();
    if(fazerdepositoinicial.ToLower().Trim()=="sim")
    {
        InserirDepositoInicial();
    }
    else
    {    
        SemDepositoInicial();
    }    
}
void InserirDepositoInicial()
{
    System.Console.WriteLine(separador);
    System.Console.WriteLine("Digite o valor do depósito inicial");
    string digitardepositoinicial=Console.ReadLine();
    if(string.IsNullOrWhiteSpace(digitardepositoinicial)||digitardepositoinicial.All(char.IsLetter)||digitardepositoinicial=="0")
    {
        System.Console.WriteLine($"Campo em branco, com caracteres ou zerado, favor reinserir.");
        InserirDepositoInicial();
    }
    else
    {
        double.TryParse(digitardepositoinicial,out double depositoinicial);        
        c1=new Cliente(nome,numerodaconta,depositoinicial);       
    }
}
void SemDepositoInicial()
{
    if(fazerdepositoinicial.ToLower().Trim()=="não")
    {
        c1=new Cliente(nome,numerodaconta);                      
    }    
    else 
    {
        System.Console.WriteLine($"Inserção incorreta, favor reinserir.\n{separador}");
        PerguntarDepositoInicial();
    }
}
//Inserir depósito de dinheiro para o saldo, com estrutura de condição para validar o input
void InserirDeposito()
{
    System.Console.WriteLine(separador);
    System.Console.WriteLine("Digite o valor do depósito");
    Deposito=Console.ReadLine();
    if(string.IsNullOrWhiteSpace(Deposito)||Deposito.All(char.IsLetter)||Deposito=="0")
    {
        System.Console.WriteLine($"Campo em branco, com caracteres ou zerado, favor reinserir.");
        InserirDeposito();
    }
    else
    {
        double.TryParse(Deposito,out double deposito);
        c1.RealizarDeposito(deposito);
    }
}
//Inserir valor de saque do saldo com taxa de 5 reais, com estrutura de condição para validar o input
void InserirSaque()
{
    System.Console.WriteLine(separador);
    System.Console.WriteLine("Digite o valor do saque (com taxa de 5 reais)");
    Saque=Console.ReadLine();
    if(string.IsNullOrWhiteSpace(Saque)||Saque.All(char.IsLetter)||Saque=="0")
    {
        System.Console.WriteLine($"Campo em branco, com caracteres ou zerado, favor reinserir.");
        InserirSaque();
    }
    else
    {
        double.TryParse(Saque,out double saque);
        c1.RealizarSaque(saque);
    }
}