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
string separador=new string('-',50);
System.Console.WriteLine(separador);
System.Console.WriteLine("Digite o nome");
string nome=Console.ReadLine();
System.Console.WriteLine("Digite o número da conta");
int numerodaconta=int.Parse(Console.ReadLine());
System.Console.WriteLine("Deseja realizar um depósito inicial?");
string fazerdepositoinicial=Console.ReadLine();
Cliente c1;
if(fazerdepositoinicial=="Sim"||fazerdepositoinicial=="SIM"||fazerdepositoinicial=="sim")
{
    System.Console.WriteLine("Digite o valor do depósito inicial");
    double depositoinicial=double.Parse(Console.ReadLine());
    c1=new Cliente(nome,numerodaconta,depositoinicial);
}
else
{
   c1=new Cliente(nome,numerodaconta);
}
System.Console.WriteLine(separador);
Console.ReadKey();
Console.Clear();
System.Console.WriteLine(separador);
System.Console.WriteLine("Digite o valor do depósito");
double Deposito=double.Parse(Console.ReadLine());
c1.RealizarDeposito(Deposito);
Console.ReadKey();
Console.Clear();
System.Console.WriteLine(separador);
System.Console.WriteLine("Digite o valor do saque (com taxa de 5 reais)");
double Saque=double.Parse(Console.ReadLine());
c1.RealizarSaque(Saque);
Console.ReadKey();
Console.Clear();