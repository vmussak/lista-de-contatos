using ListaDeContatos;

var lista = new ListaDeContato();

lista.Adicionar("Vinicius", "99999");
lista.Adicionar("Maria", "888888");

var meusContatos = lista.ListarTodos();

Console.WriteLine(meusContatos);