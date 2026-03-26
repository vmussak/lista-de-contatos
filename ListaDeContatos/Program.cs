using ListaDeContatos;

var lista = new ListaDeContato();

ExibirMenu();
var opcao = Console.ReadLine();

while (opcao != "4")
{
    Console.Clear();

    if(opcao == "1")
    {
        Console.Write("Nome: ");
        var nome = Console.ReadLine();
        Console.Write("Telefone: ");
        var telefone = Console.ReadLine();
        Console.Write("Tipo: ");
        var tipo = Console.ReadLine();

        lista.Adicionar(nome, telefone, tipo);
        Console.WriteLine("Contato adicionado com sucesso!");

        Console.WriteLine("-------------------------------------");
        Console.WriteLine(lista.ListarTodos());
    }

    if(opcao == "2")
    {
        var todos = lista.ListarTodos();
        Console.WriteLine(todos);
    }

    if(opcao == "3") 
    {
        Console.Write("Digite o tipo para buscar: ");
        var tipo = Console.ReadLine();
        var listaPorTipo = lista.ListarPorTipo(tipo);
        Console.WriteLine(listaPorTipo);
    }

    ExibirMenu();
    opcao = Console.ReadLine();
}   


void ExibirMenu()
{
    Console.WriteLine("--------- Lista de Contatos ---------");
    Console.WriteLine("1 - Adicionar");
    Console.WriteLine("2 - Listar Todos");
    Console.WriteLine("3 - Buscar por Tipo");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("-------------------------------------");
    Console.Write("Digite sua opção: ");
}






