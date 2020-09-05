using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Entities
{
    class Produtos
    { 
        public string Name { get; set; }
        public double Valor { get; set; }

        public Produtos()
        {
        }

        public Produtos(string name, double valor)
        {
            Name = name;
            Valor = valor;
        }

        public Produtos (string arquivo)
        {

        }
    }
}
