using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDeContatos
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Tipo { get; set; }

        public string Mostrar()
        {
            return $"Contato - {Nome} possui o {Tipo}: {Telefone}";
        }
    }
}
