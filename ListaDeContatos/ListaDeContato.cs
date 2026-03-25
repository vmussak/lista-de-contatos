using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDeContatos
{
    public class ListaDeContato
    {
        public ListaDeContato()
        {
            _contatos = new List<Contato>();
        }

        private List<Contato> _contatos;

        public void Adicionar(string nome, string telefone, string tipo)
        {
            var x = new Contato
            {
                Nome = nome,
                Telefone = telefone,
                Tipo = tipo
            };

            _contatos.Add(x);
        }

        public string ListarTodos()
        {
            var retorno = string.Empty; //""
            foreach (var contato in _contatos) 
            {
                retorno += contato.Mostrar() + Environment.NewLine; // \n
            }

            return retorno;
        }
    }
}
