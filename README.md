Herança
• É um tipo de associação que permite que uma classe herde dados e 
comportamentos de outra
• Definições importantes
• Vantagens
• Reuso
• Polimorfismo
• Sintaxe
• : (estende)
• base (referência para a superclasse)
--------------------------------------------------
Exemplo
Suponha um negócio de banco que possui uma conta comum e uma conta para 
empresas, sendo que a conta para empresa possui todos membros da conta 
comum, mais um limite de empréstimo e uma operação de realizar empréstimo

tipo um this de classes um this plus

---------------------------------------------------------
Herança permite o reuso de atributos e 
métodos (dados e comportamento

Definições importantes
• Relação "é-um"
• Generalização/especialização
• Superclasse (classe base) / subclasse (classe 
derivada)
• Herança / extensão
• Herança é uma associação entre classes (e não 
entre objetos)

--------------------------------------------------------
Upcasting e downcasting
Checklist
• Upcasting
• Casting da subclasse para superclasse
• Uso comum: polimorfismo
• Downcasting
• Casting da superclasse para subclasse
• Palavra as
• Palavra is
• Uso comum: métodos que recebem parâmetros genéricos (ex: Equals)

..........................-----------------.......................................
Sobreposição, palavras virtual, 
override e base

Sobreposição ou sobrescrita
• É a implementação de um método de uma superclasse na subclasse
• Para que um método comum (não 
abstrato) possa ser sobreposto, deve 
ser incluído nele o prefixo "virtual"
• Ao sobrescrever um método, devemos 
incluir nele o prefixo "override"

Suponha as seguintes regras para 
saque:
• Conta comum: é cobrada 
uma taxa no valor de 5.00.
• Conta poupança: não é 
cobrada taxa.
Como resolver isso?
Resposta: sobrescrevendo o 
método withdraw na subclasse 
SavingsAccount

Palavra base
É possível chamar a implementação da superclasse usando a palavra base.
Exemplo: suponha que a regra para saque para conta poupança seja realizar o saque 
normalmente da superclasse (Account), e depois descontar mais 2.0.
public override void Withdraw(double amount) {
base.Withdraw(amount);
Balance -= 2.0;
}

mt interessante exemplo: tenho metodo saque na classe pai e filho quero reutiliza esse metodo so q n cobrando ou cobrando taxa 
pode usa o override pra isso public override void Withdraw(double amount)
{
    Balance -= amount;
    base.Withdraw(amount);
    Balance -= 2;
}
use o virtual para poder acessar nesse caso o metodo withdraw ta com virtual acessar 

-------------------------------------------------------------------------------------------------
Classes e métodos selados

• Palavra chave: sealed
• Classe: evita que a classe seja herdada
• Nota: ainda é possível extender a funcionalidade de uma classe selada usando 
"extension methods"
namespace Course {
sealed class SavingsAccount {
• Método: evita que um método sobreposto possa ser sobreposto novamente
• Só pode ser aplicado a métodos sobrepostos

Pra quê?
• Segurança: dependendo das regras do negócio, às vezes é desejável 
garantir que uma classe não seja herdada, ou que um método não 
seja sobreposto.
• Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas 
podem ser uma porta de entrada para inconsistências
• Performance: atributos de tipo de uma classe selada são analisados 
de forma mais rápida em tempo de execução.
• Exemplo clássico: string

------------------------------------------------------------------------------------------------
Introdução ao polimorfismo
Pilares da OOP
• Encapsulamento
• Herança
• Polimorfismo

Polimorfismo
Em Programação Orientada a Objetos, polimorfismo é recurso que permite
que variáveis de um mesmo tipo mais genérico possam apontar para objetos
de tipos específicos diferentes, tendo assim comportamentos diferentes
conformecadatipo específico.
Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
acc1.Withdraw(10.0);
acc2.Withdraw(10.0);
Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance)

Importante entender
• A associação do tipo específico com o tipo genérico é feita em tempo de 
execução(upcasting).
• O compilador não sabe para qual tipo específico a chamada do método 
Withdrawestá sendo feita (ele só sabe que são duas variáveis tipo Account):
Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
acc1.Withdraw(10.0);
acc2.Withdraw(10.0)

----------------------------------------------------------------------------------------------
